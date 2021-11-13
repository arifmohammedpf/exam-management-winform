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
    public partial class Form_Candidate_Entry : Form
    {
        public Form_Candidate_Entry()
        {
            InitializeComponent();
        }

        Form_Message_Box CustomMessageBox = new Form_Message_Box();

        // getting connection string from app.config
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Form_Candidate_Entry_Load(object sender, EventArgs e)
        {
            ComboboxesFill();
            Radio_University.Checked = true;
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    TabControl.TabPages.Insert(0, Tab_Excel_Import);
        //    this.Tab_Excel_Import.Show();
        //    TabControl.SelectedTab = Tab_Excel_Import;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    TabControl.TabPages.Remove(Tab_Excel_Import);
        //    this.Tab_Excel_Import.Hide();

        //}

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable GetDataTable(string choice)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                string query;
                if (choice == "Branch") query = string.Format("Select Branch from Branch_Priority where Branch is not null");
                else if (choice == "Scheme") query = string.Format("Select distinct Scheme from Scheme where Scheme is not null");
                else query = string.Format("Select distinct Class from Students where Semester={0} and Class is not null", Combobox_Semester_ClassSearch.Text);
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                DataTable queryDatatable = new DataTable();
                adapter.Fill(queryDatatable);
                DataRow datatableTop = queryDatatable.NewRow();
                datatableTop[0] = "-Select-";
                queryDatatable.Rows.InsertAt(datatableTop, 0);
                return queryDatatable;
            }                
        }

        void ComboboxesFill()
        {
            try
            {
                Combobox_Branch_Cand_Register.DataSource = null;
                Combobox_Branch_SchemeSearch.DataSource = null;
                Combobox_Scheme.DataSource = null;

                // Branch
                DataTable candBranch = GetDataTable("Branch");
                Combobox_Branch_Cand_Register.DataSource = candBranch;
                Combobox_Branch_Cand_Register.DisplayMember = "Branch";
                Combobox_Branch_Cand_Register.ValueMember = "Branch";

                DataTable schemeBranch = GetDataTable("Branch");
                Combobox_Branch_SchemeSearch.DataSource = schemeBranch;
                Combobox_Branch_SchemeSearch.DisplayMember = "Branch";
                Combobox_Branch_SchemeSearch.ValueMember = "Branch";

                // Scheme
                DataTable schemeDT = GetDataTable("Scheme");
                Combobox_Scheme.DataSource = schemeDT;
                Combobox_Scheme.DisplayMember = "Scheme";
                Combobox_Scheme.ValueMember = "Scheme";

                Combobox_Semester_ClassSearch.SelectedIndex = 0;
                Combobox_Semester.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Radio_University_CheckedChanged(object sender, EventArgs e)
        {
            Panel_Import_Excel.Enabled = true;
            Panel_University_Search.Enabled = true;
            Panel_Series_Search.Enabled = false;
            TabControl.SelectedTab = Tab_Excel_Import;
            Groupbox_ExtraCandidateRegister.Enabled = true;
            ResetForm();
        }

        private void Radio_Series_CheckedChanged(object sender, EventArgs e)
        {
            Panel_Import_Excel.Enabled = false;
            Panel_University_Search.Enabled = false;
            Panel_Series_Search.Enabled = true;
            TabControl.SelectedTab = Tab_Series_Search;
            Groupbox_ExtraCandidateRegister.Enabled = false;
            ResetForm();
        }

        bool isFormReset = false;
        void ResetForm()
        {
            isFormReset = true;
            HeaderCheckBox.Checked = false;
            Textbox_ExtraCand_Name.ResetText();
            Textbox_ExtraCand_RegNo.ResetText();
            Dgv_Students.DataSource = null;
            if (Radio_University.Checked)
            {
                Textbox_ExcelFilepath.ResetText();
                Combobox_ExcelSheets.SelectedItem = null;
                Button_Register_ExcelSheet.Enabled = false;
                Combobox_Branch_Cand_Register.SelectedIndex = 0;
                Textbox_Yoa_SearchCand.ResetText();
            }
            else Combobox_Semester_ClassSearch.SelectedIndex = 0;
            isFormReset = false;
            SetLoading(false);
        }

        void SetLoading(bool loading)
        {
            if (loading)
            {
                Panel_Body.Enabled = false;
                Panel_ProgressBar.Visible = true;
            }
            else
            {
                Panel_Body.Enabled = true;
                Panel_ProgressBar.Visible = false;
            }
        }

        // Checkbox click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void Dgv_Students_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Students.Columns["CheckBoxColumn_Students"].Index)
                Dgv_Students.EndEdit();
        }

        private void Dgv_Students_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Students.Columns["CheckBoxColumn_Students"].Index)
            {
                if (HeaderCheckBox.Checked)
                {
                    isCheckBoxColumn_ClickedEvent = true;
                    HeaderCheckBox.Checked = false;
                }
            }
        }

        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent && !isFormReset)
            {
                if (HeaderCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in Dgv_Students.Rows)
                    {
                        row.Cells["CheckBoxColumn_Students"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in Dgv_Students.Rows)
                    {
                        row.Cells["CheckBoxColumn_Students"].Value = false;
                    }
                }
            }

            isCheckBoxColumn_ClickedEvent = false;
        }

        void SearchCourses()
        {
            if (!isFormReset)
            {
                string scheme = Combobox_Scheme.Text;
                string branch = Combobox_Branch_SchemeSearch.Text;
                string semester = Combobox_Semester.Text;
                Dgv_Course.DataSource = null;

                string searchRecord = "";

                if (scheme != "-Select-")
                    searchRecord = string.Format("Scheme like '%{0}%'", scheme);
                if (branch != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Branch Like '%{0}%'", branch);
                }
                if (semester != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Semester Like '%{0}%'", semester);
                }
                if (searchRecord != "")
                {
                    string query = "Select * from Timetable where " + searchRecord;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        DataTable courseTable = new DataTable();
                        dataAdapter.Fill(courseTable);
                        Dgv_Course.DataSource = courseTable;
                    }
                }
            }
        }

        private void Combobox_Scheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_Scheme.SelectedIndex != 0) SearchCourses();
        }

        private void Combobox_Branch_SchemeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_Branch_SchemeSearch.SelectedIndex != 0) SearchCourses();
        }

        private void Combobox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_Semester.SelectedIndex != 0) SearchCourses();
        }

        // Register from Excel Sheet event --- Start
        DataTableCollection tableCollection;
        private void Button_Select_ExcelFile_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox(" ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows and    \n exact ordering not required :  \n RegisterNo ,Name, Semester, Branch, Course, ExamCode  ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel Files|*.xls|*xlsx|*.xlsm" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Textbox_ExcelFilepath.Text = openFile.FileName;  //Filepath_textbox.Text --- filepath is displayed in textbox
                    using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            Combobox_ExcelSheets.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                Combobox_ExcelSheets.Items.Add(table.TableName); //add sheets to combobox
                        }
                    }
                }
            }
        }

        private void Combobox_ExcelSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combobox_ExcelSheets.SelectedItem != null)
            {
                DataTable dt = tableCollection[Combobox_ExcelSheets.Text];
                if (dt != null)
                {
                    List<Class_Reg_University_Students_Excel> excst = new List<Class_Reg_University_Students_Excel>(); //<--here ExcelStudents is class name
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class_Reg_University_Students_Excel excclass = new Class_Reg_University_Students_Excel();
                        excclass.Name = dt.Rows[i]["Name"].ToString();  //have to give Excel column names inside the[""]
                        excclass.Reg_No = dt.Rows[i]["RegisterNo"].ToString();
                        excclass.Branch = dt.Rows[i]["Branch"].ToString();
                        excclass.Semester = dt.Rows[i]["Semester"].ToString();
                        excclass.Course = dt.Rows[i]["Course"].ToString();
                        excclass.Sub_Code = dt.Rows[i]["ExamCode"].ToString();

                        excst.Add(excclass);
                    }
                    Dgv_Students.DataSource = excst;
                    Button_Register_University.Enabled = true;
                }
            }
        }

        void Register_University_Students_From_ExcelSheet()
        {
            CustomMessageBox.ShowMessageBox("Are you sure to Register Students from selected excel sheet ?   ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    SetLoading(true);
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        string query = string.Format("Insert into University_Candidates(Name,Reg_No,Branch,Semester,Course,Sub_Code) Select @Name,@Reg_No,@Branch,@Semester,@Course,@Sub_Code where not exists(select Name from University_Candidates where Name=@Name and Reg_No=@Reg_No and Branch=@Branch and Semester=@Semester and Course=@Course and Sub_Code=@Sub_Code) limit 1");
                        SQLiteCommand sqlcomm = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_Students.Rows)
                        {
                            sqlcomm.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                            sqlcomm.ExecuteNonQuery();
                        }
                    }
                    Dgv_Students.DataSource = null;
                    Button_Register_ExcelSheet.Enabled = false;
                    CustomMessageBox.ShowMessageBox("University candidates registered  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    SetLoading(false);
                }
            }
        }

        private void Button_Register_ExcelSheet_Click(object sender, EventArgs e)
        {
            Register_University_Students_From_ExcelSheet();
        }

        void SearchStudentRecord()
        {
            if (!isFormReset)
            {
                Dgv_Students.DataSource = null;
                HeaderCheckBox.Checked = false;
                string branch = Combobox_Branch_Cand_Register.Text;
                string yoa = Textbox_Yoa_SearchCand.Text;

                string searchRecord = "";

                if (branch != "-Select-")
                {
                    searchRecord += string.Format("Branch Like '%{0}%'", branch);
                }
                if (yoa != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("YOA Like '%{0}%'", yoa);
                }
                if (searchRecord != "")
                {
                    string query = "Select * from Students where " + searchRecord;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        DataTable studentRecord = new DataTable();
                        dataAdapter.Fill(studentRecord);
                        Dgv_Students.DataSource = studentRecord;
                    }
                }
                //SetLoading(false);
            }
        }

        private void Combobox_Branch_Cand_Register_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchStudentRecord();
        }

        private void Textbox_Yoa_SearchCand_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchStudentRecord();
        }

        private void Button_Register_University_Click(object sender, EventArgs e)
        {
            try
            {
                SetLoading(true);
                bool isAnySelectionMade = false;
                foreach (DataGridViewRow dr in Dgv_Students.Rows)
                {
                    bool checkboxselected = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Students"].Value);
                    if (checkboxselected && dr.Cells["Reg_No"].Value.ToString() == "")
                    {
                        SetLoading(false);
                        CustomMessageBox.ShowMessageBox("RegisterNo is needed for students to register, Please update RegisterNo  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                        return;
                    }
                }
                string query = string.Format("Insert into University_Candidates(Name,Reg_No,Branch,Semester,Course,Sub_Code) Select @Name,@Reg_No,@Branch,@Semester,@Course,@Sub_Code where not exists(Select Name from University_Candidates where Name=@Name and Reg_No=@Reg_No and Branch=@Branch and Semester=@Semester and Course=@Course and Sub_Code=@Sub_Code) limit 1");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand sqlcomm = new SQLiteCommand(query, dbConnection);
                    //select checkbox from course dgv
                    foreach (DataGridViewRow dr in Dgv_Course.Rows)
                    {
                        bool chkboxselected = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Course"].Value);
                        if (chkboxselected)
                        {
                            //select checkbox from students dgv
                            foreach (DataGridViewRow dr2 in Dgv_Students.Rows)
                            {
                                bool checkbox2selected = Convert.ToBoolean(dr2.Cells["CheckBoxColumn_Students"].Value);
                                if (checkbox2selected)
                                {
                                    isAnySelectionMade = true;
                                    sqlcomm.Parameters.AddWithValue("@Reg_No", dr2.Cells["Reg_No"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Name", dr2.Cells["Name"].Value).ToString();
                                    sqlcomm.Parameters.AddWithValue("@Semester", dr2.Cells["Semester"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Branch", dr2.Cells["Branch"].Value.ToString());
                                    sqlcomm.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }                
                if (isAnySelectionMade)
                {
                    HeaderCheckBox.Checked = false;
                    Dgv_Students.DataSource = null;
                    CustomMessageBox.ShowMessageBox("University candidates registered  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                else
                    CustomMessageBox.ShowMessageBox("Select any Student and Course to register  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SetLoading(false);
            }
        }

        void SearchClassStudentRecord()
        {
            if (!isFormReset)
            {
                Dgv_Students.DataSource = null;
                HeaderCheckBox.Checked = false;
                string studentClass = Combobox_Class.Text;
                if (studentClass != "-Select-" && Combobox_Class.DataSource!=null)
                {
                    string query = string.Format("Select * from Students where Class='{0}' and Semester = {1}", studentClass, Combobox_Semester_ClassSearch.Text);
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        DataTable studentRecord = new DataTable();
                        dataAdapter.Fill(studentRecord);
                        Dgv_Students.DataSource = studentRecord;
                    }
                }
                //SetLoading(false);
            }
        }

        private void Combobox_Semester_ClassSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_Class.DataSource = null;
            if (Combobox_Semester_ClassSearch.SelectedIndex != 0)
            {
                // Class
                DataTable classDT = GetDataTable("Class");
                Combobox_Class.DisplayMember = "Class";
                Combobox_Class.ValueMember = "Class";
                Combobox_Class.DataSource = classDT;
            }            
        }

        private void Combobox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchClassStudentRecord();
        }

        private void Button_Register_Series_Click(object sender, EventArgs e)
        {
            try
            {
                SetLoading(true);
                bool isAnySelectionMade = false;
                
                string query = string.Format("Insert into Series_Candidates(Name,Roll_No,Class,Branch,Semester,Course,Sub_Code) Select @Name,@Roll_No,@Class,@Branch,@Semester,@Course,@Sub_Code Where not exists(Select Name from Series_Candidates where Name=@Name and Roll_No=@Roll_No and Class=@Class and Branch=@Branch and Semester=@Semester and Course=@Course and Sub_Code=@Sub_Code) Limit 1");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand sqlcomm = new SQLiteCommand(query, dbConnection);
                    //select checkbox from course dgv
                    foreach (DataGridViewRow dr in Dgv_Course.Rows)
                    {
                        bool chkboxselected = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Course"].Value);
                        if (chkboxselected)
                        {
                            //select checkbox from students dgv
                            foreach (DataGridViewRow dr2 in Dgv_Students.Rows)
                            {
                                bool checkbox2selected = Convert.ToBoolean(dr2.Cells["CheckBoxColumn_Students"].Value);
                                if (checkbox2selected)
                                {
                                    isAnySelectionMade = true;
                                    sqlcomm.Parameters.AddWithValue("@Roll_No", dr2.Cells["Roll_No"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Name", dr2.Cells["Name"].Value).ToString();
                                    sqlcomm.Parameters.AddWithValue("@Class", dr2.Cells["Class"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Semester", dr2.Cells["Semester"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                                    sqlcomm.Parameters.AddWithValue("@Branch", dr2.Cells["Branch"].Value.ToString());
                                    sqlcomm.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                if (isAnySelectionMade)
                {
                    HeaderCheckBox.Checked = false;
                    Dgv_Students.DataSource = null;
                    CustomMessageBox.ShowMessageBox("Series candidates registered  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                else
                    CustomMessageBox.ShowMessageBox("Select any Student and Course to register  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SetLoading(false);
            }
        }

        private void Button_ExtraCand_Register_Click(object sender, EventArgs e)
        {
            if(Textbox_ExtraCand_RegNo.Text!="" && Textbox_ExtraCand_Name.Text != "")
            {
                try
                {
                    SetLoading(true);
                    bool isAnySelectionMade = false;
                    string query = string.Format("Insert into University_Candidates(Name,Reg_No,Branch,Semester,Course,Sub_Code) Select @Name,@Reg_No,@Branch,@Semester,@Course,@Sub_Code where not exists(Select Name from University_Candidates where Name=@Name and Reg_No=@Reg_No and Branch=@Branch and Semester=@Semester and Course=@Course and Sub_Code=@Sub_Code) limit 1");
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand sqlcomm = new SQLiteCommand(query, dbConnection);
                        //select checkbox from course dgv
                        foreach (DataGridViewRow dr in Dgv_Course.Rows)
                        {
                            bool chkboxselected = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Course"].Value);
                            if (chkboxselected)
                            {
                                isAnySelectionMade = true;
                                sqlcomm.Parameters.AddWithValue("@Reg_No", Textbox_ExtraCand_RegNo.Text);
                                sqlcomm.Parameters.AddWithValue("@Name", Textbox_ExtraCand_Name.Text);
                                sqlcomm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                                sqlcomm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                sqlcomm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                                sqlcomm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                sqlcomm.ExecuteNonQuery();
                            }
                        }
                    }
                    if (isAnySelectionMade)
                    {
                        Textbox_ExtraCand_Name.ResetText();
                        Textbox_ExtraCand_RegNo.ResetText();
                        SetLoading(false);
                        CustomMessageBox.ShowMessageBox("Extra Candidate for University exam registered  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else
                        CustomMessageBox.ShowMessageBox("Select any Course to register  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    SetLoading(false);
                }
            }
            else
                CustomMessageBox.ShowMessageBox("Enter Reg_No and Name to register  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
        }

        // Course Checkbox click event
        bool isCourseCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBoxCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCourseCheckBoxColumn_ClickedEvent && !isFormReset)
            {
                if (HeaderCheckBoxCourse.Checked)
                {
                    foreach (DataGridViewRow row in Dgv_Course.Rows)
                    {
                        row.Cells["CheckBoxColumn_Course"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in Dgv_Course.Rows)
                    {
                        row.Cells["CheckBoxColumn_Course"].Value = false;
                    }
                }
            }
            isCourseCheckBoxColumn_ClickedEvent = false;
        }

        private void Dgv_Course_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Course.Columns["CheckBoxColumn_Course"].Index)
                Dgv_Course.EndEdit();
        }

        private void Dgv_Course_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Course.Columns["CheckBoxColumn_Course"].Index)
            {
                if (HeaderCheckBoxCourse.Checked)
                {
                    isCourseCheckBoxColumn_ClickedEvent = true;
                    HeaderCheckBoxCourse.Checked = false;
                }
            }
        }
    }
}
