using ExcelDataReader;
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
        void ResetAllFormDatas()
        {
            // all combobox set to 0th index
            Combobox_Branch.SelectedIndex = 0;
            Combobox_Branch_updateStudTab.SelectedIndex = 0;
            Combobox_Branch_updateCourseTab.SelectedIndex = 0;
            Combobox_Class.SelectedIndex = 0;
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
            // hide progress panel
            Panel_ProgressBar.SendToBack();
            // enable tabform
            TabPanel.Enabled = true;
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

                    Combobox_Branch.ValueMember = "Branch";
                    Combobox_Branch.DataSource = branchDT;

                    Combobox_Branch_updateStudTab.ValueMember = "Branch";
                    Combobox_Branch_updateStudTab.DataSource = branchDT;

                    Combobox_Branch_updateCourseTab.ValueMember = "Branch";
                    Combobox_Branch_updateCourseTab.DataSource = branchDT;

                    // Class combobox
                    string classQuery = string.Format("Select distinct Class from Students where Class is not null");
                    SQLiteCommand classCommand = new SQLiteCommand(classQuery, dbConnection);
                    SQLiteDataAdapter classAdapter = new SQLiteDataAdapter(classCommand);
                    DataTable classDT = new DataTable();
                    classAdapter.Fill(classDT);
                    DataRow classTop = classDT.NewRow();
                    classTop[0] = "-Select-";
                    classDT.Rows.InsertAt(classTop, 0);

                    Combobox_Class.ValueMember = "Class";
                    Combobox_Class.DataSource = classDT;
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
        
        int message_warning_flag = 0;
        DataTableCollection tableCollection;
        //Excel Select button click event
        void Select_ExcelFile()
        {
            if (message_warning_flag == 0)
            {
                message_warning_flag = 1;
                CustomMessageBox.ShowMessageBox("ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows :      \n RegisterNo ,Name, YOA, Branch   ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            }
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
            TabPanel.Enabled = false;
            Panel_ProgressBar.BringToFront();
            timerAction = "Add_StudentExcel";
            //ProgressBarTimer.Start();
            Add_StudentExcel();
        }

        private void Button_Add_BranchExcel_Click(object sender, EventArgs e)
        {
            TabPanel.Enabled = false;
            Panel_ProgressBar.BringToFront();
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
            try
            {
                if(Combobox_Branch.SelectedIndex != 0)
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
                    CustomMessageBox.ShowMessageBox("Excel datas Added   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                else CustomMessageBox.ShowMessageBox("Select Branch", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);                
            }
            catch (Exception ex)
            {
                ResetAllFormDatas();
                MessageBox.Show(ex.ToString());
            }
        }
        void Add_BranchExcel()
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
            }
            catch (Exception ex)
            {
                ResetAllFormDatas();
                MessageBox.Show(ex.ToString());
            }            
        }
        // // // // // // // // // // // // // "Add to Database" Tab - End // // // // // // // // // // // // //


        // // // // // // // // // // // // // "Update Student" Tab - Start // // // // // // // // // // // // //

        // // // // // // // // // // // // // "Update Student" Tab - End // // // // // // // // // // // // //


        // // // // // // // // // // // // // "Update Course" Tab - Start // // // // // // // // // // // // //

        // // // // // // // // // // // // // "Update Course" Tab - End // // // // // // // // // // // // //
    }
}
