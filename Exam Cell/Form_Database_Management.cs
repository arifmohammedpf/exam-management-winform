﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Cell
{
    public partial class Form_Database_Management : Form
    {
        public Form_Database_Management()
        {
            InitializeComponent();
        }

        Form_Message_Box CustomMessageBox = new Form_Message_Box();

        // getting connection string from app.config
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        void SetLoading(bool loading)
        {
            if (loading)
            {
                TabPanel.Enabled = false;
                Panel_ProgressBar.BringToFront();
            }
            else
            {
                TabPanel.Enabled = true;
                Panel_ProgressBar.SendToBack();
            }
        }

        void ResetAllFormDatas()
        {
            // all combobox set to 0th index
            Combobox_Branch.SelectedIndex = 0;
            Combobox_Branch_updateStudTab.SelectedIndex = 0;
            Combobox_Branch_updateCourseTab.SelectedIndex = 0;
            Combobox_Class.SelectedIndex = 0;
            Combobox_Semester.SelectedIndex = 0;
            // clear all textboxes
            Textbox_Name.Clear();
            Textbox_ACode.Clear();
            Textbox_Regno.Clear();
            Textbox_SubCode.Clear();
            Textbox_SubName.Clear();
            Textbox_Yoa.Clear();
            // remove dgv datasource
            Dgv_ExcelData.DataSource = null;
            Dgv_Course.DataSource = null;
            Dgv_Student.DataSource = null;            
            // disable add buttons
            Button_Add_BranchExcel.Enabled = false;
            Button_Add_StudExcel.Enabled = false;
            // set loading to false
            SetLoading(false);
        }

        void ComboboxesFill()
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    // Branch combobox
                    string branchQuery = string.Format("Select Branch from Branch_Priority where Branch is not null");
                    SQLiteCommand branchCommand = new SQLiteCommand(branchQuery, dbConnection);
                    SQLiteDataAdapter branchAdapter = new SQLiteDataAdapter(branchCommand);
                    DataTable branchDT = new DataTable();
                    branchAdapter.Fill(branchDT);
                    DataRow branchTop = branchDT.NewRow();
                    branchTop[0] = "-Select-";
                    branchDT.Rows.InsertAt(branchTop, 0);

                    Combobox_Branch.DataSource = branchDT;
                    Combobox_Branch.DisplayMember = "Branch";
                    Combobox_Branch.ValueMember = "Branch";

                    Combobox_Branch_updateStudTab.DataSource = branchDT;
                    Combobox_Branch_updateStudTab.DisplayMember = "Branch";
                    Combobox_Branch_updateStudTab.ValueMember = "Branch";

                    Combobox_Branch_updateCourseTab.DataSource = branchDT;
                    Combobox_Branch_updateCourseTab.DisplayMember = "Branch";
                    Combobox_Branch_updateCourseTab.ValueMember = "Branch";

                    // Class combobox
                    string classQuery = string.Format("Select distinct Class from Students where Class is not null");
                    SQLiteCommand classCommand = new SQLiteCommand(classQuery, dbConnection);
                    SQLiteDataAdapter classAdapter = new SQLiteDataAdapter(classCommand);
                    DataTable classDT = new DataTable();
                    classAdapter.Fill(classDT);
                    DataRow classTop = classDT.NewRow();
                    classTop[0] = "-Select-";
                    classDT.Rows.InsertAt(classTop, 0);

                    Combobox_Class.DataSource = classDT;
                    Combobox_Class.DisplayMember = "Class";
                    Combobox_Class.ValueMember = "Class";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // // // // // // // // // // // // // "Add to Database" Tab - Start // // // // // // // // // // // // //

        // // Excel Event // //
        string excelType = "";
        private void Button_Select_ExcelStudent_Click(object sender, EventArgs e)
        {
            excelType = "StudentData";
            Select_ExcelFile();
        }

        private void Button_Select_ExcelBranch_Click(object sender, EventArgs e)
        {
            excelType = "BranchData";
            Select_ExcelFile();
        }
                
        DataTableCollection tableCollection;
        //Excel Select button click event
        void Select_ExcelFile()
        {
            if (excelType == "StudentData") CustomMessageBox.ShowMessageBox(" ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows and    \n exact ordering not required :  \n RegisterNo ,Name, YOA, Class, Semester  ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            else CustomMessageBox.ShowMessageBox(" ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows and    \n exact ordering not required :  \n Scheme, Branch ,Semester, Sub_Code, Sub_Name, Acode  ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel Files|*.xls|*xlsx|*.xlsm" }) //check if | is needed last?
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // filepath to be displayed in textbox
                    if (excelType == "StudentData") Textbox_Filepath_StudentExcel.Text = openFile.FileName;
                    else Textbox_Filepath_BranchExcel.Text = openFile.FileName;

                    using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;

                            Combobox_StudSheets.Items.Clear();
                            Combobox_BranchSheets.Items.Clear();

                            //add sheet to combobox
                            if(excelType == "StudentData")
                            {
                                foreach (DataTable table in tableCollection)
                                    Combobox_StudSheets.Items.Add(table.TableName); 
                            }
                            else
                            {
                                foreach (DataTable table in tableCollection)
                                    Combobox_BranchSheets.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }

        //Sheet Combobox Event
        private void Combobox_StudSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[Combobox_StudSheets.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<Class_Add_New_Student_Excel> excelClassList = new List<Class_Add_New_Student_Excel>(); //<-- Class_Add_NewStudent_Excel is class filename
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class_Add_New_Student_Excel excelClass = new Class_Add_New_Student_Excel
                        {
                            //have to give Excel column names inside the[""]
                            Name = dt.Rows[i]["Name"].ToString(),
                            Reg_No = dt.Rows[i]["RegisterNo"].ToString(),
                            YOA = dt.Rows[i]["YOA"].ToString(),
                            Class = dt.Rows[i]["Class"].ToString(),
                            Semester = dt.Rows[i]["Semester"].ToString()
                        };
                        excelClassList.Add(excelClass);
                    }
                    Dgv_ExcelData.DataSource = excelClassList;
                    Button_Add_StudExcel.Enabled = true; // move this code to "branch index change", if branch index != 0 enable else disable
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessageBox(ex.ToString(), "Exception Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            }
        }

        private void Combobox_BranchSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[Combobox_BranchSheets.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<Class_Add_New_Branch_Excel> excelClassListBranch = new List<Class_Add_New_Branch_Excel>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class_Add_New_Branch_Excel excelClassBranch = new Class_Add_New_Branch_Excel()
                        {
                            Scheme = dt.Rows[i]["Scheme"].ToString(),
                            Branch = dt.Rows[i]["Branch"].ToString(),
                            Semester = dt.Rows[i]["Semester"].ToString(),
                            Sub_Code = dt.Rows[i]["Sub_Code"].ToString(),
                            Sub_Name = dt.Rows[i]["Sub_Name"].ToString(),
                            Acode = dt.Rows[i]["Acode"].ToString()
                        };
                        excelClassListBranch.Add(excelClassBranch);
                    }
                    Dgv_ExcelData.DataSource = excelClassListBranch;
                    Button_Add_BranchExcel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.ShowMessageBox(ex.ToString(), "Exception Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            }
        }

        string timerAction;
        private void Button_Add_StudExcel_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            timerAction = "Add_StudentExcel";
            //ProgressBarTimer.Start();
            Add_StudentExcel();
        }

        private void Button_Add_BranchExcel_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            timerAction = "Add_BranchExcel";
            //ProgressBarTimer.Start();
            Add_BranchExcel();
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            ProgressBarTimer.Stop();
            if (timerAction == "Add_StudentExcel") Add_StudentExcel();
            else if (timerAction == "Add_BranchExcel") Add_BranchExcel();
        }

        void Add_StudentExcel()
        {
            CustomMessageBox.ShowMessageBox("Do you want to add Student records from selected excel sheet ?   ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    if (Combobox_Branch.SelectedIndex != 0)
                    {
                        // add to db
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            string query = string.Format("insert into Students(Reg_No,Name,YOA,Class,Semester,Branch)Values(" + "@Reg_No,@Name,@YOA,@Class,@Semester,@Branch)");
                            foreach (DataGridViewRow dr in Dgv_ExcelData.Rows)
                            {
                                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                                command.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value);
                                command.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value);
                                command.Parameters.AddWithValue("@YOA", dr.Cells["YOA"].Value);
                                command.Parameters.AddWithValue("@Class", dr.Cells["Class"].Value);
                                command.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value);
                                command.Parameters.AddWithValue("@Branch", Combobox_Branch.SelectedItem.ToString());
                                command.ExecuteNonQuery();
                            }
                        }

                        // reset
                        ComboboxesFill();
                        ResetAllFormDatas();
                        CustomMessageBox.ShowMessageBox("Student records from excel sheet added   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else CustomMessageBox.ShowMessageBox("Select Branch", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    ResetAllFormDatas();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        void Add_BranchExcel()
        {
            CustomMessageBox.ShowMessageBox("Do you want to add Branch/Courses from selected excel sheet ?   ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    // add to db
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        String[] newBranches = new string[20];
                        string currBranch = "";
                        string query = string.Format("insert into Scheme(Scheme,Branch,Semester,Sub_Name,Sub_Code,Acode)Values(" + " @Scheme,@Branch,@Semester,@Sub_Name,@Sub_Code,@Acode)");
                        foreach (DataGridViewRow dr in Dgv_ExcelData.Rows)
                        {
                            if (currBranch != dr.Cells["Branch"].Value.ToString())
                            {
                                currBranch = dr.Cells["Branch"].Value.ToString();
                                newBranches = newBranches.Concat(new string[] { currBranch }).ToArray();
                            }
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            command.Parameters.AddWithValue("@Scheme", dr.Cells["Scheme"].Value.ToString());
                            command.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                            command.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                            command.Parameters.AddWithValue("@Sub_Name", dr.Cells["Sub_Name"].Value.ToString());
                            command.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                            command.Parameters.AddWithValue("@Acode", dr.Cells["Acode"].Value.ToString());
                            command.ExecuteNonQuery();
                        }
                    }

                    // reset
                    ComboboxesFill();
                    ResetAllFormDatas();
                    CustomMessageBox.ShowMessageBox("Branch/Courses from excel sheet added   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ResetAllFormDatas();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // // // // // // // // // // // // // "Add to Database" Tab - End // // // // // // // // // // // // //


        // // // // // // // // // // // // // "Update Student" Tab - Start // // // // // // // // // // // // //

        void SearchStudentRecord()
        {
            string regno = Textbox_Regno.Text;
            string name = Textbox_Name.Text;
            string branch = Combobox_Branch_updateStudTab.SelectedItem.ToString();
            string yoa = Textbox_Yoa.Text;
            string semester = Combobox_Semester.SelectedItem.ToString();
            string studentClass = Combobox_Class.SelectedItem.ToString();
            Dgv_Student.DataSource = null;

            string searchRecord = "";        // string for sql statements to be written
            if (regno != "")
                searchRecord = string.Format("Reg_No like '%{0}%'", regno);
            if (name != "")
            {
                if (searchRecord.Length > 0) searchRecord += " AND ";
                searchRecord += string.Format("Name Like '%{0}%'", name);
            }
            if (branch != "-Select-")
            {
                if (searchRecord.Length > 0) searchRecord += " AND ";                //Put AND if there is existing Sql statement in searchRecord string
                searchRecord += string.Format("Branch Like '%{0}%'", branch);   //Put sql statement in searchRecord string
            }
            if (semester != "-Select-")
            {
                if (searchRecord.Length > 0) searchRecord += " AND ";                //Put AND if there is existing Sql statement in searchRecord string
                searchRecord += string.Format("Semester Like '%{0}%'", semester);   //Put sql statement in searchRecord string
            }
            if (studentClass != "-Select-")
            {
                if (searchRecord.Length > 0) searchRecord += " AND ";                //Put AND if there is existing Sql statement in searchRecord string
                searchRecord += string.Format("Class Like '%{0}%'", studentClass);   //Put sql statement in searchRecord string
            }
            if (yoa != "")
            {
                if (searchRecord.Length > 0) searchRecord += " AND ";
                searchRecord += string.Format("YOA Like '%{0}%'", yoa);
            }
            string query = "Select * from Students where " + searchRecord;
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataTable studentRecord = new DataTable();
                dataAdapter.Fill(studentRecord);
                Dgv_Student.DataSource = studentRecord;
            }
            SetLoading(false);
        }

        private void Button_Search_updateStudentTab_Click(object sender, EventArgs e)
        {
            try
            {
                SetLoading(true);
                SearchStudentRecord();
            }
            catch(Exception ex)
            {
                ResetAllFormDatas();
                MessageBox.Show(ex.ToString());
            }
        }

        private void Dgv_Student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // fill the form
            Textbox_Regno.Text = Dgv_Student.Rows[e.RowIndex].Cells["Reg_No"].Value.ToString();
            Textbox_Name.Text = Dgv_Student.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Textbox_Yoa.Text = Dgv_Student.Rows[e.RowIndex].Cells["YOA"].Value.ToString();
            Combobox_Semester.SelectedItem = Dgv_Student.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
            Combobox_Branch_updateStudTab.SelectedItem = Dgv_Student.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
            Combobox_Class.SelectedItem = Dgv_Student.Rows[e.RowIndex].Cells["Class"].Value.ToString();
        }

        private void Button_Update_updateStudentTab_Click(object sender, EventArgs e)
        {
            if(Textbox_Regno.Text == "" || Textbox_Name.Text == "" || Textbox_Yoa.Text == "" || Combobox_Semester.SelectedIndex == 0 || Combobox_Class.SelectedIndex == 0 || Combobox_Branch_updateStudTab.SelectedIndex == 0) CustomMessageBox.ShowMessageBox("Please fill all info of student to be updated ", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            else
            {
                string messageText = string.Format("Do you want to update record of '%{0}%' ?   ", Textbox_Regno.Text);
                CustomMessageBox.ShowMessageBox(messageText, "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
                string result = CustomMessageBox.UserChoice;
                if (result == "Yes")
                {
                    int recordsAffected;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        string query = string.Format("Update Students set Name=@Name,YOA=@YOA,Branch=@Branch,Semester=@Semester,Class=@Class where Reg_No=@Reg_No");
                        SQLiteCommand command = new SQLiteCommand(query,dbConnection);
                        command.Parameters.AddWithValue("@Reg_No", Textbox_Regno.Text);
                        command.Parameters.AddWithValue("@Name", Textbox_Name.Text);
                        command.Parameters.AddWithValue("@YOA", Textbox_Yoa.Text);
                        command.Parameters.AddWithValue("@Branch", Combobox_Branch_updateStudTab.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Semester", Combobox_Semester.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Class", Combobox_Class.SelectedItem.ToString());
                        recordsAffected = command.ExecuteNonQuery();
                    }
                    if (recordsAffected == 0) CustomMessageBox.ShowMessageBox("Given Reg_No does not exist, Try again  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Clear_updateStudentTab_Click(object sender, EventArgs e)
        {
            ResetAllFormDatas();
        }

        private void HeaderCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (HeaderCheckbox.Checked)
            {
                foreach (DataGridViewRow row in Dgv_Student.Rows)
                {
                    row.Cells["CheckBoxColumn"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in Dgv_Student.Rows)
                {
                    row.Cells["CheckBoxColumn"].Value = false;
                }
            }
        }

        private void Button_Delete_Selected_updateStudentTab_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Do you really want to delete selected student records ?", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    SetLoading(true);
                    bool deletedFlag = false;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        // delete selected records
                        foreach (DataGridViewRow dr in Dgv_Student.Rows)
                        {
                            bool isSelected = Convert.ToBoolean(dr.Cells["CheckBoxColumn"].Value);
                            if (isSelected)
                            {
                                string query = string.Format("Delete from Students where Reg_No=@Reg_No and Name=@Name and YOA=@YOA and Branch=@Branch and Semester=@Semester and Class=@Class");
                                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                                command.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value.ToString());
                                command.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value.ToString());
                                command.Parameters.AddWithValue("@YOA", dr.Cells["YOA"].Value.ToString());
                                command.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                command.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                                command.Parameters.AddWithValue("@Class", dr.Cells["Class"].Value.ToString());
                                command.ExecuteNonQuery();
                                deletedFlag = true;
                            }
                        }
                    }
                    if (deletedFlag)
                    {
                        ResetAllFormDatas();
                        CustomMessageBox.ShowMessageBox("Selected student records deleted   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else
                    {
                        SetLoading(false);
                        CustomMessageBox.ShowMessageBox("Select any student to delete   ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    ResetAllFormDatas();
                }
            }
        }

        // // // // // // // // // // // // // "Update Student" Tab - End // // // // // // // // // // // // //


        // // // // // // // // // // // // // "Update Course" Tab - Start // // // // // // // // // // // // //

        // // // // // // // // // // // // // "Update Course" Tab - End // // // // // // // // // // // // //
    }
}

// // // // // // // // // // // FOR TESTING // // // // // // // // // // // //
// 1. Branch combobox in all the tabs since we gave same datatable as DataSource of combobox
// 2. open update student tab and try search without filling form and,
//  click dgv cell to auto fill and try update button to check whether dgv cell click selectedItem in combobox changes the selectedIndex.
// 3. update student with incorrect reg No
// 4. headerCheckbox