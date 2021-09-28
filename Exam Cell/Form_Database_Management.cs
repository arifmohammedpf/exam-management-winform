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
            Combobox_Semester_updateCourse.SelectedIndex = 0;
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
            // clear selected record variables
            selectedRegNo = "";
            selectedName = "";
            selectedYoa = "";
            selectedSemester = "";
            selectedBranch = "";
            selectedClass = "";
            selectedSubCode = "";
            selectedSubName = "";
            selectedAcode = "";
            selectedBranch_Course = "";
            selectedSemester_Course = "";
            HeaderCheckbox.Checked = false;
            HeaderCheckbox_CourseDgv.Checked = false;
            // set loading to false
            SetLoading(false);
        }

        void ComboboxesFill()
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    // Branch combobox
                    Combobox_Branch.DataSource = null;
                    Combobox_Branch_updateStudTab.DataSource = null;
                    Combobox_Branch_updateCourseTab.DataSource = null;

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
                    Combobox_Class.DataSource = null;

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
                Combobox_Semester.SelectedIndex = 0;
                Combobox_Semester_updateCourse.SelectedIndex = 0;
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
            if (excelType == "StudentData") CustomMessageBox.ShowMessageBox(" ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows and    \n exact ordering not required :  \n RegisterNo ,Name, YOA, Class, Semester \n\n\n\n ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            else CustomMessageBox.ShowMessageBox(" ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows and    \n exact ordering not required :  \n Scheme, Branch ,Semester, Sub_Code, Course, Acode \n\n\n\n ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm" }) //check if | is needed last?
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
                DataTable dt = tableCollection[Combobox_StudSheets.Text];
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
                DataTable dt = tableCollection[Combobox_BranchSheets.Text];
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
                            Course = dt.Rows[i]["Course"].ToString(),
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
                            dbConnection.Open();
                            string query = string.Format("insert into Students(Reg_No,Name,YOA,Class,Semester,Branch)Values(" + "@Reg_No,@Name,@YOA,@Class,@Semester,@Branch)");
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            foreach (DataGridViewRow dr in Dgv_ExcelData.Rows)
                            {
                                command.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value);
                                command.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value);
                                command.Parameters.AddWithValue("@YOA", dr.Cells["YOA"].Value);
                                command.Parameters.AddWithValue("@Class", dr.Cells["Class"].Value);
                                command.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value);
                                command.Parameters.AddWithValue("@Branch", Combobox_Branch.Text);
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

        void AddToBranchPriorityDB()
        {
            string distinctBranchQuery = string.Format("Select distinct Branch from Scheme");
            string branchPriorityQuery = string.Format("Select * from Branch_Priority");
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand branchCommand = new SQLiteCommand(distinctBranchQuery, dbConnection);
                SQLiteDataAdapter branchAdapter = new SQLiteDataAdapter(branchCommand);
                DataTable branchDT = new DataTable();
                branchAdapter.Fill(branchDT);

                SQLiteCommand priorityBranchCommand = new SQLiteCommand(branchPriorityQuery, dbConnection);
                SQLiteDataAdapter priorityBranchAdapter = new SQLiteDataAdapter(priorityBranchCommand);
                DataTable priorityBranchDT = new DataTable();
                priorityBranchAdapter.Fill(priorityBranchDT);

                bool isBranchExist = false;
                int priorityCount = priorityBranchDT.Rows.Count + 1;
                string query = string.Format("insert into Branch_Priority(Branch,Priority)Values(" + " @Branch,@Priority)");
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                foreach (DataRow branchRow in branchDT.Rows)
                {
                    foreach(DataRow priorityRow in priorityBranchDT.Rows)
                    {
                        if(priorityRow["Branch"].ToString() == branchRow["Branch"].ToString())
                        {
                            isBranchExist = true;
                            break;
                        }
                    }
                    if (!isBranchExist)
                    {
                        command.Parameters.AddWithValue("@Branch", branchRow["Branch"].ToString());
                        command.Parameters.AddWithValue("@Priority", priorityCount.ToString());
                        command.ExecuteNonQuery();
                        priorityCount++;
                    }
                    else isBranchExist = false;
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
                        dbConnection.Open();
                        //String[] newBranches = new string[20];
                        //string currBranch = "";
                        string query = string.Format("insert into Scheme(Scheme,Branch,Semester,Course,Sub_Code,Acode)Values(" + " @Scheme,@Branch,@Semester,@Course,@Sub_Code,@Acode)");
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_ExcelData.Rows)
                        {
                            //if (currBranch != dr.Cells["Branch"].Value.ToString())
                            //{
                            //    currBranch = dr.Cells["Branch"].Value.ToString();
                            //    newBranches = newBranches.Concat(new string[] { currBranch }).ToArray();
                            //}
                            command.Parameters.AddWithValue("@Scheme", dr.Cells["Scheme"].Value.ToString());
                            command.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                            command.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                            command.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                            command.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                            command.Parameters.AddWithValue("@Acode", dr.Cells["Acode"].Value.ToString());
                            command.ExecuteNonQuery();
                        }                        
                    }
                    // Add new branches to branch priority DB
                    AddToBranchPriorityDB();
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
            Dgv_Student.DataSource = null;
            HeaderCheckbox.Checked = false;
            string regno = Textbox_Regno.Text;
            string name = Textbox_Name.Text;
            string branch = Combobox_Branch_updateStudTab.Text;
            string yoa = Textbox_Yoa.Text;
            string semester = Combobox_Semester.Text;
            string studentClass = Combobox_Class.Text;

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
                dbConnection.Open();
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
        
        string selectedRegNo, selectedName, selectedYoa, selectedSemester, selectedBranch, selectedClass;
        private void Dgv_Student_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // fill the form
            Textbox_Regno.Text = Dgv_Student.Rows[e.RowIndex].Cells["Reg_No"].Value.ToString();
            Textbox_Name.Text = Dgv_Student.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Textbox_Yoa.Text = Dgv_Student.Rows[e.RowIndex].Cells["YOA"].Value.ToString();
            Combobox_Semester.SelectedItem = Dgv_Student.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
            Combobox_Branch_updateStudTab.SelectedItem = Dgv_Student.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
            Combobox_Class.SelectedItem = Dgv_Student.Rows[e.RowIndex].Cells["Class"].Value.ToString();

            // selected student record to be updated
            selectedRegNo = Dgv_Student.Rows[e.RowIndex].Cells["Reg_No"].Value.ToString();
            selectedName = Dgv_Student.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            selectedYoa = Dgv_Student.Rows[e.RowIndex].Cells["YOA"].Value.ToString();
            selectedSemester = Dgv_Student.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
            selectedBranch = Dgv_Student.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
            selectedClass = Dgv_Student.Rows[e.RowIndex].Cells["Class"].Value.ToString();
        }

        private void Button_Update_updateStudentTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedRegNo == "" || Textbox_Regno.Text == "" || Textbox_Name.Text == "" || Textbox_Yoa.Text == "" || Combobox_Semester.SelectedIndex == 0 || Combobox_Class.SelectedIndex == 0 || Combobox_Branch_updateStudTab.SelectedIndex == 0) CustomMessageBox.ShowMessageBox("Please select and fill all info of student to be updated ", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                else
                {
                    string messageText = string.Format("Do you want to update record of {0} - {1} ?   ", selectedRegNo, selectedName);
                    CustomMessageBox.ShowMessageBox(messageText, "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
                    string result = CustomMessageBox.UserChoice;
                    if (result == "Yes")
                    {
                        int recordsAffected;
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            dbConnection.Open();
                            string query = string.Format("Update Students set Reg_No=@Reg_No,Name=@Name,YOA=@YOA,Branch=@Branch,Semester=@Semester,Class=@Class where Reg_No=@SelectedReg_No and Name=@SelectedName and YOA=@SelectedYOA and Branch=@SelectedBranch and Semester=@SelectedSemester and Class=@SelectedClass");
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            command.Parameters.AddWithValue("@Reg_No", Textbox_Regno.Text);
                            command.Parameters.AddWithValue("@Name", Textbox_Name.Text);
                            command.Parameters.AddWithValue("@YOA", Textbox_Yoa.Text);
                            command.Parameters.AddWithValue("@Branch", Combobox_Branch_updateStudTab.Text);
                            command.Parameters.AddWithValue("@Semester", Combobox_Semester.Text);
                            command.Parameters.AddWithValue("@Class", Combobox_Class.Text);
                            command.Parameters.AddWithValue("@SelectedReg_No", selectedRegNo);
                            command.Parameters.AddWithValue("@SelectedName", selectedName);
                            command.Parameters.AddWithValue("@SelectedYOA", selectedYoa);
                            command.Parameters.AddWithValue("@SelectedBranch", selectedBranch);
                            command.Parameters.AddWithValue("@SelectedSemester", selectedSemester);
                            command.Parameters.AddWithValue("@SelectedClass", selectedClass);
                            recordsAffected = command.ExecuteNonQuery();
                        }
                        if (recordsAffected == 0)
                        {
                            messageText = string.Format("{0} - {1} does not exist, Try again    ", selectedRegNo, selectedName);
                            CustomMessageBox.ShowMessageBox(messageText, "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                            return;
                        }
                        ComboboxesFill();
                        ResetAllFormDatas();
                        CustomMessageBox.ShowMessageBox("Student record updated   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Clear_updateStudentTab_Click(object sender, EventArgs e)
        {
            ResetAllFormDatas();
        }

        // when headerCheckbox state change event triggers, we need to make sure it is not triggered from Dgv CheckBox Click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void Dgv_Student_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Student.Columns["CheckBoxColumn"].Index)
                Dgv_Student.EndEdit();
        }

        private void Dgv_Student_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Student.Columns["CheckBoxColumn"].Index)
            {
                if (HeaderCheckbox.Checked)
                {
                    isCheckBoxColumn_ClickedEvent = true;
                    HeaderCheckbox.Checked = false;
                }
            }
        }

        private void HeaderCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent)
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

            isCheckBoxColumn_ClickedEvent = false;
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
                        dbConnection.Open();
                        // delete selected records
                        string query = string.Format("Delete from Students where Reg_No=@Reg_No and Name=@Name and YOA=@YOA and Branch=@Branch and Semester=@Semester and Class=@Class");
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_Student.Rows)
                        {
                            bool isSelected = Convert.ToBoolean(dr.Cells["CheckBoxColumn"].Value);
                            if (isSelected)
                            {                                
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
                        ComboboxesFill();
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
                    ComboboxesFill();
                    ResetAllFormDatas();
                    MessageBox.Show(ex.ToString());
                }
            }
        }        

        void Promote_or_Demote_Students(string query)
        {
            try
            {
                SetLoading(true);
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    command.ExecuteNonQuery();
                }                
                ResetAllFormDatas();
                CustomMessageBox.ShowMessageBox("All Students semester updated   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                ResetAllFormDatas();
            }
        }
        private void Button_Promote_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Do you really want to Promote every students semester ?", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                string query = string.Format("Update Students set Semester = Semester + 1");
                Promote_or_Demote_Students(query);                
            }
        }        

        private void Button_Demote_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Do you really want to Demote every students semester ?", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                string query = string.Format("Update Students set Semester = Semester - 1");
                Promote_or_Demote_Students(query);
            }
        }        

        // // // // // // // // // // // // // "Update Student" Tab - End // // // // // // // // // // // // //


        // // // // // // // // // // // // // "Update Course" Tab - Start // // // // // // // // // // // // //

        private void Button_Search_updateCourseTab_Click(object sender, EventArgs e)
        {
            try
            {
                SetLoading(true);
                string branch = Combobox_Branch_updateCourseTab.Text;
                string semester = Combobox_Semester_updateCourse.Text;
                string subcode = Textbox_SubCode.Text;
                string subname = Textbox_SubName.Text;
                string acode = Textbox_ACode.Text;
                Dgv_Course.DataSource = null;

                string searchRecord = "";        // string for sql statements to be written
                
                if (branch != "-Select-")
                {
                    searchRecord = string.Format("Branch Like '%{0}%'", branch);   //Put sql statement in searchRecord string
                }
                if (semester != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";                //Put AND if there is existing Sql statement in searchRecord string
                    searchRecord += string.Format("Semester Like '%{0}%'", semester);   //Put sql statement in searchRecord string
                }
                if (subcode != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";                //Put AND if there is existing Sql statement in searchRecord string
                    searchRecord += string.Format("Sub_Code Like '%{0}%'", subcode);   //Put sql statement in searchRecord string
                }
                if (subname != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";                //Put AND if there is existing Sql statement in searchRecord string
                    searchRecord += string.Format("Course Like '%{0}%'", subname);   //Put sql statement in searchRecord string
                }
                if (acode != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Acode Like '%{0}%'", acode);
                }

                string query = "Select * from Scheme where " + searchRecord;
                MessageBox.Show(query);
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable branchRecord = new DataTable();
                    dataAdapter.Fill(branchRecord);
                    Dgv_Course.DataSource = branchRecord;
                }
                SetLoading(false);
            }
            catch (Exception ex)
            {
                ResetAllFormDatas();
                MessageBox.Show(ex.ToString());
            }
        }        

        private void Form_Database_Management_Load(object sender, EventArgs e)
        {
            ComboboxesFill();
        }

        string selectedSubCode, selectedSubName, selectedAcode, selectedBranch_Course, selectedSemester_Course;
        private void Dgv_Course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // fill the form
            Textbox_SubCode.Text = Dgv_Course.Rows[e.RowIndex].Cells["Sub_Code"].Value.ToString();
            Textbox_SubName.Text = Dgv_Course.Rows[e.RowIndex].Cells["Course"].Value.ToString();
            Textbox_ACode.Text = Dgv_Course.Rows[e.RowIndex].Cells["Acode"].Value.ToString();
            Combobox_Branch_updateCourseTab.SelectedItem = Dgv_Course.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
            Combobox_Semester_updateCourse.SelectedItem = Dgv_Course.Rows[e.RowIndex].Cells["Semester"].Value.ToString();

            // selected branch/course record to be updated
            selectedSubCode = Dgv_Course.Rows[e.RowIndex].Cells["Sub_Code"].Value.ToString();
            selectedSubName = Dgv_Course.Rows[e.RowIndex].Cells["Course"].Value.ToString();
            selectedAcode = Dgv_Course.Rows[e.RowIndex].Cells["Acode"].Value.ToString();
            selectedBranch_Course = Dgv_Course.Rows[e.RowIndex].Cells["Branch"].Value.ToString();
            selectedSemester_Course = Dgv_Course.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
        }

        private void Button_Update_updateCourseTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSubCode == "" || Textbox_SubCode.Text == "" || Textbox_SubName.Text == "" || Textbox_ACode.Text == "" || Combobox_Branch_updateCourseTab.SelectedIndex == 0) CustomMessageBox.ShowMessageBox("Please select and fill all info of Branch/Course to be updated ", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                else
                {
                    string messageText = string.Format("Do you want to update {0} - {1} of Semester {2} ?   ", selectedSubCode, selectedSubName, selectedSemester_Course);
                    CustomMessageBox.ShowMessageBox(messageText, "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
                    string result = CustomMessageBox.UserChoice;
                    if (result == "Yes")
                    {
                        int recordsAffected;
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            dbConnection.Open();
                            string query = string.Format("Update Scheme set Sub_Code=@Sub_Code,Course=@Course,Acode=@Acode,Branch=@Branch,Semester=@Semester where Sub_Code=@SelectedSub_Code and Course=@SelectedCourse and Acode=@SelectedAcode and Branch=@SelectedBranch and Semester=@SelectedSemester");
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            command.Parameters.AddWithValue("@Sub_Code", Textbox_SubCode.Text);
                            command.Parameters.AddWithValue("@Course", Textbox_Name.Text);
                            command.Parameters.AddWithValue("@Acode", Textbox_ACode.Text);
                            command.Parameters.AddWithValue("@Branch", Combobox_Branch_updateCourseTab.Text);
                            command.Parameters.AddWithValue("@Semester", Combobox_Semester_updateCourse.Text);
                            command.Parameters.AddWithValue("@SelectedSub_Code", selectedSubCode);
                            command.Parameters.AddWithValue("@SelectedCourse", selectedSubName);
                            command.Parameters.AddWithValue("@SelectedAcode", selectedAcode);
                            command.Parameters.AddWithValue("@SelectedBranch", selectedBranch_Course);
                            command.Parameters.AddWithValue("@SelectedSemester", selectedSemester_Course);
                            recordsAffected = command.ExecuteNonQuery();
                        }
                        if (recordsAffected == 0)
                        {
                            messageText = string.Format("{0} - {1} of Semester {2} does not exist, Try again ", selectedSubCode, selectedSubName,selectedSemester_Course);
                            CustomMessageBox.ShowMessageBox(messageText, "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                        }
                        ComboboxesFill();
                        ResetAllFormDatas();
                        CustomMessageBox.ShowMessageBox("Branch/Course updated   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool isCourseDgvChekboxColumn_ClickedEvent = false;
        private void Dgv_Course_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Course.Columns["CheckboxColumn_CourseDgv"].Index)
                Dgv_Course.EndEdit();
        }

        private void Dgv_Course_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Course.Columns["CheckboxColumn_CourseDgv"].Index)
            {
                if (HeaderCheckbox_CourseDgv.Checked)
                {
                    isCourseDgvChekboxColumn_ClickedEvent = true;
                    HeaderCheckbox_CourseDgv.Checked = false;
                }
            }
        }

        private void HeaderCheckbox_CourseDgv_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCourseDgvChekboxColumn_ClickedEvent)
            {
                if (HeaderCheckbox_CourseDgv.Checked)
                {
                    foreach (DataGridViewRow row in Dgv_Course.Rows)
                    {
                        row.Cells["CheckboxColumn_CourseDgv"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in Dgv_Course.Rows)
                    {
                        row.Cells["CheckboxColumn_CourseDgv"].Value = false;
                    }
                }
            }
            isCourseDgvChekboxColumn_ClickedEvent = false;
        }

        private void Button_Delete_updateCourseTab_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Do you really want to delete selected Courses ?", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    SetLoading(true);
                    bool deletedFlag = false;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        // delete selected courses
                        string query = string.Format("Delete from Scheme where Sub_Code=@SelectedSub_Code and Course=@SelectedCourse and Acode=@SelectedAcode and Branch=@SelectedBranch and Semester=@SelectedSemester");
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_Course.Rows)
                        {
                            bool isSelected = Convert.ToBoolean(dr.Cells["CheckboxColumn_CourseDgv"].Value);
                            if (isSelected)
                            {                                
                                command.Parameters.AddWithValue("@SelectedSub_Code", dr.Cells["Sub_Code"].Value.ToString());
                                command.Parameters.AddWithValue("@SelectedCourse", dr.Cells["Course"].Value.ToString());
                                command.Parameters.AddWithValue("@SelectedAcode", dr.Cells["Acode"].Value.ToString());
                                command.Parameters.AddWithValue("@SelectedBranch", dr.Cells["Branch"].Value.ToString());
                                command.Parameters.AddWithValue("@SelectedSemester", dr.Cells["Semester"].Value.ToString());
                                command.ExecuteNonQuery();
                                deletedFlag = true;
                            }
                        }
                    }
                    if (deletedFlag)
                    {
                        ComboboxesFill();
                        ResetAllFormDatas();
                        CustomMessageBox.ShowMessageBox("Selected Courses deleted   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else
                    {
                        SetLoading(false);
                        CustomMessageBox.ShowMessageBox("Select any Course to delete   ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    ComboboxesFill();
                    ResetAllFormDatas();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Button_Clear_updateCourseTab_Click(object sender, EventArgs e)
        {
            ResetAllFormDatas();
        }

        // // // // // // // // // // // // // "Update Course" Tab - End // // // // // // // // // // // // //
    }
}

// // // // // // // // // // // FOR TESTING // // // // // // // // // // // //
// *** check if we get error when reset form triggers, since headercheckbox = false is given last of resetForm function and dgv datasoure is null.

// *** is timer needed ? ***
// *** fill semester combobox of Course tab as "1 & 2" or "1 and 2" whatever... ***

// 1. Branch combobox in all the tabs since we gave same datatable as DataSource of combobox
// 2. open update student tab and try search without filling form and,
//  click dgv cell to auto fill and try update button to check whether dgv cell click selectedItem in combobox changes the selectedIndex.
// 3. update student with incorrect reg No
// 4. headerCheckbox
// 5. update without selecting dgv first time opening form for both student and course.
// 6. select long Course and semester to check the Custom Message Box in Update Course Tab.