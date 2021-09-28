using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Cell
{
    public partial class Form_Timetable : Form
    {
        public Form_Timetable()
        {
            InitializeComponent();
        }

        Form_Message_Box CustomMessageBox = new Form_Message_Box();

        // getting connection string from app.config
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isFormReset = false;
        void ResetForm()
        {
            isFormReset = true;
            Combobox_Branch_Search_Course.SelectedIndex = 0;
            Combobox_Branch_Search_Timetable.SelectedIndex = 0;
            Combobox_Semester.SelectedIndex = 0;
            Combobox_Session.SelectedIndex = 0;
            Textbox_ExamCode_Search_Course.ResetText();
            Textbox_ExamCode_Search_Timetable.ResetText();
            DateTimePicker_Search_Timetable.Value = DateTime.Now;
            DateTimePicker_Add_Timetable.Value = DateTime.Now;
            HeaderCheckBox.Checked = false;
            Dgv_Courses.DataSource = null;
            Dgv_Timetable.DataSource = null;
            isFormReset = false;
        }

        void Branch_Combobox_Fill()
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    Combobox_Branch_Search_Course.DataSource = null;
                    Combobox_Branch_Search_Timetable.DataSource = null;

                    string branchQuery = string.Format("Select Branch from Branch_Priority where Branch is not null");
                    SQLiteCommand branchCommand = new SQLiteCommand(branchQuery, dbConnection);
                    SQLiteDataAdapter branchAdapter = new SQLiteDataAdapter(branchCommand);
                    DataTable branchDT = new DataTable();
                    branchAdapter.Fill(branchDT);
                    DataRow branchTop = branchDT.NewRow();
                    branchTop[0] = "-Select-";
                    branchDT.Rows.InsertAt(branchTop, 0);

                    Combobox_Branch_Search_Course.DataSource = branchDT;
                    Combobox_Branch_Search_Course.DisplayMember = "Branch";
                    Combobox_Branch_Search_Course.ValueMember = "Branch";

                    Combobox_Branch_Search_Timetable.DataSource = branchDT;
                    Combobox_Branch_Search_Timetable.DisplayMember = "Branch";
                    Combobox_Branch_Search_Timetable.ValueMember = "Branch";                    
                }
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form_Timetable_Load(object sender, EventArgs e)
        {
            DateTimePicker_Add_Timetable.Format = DateTimePickerFormat.Custom;
            DateTimePicker_Add_Timetable.CustomFormat = "dd-MM-yyyy";
            DateTimePicker_Add_Timetable.Value = DateTime.Now;

            DateTimePicker_Search_Timetable.Format = DateTimePickerFormat.Custom;
            DateTimePicker_Search_Timetable.CustomFormat = "dd-MM-yyyy";
            DateTimePicker_Search_Timetable.Value = DateTime.Now;

            Branch_Combobox_Fill();
        }

        void SearchCourses()
        {
            try
            {
                if (!isFormReset)
                {
                    string branch = Combobox_Branch_Search_Course.SelectedItem.ToString();
                    string examcode = Textbox_ExamCode_Search_Course.Text;
                    string semester = Combobox_Semester.SelectedItem.ToString();
                    Dgv_Courses.DataSource = null;
                    HeaderCheckBox.Checked = false;

                    string searchRecord = "";

                    if (branch != "-Select-")
                        searchRecord = string.Format("Branch like '%{0}%'", branch);
                    if (semester != "-Select-")
                    {
                        if (searchRecord.Length > 0) searchRecord += " AND ";
                        searchRecord += string.Format("Semester Like '%{0}%'", semester);
                    }
                    if (examcode != "")
                    {
                        if (searchRecord.Length > 0) searchRecord += " AND ";
                        searchRecord += string.Format("Sub_Code Like '%{0}%'", examcode);
                    }
                    if (searchRecord != "")
                    {
                        string query = "Select * from Scheme where " + searchRecord;
                        DataTable courseTable;
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            dbConnection.Open();
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                            courseTable = new DataTable();
                            dataAdapter.Fill(courseTable);
                        }
                        Dgv_Courses.DataSource = courseTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Combobox_Branch_Search_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCourses();
        }

        private void Combobox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCourses();
        }

        private void Textbox_ExamCode_Search_Course_TextChanged(object sender, EventArgs e)
        {
            SearchCourses();
        }

        void SearchTimetable()
        {
            try
            {
                if (!isFormReset)
                {
                    Dgv_Timetable.DataSource = null;
                    string searchRecord = "";

                    if (Radio_DateWiseSearch.Checked)
                    {
                        string date = DateTimePicker_Search_Timetable.Text;
                        searchRecord += string.Format("Date = '%{0}%'", date);
                    }
                    else
                    {
                        string branch = Combobox_Branch_Search_Timetable.SelectedItem.ToString();
                        string examcode = Textbox_ExamCode_Search_Timetable.Text;
                        if (branch != "-Select-")
                            searchRecord = string.Format("Branch like '%{0}%'", branch);
                        if (examcode != "")
                        {
                            if (searchRecord.Length > 0) searchRecord += " AND ";
                            searchRecord += string.Format("Sub_Code Like '%{0}%'", examcode);
                        }
                    }

                    if (searchRecord != "")
                    {
                        string query = "Select * from Timetable where " + searchRecord;
                        DataTable TimeTable;
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            dbConnection.Open();
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                            TimeTable = new DataTable();
                            dataAdapter.Fill(TimeTable);
                        }
                        Dgv_Timetable.DataSource = TimeTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Radio_DateWiseSearch_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePicker_Search_Timetable.Enabled = true;
            Combobox_Branch_Search_Timetable.Enabled = false;
            Textbox_ExamCode_Search_Timetable.Enabled = false;
            SearchTimetable();
        }

        private void Radio_BranchWiseSearch_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Branch_Search_Timetable.Enabled = true;
            Textbox_ExamCode_Search_Timetable.Enabled = true;
            DateTimePicker_Search_Timetable.Enabled = false;
            SearchTimetable();
        }

        private void DateTimePicker_Search_Timetable_ValueChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        private void Combobox_Branch_Search_Timetable_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        private void Textbox_ExamCode_Search_Timetable_TextChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        // List to backup undo action
        List<string> DateList = new List<string>();
        List<string> SessionList = new List<string>();
        List<string> SubCodeList = new List<string>();
        List<string> SubNameList = new List<string>();
        List<string> SemesterList = new List<string>();
        List<string> BranchList = new List<string>();

        void ClearBackupList()
        {
            DateList.Clear();
            SessionList.Clear();
            SubCodeList.Clear();
            SubNameList.Clear();
            SessionList.Clear();
            BranchList.Clear();
            Button_Undo.Enabled = false;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                this.Enabled = false;
                int flag = 0;
                ClearBackupList();
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    foreach (DataGridViewRow dr in Dgv_Courses.Rows)
                    {
                        bool checkboxselect = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Course"].Value);
                        if (checkboxselect)
                        {
                            flag = 1;
                            string query = string.Format("Insert into Timetable(Date,Session,Sub_Code,Course,Semester,Branch)Values(" + "@Date,@Session,@Sub_Code,@Course,@Semester,@Branch)");
                            SQLiteCommand comm = new SQLiteCommand(query,dbConnection);
                            comm.Parameters.AddWithValue("@Date", DateTimePicker_Add_Timetable.Text);
                            comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                            comm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                            comm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                            comm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                            comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                            comm.ExecuteNonQuery();

                            // backup for undo
                            DateList.Add(DateTimePicker_Add_Timetable.Text);
                            SessionList.Add(Combobox_Session.SelectedItem.ToString());
                            SubCodeList.Add(dr.Cells["Sub_Code"].Value.ToString());
                            SubNameList.Add(dr.Cells["Course"].Value.ToString());
                            SemesterList.Add(dr.Cells["Semester"].Value.ToString());
                            BranchList.Add(dr.Cells["Branch"].Value.ToString());

                            // uncheck dgv checkbox
                            dr.Cells["CheckBoxColumn_Course"].Value = false;
                        }
                    }
                }
                if (flag == 1)
                {
                    CustomMessageBox.ShowMessageBox("New Timetable added  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    Button_Undo.Enabled = true;
                    SearchTimetable();
                }
                else CustomMessageBox.ShowMessageBox("Select any Course to Add timetable", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                this.Enabled = true;
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Undo_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Are you sure to undo the last action ?  ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    this.Enabled = false;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        string query = string.Format("Delete from Timetable where Date=@Date and Session=@Session and Course=@Course and Sub_Code=@Sub_Code and Semester=@Semester and Branch=@Branch");
                        SQLiteCommand comm = new SQLiteCommand(query,dbConnection);
                        for (int i = 0; i < DateList.Count; i++)
                        {
                            comm.Parameters.AddWithValue("@Date", DateList[i]);
                            comm.Parameters.AddWithValue("@Session", SessionList[i]);
                            comm.Parameters.AddWithValue("@Sub_Code", SubCodeList[i]);
                            comm.Parameters.AddWithValue("@Course", SubNameList[i]);
                            comm.Parameters.AddWithValue("@Semester", SemesterList[i]);
                            comm.Parameters.AddWithValue("@Branch", BranchList[i]);
                            comm.ExecuteNonQuery();
                        }
                    }
                    ClearBackupList();
                    SearchTimetable();
                    this.Enabled = true;
                    CustomMessageBox.ShowMessageBox("Last action has been undone  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    this.Enabled = true;
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Are you sure to Delete the selected timetable ?  ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    this.Enabled = false;
                    int flag = 0;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        string query = string.Format("Delete from Timetable where Date=@Date and Session=@Session and Course=@Course and Sub_Code=@Sub_Code and Semester=@Semester and Branch=@Branch");
                        SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                        foreach(DataGridViewRow dr in Dgv_Timetable.Rows)
                        {
                            bool checkboxselect = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Course"].Value);
                            if (checkboxselect)
                            {
                                flag = 1;
                                comm.Parameters.AddWithValue("@Date", dr.Cells["Date"].Value.ToString());
                                comm.Parameters.AddWithValue("@Session", dr.Cells["Session"].Value.ToString());
                                comm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                                comm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                comm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                                comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                comm.ExecuteNonQuery();
                            }                                
                        }
                    }
                    if (flag == 1)
                    {
                        ClearBackupList();
                        SearchTimetable();
                        CustomMessageBox.ShowMessageBox("Selected records deleted  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else CustomMessageBox.ShowMessageBox("Select any timetable to delete  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                    this.Enabled = true;
                }
                catch (Exception ex)
                {
                    this.Enabled = true;
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        // checkbox click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent || !isFormReset)
            {
                if (HeaderCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in Dgv_Timetable.Rows)
                    {
                        row.Cells["CheckBoxColumn_Timetable"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in Dgv_Timetable.Rows)
                    {
                        row.Cells["CheckBoxColumn_Timetable"].Value = false;
                    }
                }
            }
        }

        private void Dgv_Timetable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Timetable.Columns["CheckBoxColumn_Timetable"].Index)
                Dgv_Timetable.EndEdit();
        }

        private void Dgv_Timetable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Timetable.Columns["CheckBoxColumn_Timetable"].Index)
            {
                if (HeaderCheckBox.Checked)
                {
                    isCheckBoxColumn_ClickedEvent = true;
                    HeaderCheckBox.Checked = false;
                }
            }
        }
    }
}
// TESTING //
// * headercheckbox is set to false in searchCourses after dgv set to null...check if it gives error....put it in tryCatch
// * if ExamCode searching makes any error try to disable textbox before calling SearchFunction()
// * in undo, do we have to include comm=new sqlCommand(..) inside forloop ? check if undoing works properly
// * line 276, this.enabled should be before or after ifElse ?? check if works properly
// * clear inputs is lagging the app ??            
// * chek if isresetform=true works by adding msg box inside search and click reset button to trigger event