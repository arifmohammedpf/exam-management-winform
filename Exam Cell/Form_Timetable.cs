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

        void ResetForm()
        {
            Combobox_Branch_Search_Course.SelectedIndex = 0;
            Combobox_Branch_Search_Timetable.SelectedIndex = 0;
            Combobox_Semester.SelectedIndex = 0;
            Combobox_Session.SelectedIndex = 0;
            Textbox_ExamCode_Search_Course.ResetText();
            Textbox_ExamCode_Search_Timetable.ResetText();
        }

        void Branch_Combobox_Fill()
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
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
            string branch = Combobox_Branch_Search_Course.SelectedItem.ToString();
            string examcode = Textbox_ExamCode_Search_Course.Text;
            string semester = Combobox_Semester.SelectedItem.ToString();
            Dgv_Courses.DataSource = null;

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
                searchRecord += string.Format("Exam_Code Like '%{0}%'", examcode);
            }

            if (searchRecord != "")
            {
                string query = "Select * from Scheme where " + searchRecord;
                DataTable courseTable;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    courseTable = new DataTable();
                    dataAdapter.Fill(courseTable);
                }
                Dgv_Courses.DataSource = courseTable;
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
                    searchRecord += string.Format("Exam_Code Like '%{0}%'", examcode);
                }
            }

            if (searchRecord != "")
            {
                string query = "Select * from Timetable where " + searchRecord;
                DataTable TimeTable;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    TimeTable = new DataTable();
                    dataAdapter.Fill(TimeTable);
                }
                Dgv_Timetable.DataSource = TimeTable;
            }
        }

        private void Radio_DateWiseSearch_CheckedChanged(object sender, EventArgs e)
        {
            DateTimePicker_Search_Timetable.Enabled = true;
            Combobox_Branch_Search_Timetable.Enabled = false;
            Textbox_ExamCode_Search_Timetable.Enabled = false;
        }

        private void Radio_BranchWiseSearch_CheckedChanged(object sender, EventArgs e)
        {
            Combobox_Branch_Search_Timetable.Enabled = true;
            Textbox_ExamCode_Search_Timetable.Enabled = true;
            DateTimePicker_Search_Timetable.Enabled = false;
        }
    }
}

// TESTING //
// * if ExamCode searching makes any error try to disable textbox before calling SearchFunction()