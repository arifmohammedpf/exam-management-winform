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

        void SetLoading(bool loading)
        {
            if (loading) Panel_ProgressBar.Visible = true;
            else Panel_ProgressBar.Visible = false;
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
            HeaderCheckBoxCourse.Checked = false;
            Dgv_Courses.DataSource = null;
            Dgv_Timetable.DataSource = null;
            isFormReset = false;
        }

        DataTable GetDataTable()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                string query = string.Format("Select Branch from Branch_Priority where Branch is not null");
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
                Combobox_Branch_Search_Course.DataSource = null;
                Combobox_Branch_Search_Timetable.DataSource = null;

                DataTable courseBranch = GetDataTable();
                Combobox_Branch_Search_Course.DataSource = courseBranch;
                Combobox_Branch_Search_Course.DisplayMember = "Branch";
                Combobox_Branch_Search_Course.ValueMember = "Branch";

                DataTable timetableBranch = GetDataTable();
                Combobox_Branch_Search_Timetable.DataSource = timetableBranch;
                Combobox_Branch_Search_Timetable.DisplayMember = "Branch";
                Combobox_Branch_Search_Timetable.ValueMember = "Branch";

                Combobox_Semester.SelectedIndex = 0;
                Combobox_Session.SelectedIndex = 0;
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

            ComboboxesFill();
        }

        void SearchCourses()
        {
            try
            {
                if (!isFormReset)
                {
                    string branch = Combobox_Branch_Search_Course.Text;
                    string examcode = Textbox_ExamCode_Search_Course.Text;
                    string semester = Combobox_Semester.Text;
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

        private void Textbox_ExamCode_Search_Course_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchCourses();
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
                        searchRecord += string.Format("Date like '%{0}%'", date);
                    }
                    else
                    {
                        string branch = Combobox_Branch_Search_Timetable.Text;
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

        private void Textbox_ExamCode_Search_Timetable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchTimetable();
        }

        // List to backup undo action
        List<string> DateList = new List<string>();
        List<string> SessionList = new List<string>();
        List<string> SchemeList = new List<string>();
        List<string> SubCodeList = new List<string>();
        List<string> SubNameList = new List<string>();
        List<string> SemesterList = new List<string>();
        List<string> BranchList = new List<string>();

        void ClearBackupList()
        {
            DateList.Clear();
            SessionList.Clear();
            SchemeList.Clear();
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
                SetLoading(true);
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
                            string query = string.Format("Insert into Timetable(Date,Session,Scheme,Sub_Code,Course,Semester,Branch) Select @Date,@Session,@Scheme,@Sub_Code,@Course,@Semester,@Branch where not exists(select Course from Timetable where Date=@Date and Session=@Session and Scheme=@Scheme and Sub_Code=@Sub_Code and Course=@Course and Semester=@Semester and Branch=@Branch) limit 1");
                            SQLiteCommand comm = new SQLiteCommand(query,dbConnection);
                            comm.Parameters.AddWithValue("@Date", DateTimePicker_Add_Timetable.Text);
                            comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                            comm.Parameters.AddWithValue("@Scheme", dr.Cells["Scheme"].Value.ToString());
                            comm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                            comm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                            comm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                            comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                            comm.ExecuteNonQuery();

                            // backup for undo
                            DateList.Add(DateTimePicker_Add_Timetable.Text);
                            SessionList.Add(Combobox_Session.Text);
                            SchemeList.Add(dr.Cells["Scheme"].Value.ToString());
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
                    Button_Undo.Enabled = true;
                    SearchTimetable();
                    CustomMessageBox.ShowMessageBox("New Timetable added  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                else CustomMessageBox.ShowMessageBox("Select any Course to Add timetable", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);                
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

        private void Button_Undo_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Are you sure to undo the last action ?  ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    SetLoading(true);
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        string query = string.Format("Delete from Timetable where Date=@Date and Scheme=@Scheme and Session=@Session and Course=@Course and Sub_Code=@Sub_Code and Semester=@Semester and Branch=@Branch");
                        SQLiteCommand comm = new SQLiteCommand(query,dbConnection);
                        for (int i = 0; i < DateList.Count; i++)
                        {
                            comm.Parameters.AddWithValue("@Date", DateList[i]);
                            comm.Parameters.AddWithValue("@Session", SessionList[i]);
                            comm.Parameters.AddWithValue("@Scheme", SchemeList[i]);
                            comm.Parameters.AddWithValue("@Sub_Code", SubCodeList[i]);
                            comm.Parameters.AddWithValue("@Course", SubNameList[i]);
                            comm.Parameters.AddWithValue("@Semester", SemesterList[i]);
                            comm.Parameters.AddWithValue("@Branch", BranchList[i]);
                            comm.ExecuteScalar();
                        }
                    }
                    ClearBackupList();
                    SearchTimetable();                    
                    CustomMessageBox.ShowMessageBox("Last action has been undone  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
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
                    SetLoading(true);
                    int flag = 0;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        string query = string.Format("Delete from Timetable where Date=@Date and Session=@Session and Course=@Course and Sub_Code=@Sub_Code and Semester=@Semester and Branch=@Branch");
                        SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                        foreach(DataGridViewRow dr in Dgv_Timetable.Rows)
                        {
                            bool checkboxselect = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Timetable"].Value);
                            if (checkboxselect)
                            {
                                flag = 1;
                                comm.Parameters.AddWithValue("@Date", dr.Cells["Date"].Value.ToString());
                                comm.Parameters.AddWithValue("@Session", dr.Cells["Session"].Value.ToString());
                                comm.Parameters.AddWithValue("@Sub_Code", dr.Cells["Sub_Code"].Value.ToString());
                                comm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                comm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                                comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                comm.ExecuteScalar();
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

        // checkbox click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent && !isFormReset)
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
            isCheckBoxColumn_ClickedEvent = false;
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

        // course checkbox click event
        bool isCourseCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBoxCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCourseCheckBoxColumn_ClickedEvent && !isFormReset)
            {
                if (HeaderCheckBoxCourse.Checked)
                {
                    foreach (DataGridViewRow row in Dgv_Courses.Rows)
                    {
                        row.Cells["CheckBoxColumn_Course"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in Dgv_Courses.Rows)
                    {
                        row.Cells["CheckBoxColumn_Course"].Value = false;
                    }
                }
            }
            isCourseCheckBoxColumn_ClickedEvent = false;
        }

        private void Dgv_Courses_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Courses.Columns["CheckBoxColumn_Course"].Index)
                Dgv_Courses.EndEdit();
        }

        private void Dgv_Courses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Courses.Columns["CheckBoxColumn_Course"].Index)
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
// TESTING //
// * headercheckbox is set to false in searchCourses after dgv set to null...check if it gives error....put it in tryCatch
// * if ExamCode searching makes any error try to disable textbox before calling SearchFunction()
// * in undo, do we have to include comm=new sqlCommand(..) inside forloop ? check if undoing works properly
// * line 276, this.enabled should be before or after ifElse ?? check if works properly
// * clear inputs is lagging the app ??            
// * chek if isresetform=true works by adding msg box inside search and click reset button to trigger event