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
    public partial class Form_Postponement : Form
    {
        public Form_Postponement()
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

        bool isFormReset = false; // to avoid searchEvent when resetting form triggers event actions
        void ResetForm()
        {
            isFormReset = true;
            Combobox_Branch.SelectedIndex = 0;
            Combobox_Semester.SelectedIndex = 0;
            Combobox_NewSession.SelectedIndex = 0;
            Textbox_SubCode.ResetText();
            DateTimePicker_Date.Value = DateTime.Now;
            DateTimePicker_NewDate.Value = DateTime.Now;
            Dgv_Timetable.DataSource = null;
            isFormReset = false;
        }

        void Branch_Combobox_Fill()
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    Combobox_Branch.DataSource = null;

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
                }
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void SearchTimetable()
        {
            if (!isFormReset)
            {
                Dgv_Timetable.DataSource = null;
                string searchRecord = "";
                string branch = Combobox_Branch.SelectedItem.ToString();
                string examcode = Textbox_SubCode.Text;
                string semester = Combobox_Semester.SelectedItem.ToString();
                string date = DateTimePicker_Date.Text;

                if (Checkbox_Datewise.Checked)
                    searchRecord += string.Format("Date = '%{0}%'", date);
                if (branch != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord = string.Format("Branch like '%{0}%'", branch);
                }
                if (examcode != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Sub_Code Like '%{0}%'", examcode);
                }
                if (semester != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Semester Like '%{0}%'", examcode);
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
        }

        private void Textbox_SubCode_TextChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        private void Combobox_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        private void Combobox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        private void DateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {
            SearchTimetable();
        }

        private void Checkbox_Datewise_CheckedChanged(object sender, EventArgs e)
        {
            SearchTimetable();
            if (Checkbox_Datewise.Checked) DateTimePicker_Date.Enabled = true;
            else DateTimePicker_Date.Enabled = false;
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}

// TESTING //
// *

/*
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
*/