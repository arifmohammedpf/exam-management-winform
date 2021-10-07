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

        void SetLoading(bool loading)
        {
            if (loading) Panel_ProgressBar.Visible = true;
            else Panel_ProgressBar.Visible = false;
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
            HeaderCheckBox.Checked = false;
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
                    Combobox_Branch.DataSource = null;

                    string branchQuery = string.Format("Select Branch from Branch_Priority where Branch is not null");
                    SQLiteCommand branchCommand = new SQLiteCommand(branchQuery, dbConnection);
                    SQLiteDataAdapter branchAdapter = new SQLiteDataAdapter(branchCommand);
                    DataTable branchDT = new DataTable();
                    branchAdapter.Fill(branchDT);
                    DataRow branchTop = branchDT.NewRow();
                    branchTop[0] = "-Select-";
                    branchDT.Rows.InsertAt(branchTop, 0);

                    Combobox_Branch.DisplayMember = "Branch";
                    Combobox_Branch.ValueMember = "Branch";
                    Combobox_Branch.DataSource = branchDT;
                }
                Combobox_Semester.SelectedIndex = 0;
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
                SetLoading(true);
                HeaderCheckBox.Checked = false;
                Dgv_Timetable.DataSource = null;
                string searchRecord = "";
                string branch = Combobox_Branch.Text;
                string examcode = Textbox_SubCode.Text;
                string semester = Combobox_Semester.Text;
                string date = DateTimePicker_Date.Text;

                if (Checkbox_Datewise.Checked)
                    searchRecord += string.Format("Date = '{0}'", date);
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
                    searchRecord += string.Format("Semester Like '%{0}%'", semester);
                }
                if (searchRecord != "")
                {
                    string query = "Select * from Timetable where " + searchRecord + " order by Date, Session, Sub_Code";
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        DataTable TimeTable = new DataTable();
                        dataAdapter.Fill(TimeTable);
                        Dgv_Timetable.DataSource = TimeTable;
                    }
                }
                SetLoading(false);
            }
        }

        private void Textbox_SubCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchTimetable();
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

        private void Button_Postpone_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Are you sure to Postpone selected Exams ?  ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    SetLoading(true);
                    int flag = 0;
                    bool isPostponWithSession = false;
                    if (Combobox_NewSession.Text != "-Optional-") isPostponWithSession = true;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand comm;
                        string query = "";
                        if (isPostponWithSession)
                            query = string.Format("Update Timetable set Date=@NewDate,Session=@NewSession where Date=@Date and Session=@Session and Sub_Code=@Subcode and Branch=@Branch");
                        else query = string.Format("Update Timetable set Date=@NewDate where Date=@Date and Session=@Session and Sub_Code=@Subcode and Branch=@Branch");
                        comm = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_Timetable.Rows)
                        {
                            bool checkboxselected = Convert.ToBoolean(dr.Cells["CheckBoxColumn_Timetable"].Value);
                            if (checkboxselected)
                            {
                                flag = 1;                                
                                
                                comm.Parameters.AddWithValue("@NewDate", DateTimePicker_NewDate.Text);
                                if (isPostponWithSession) comm.Parameters.AddWithValue("@NewSession", Combobox_NewSession.Text);
                                comm.Parameters.AddWithValue("@Date", dr.Cells["Date"].Value.ToString());
                                comm.Parameters.AddWithValue("@Session", dr.Cells["Session"].Value.ToString());
                                comm.Parameters.AddWithValue("@Subcode", dr.Cells["Sub_Code"].Value.ToString());
                                comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                comm.ExecuteNonQuery();
                            }
                        }
                    }                        
                    if (flag == 1)
                    {
                        SearchTimetable();
                        CustomMessageBox.ShowMessageBox("Selected exams postponed  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else CustomMessageBox.ShowMessageBox("Select any exam to postpone", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
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

        private void Form_Postponement_Load(object sender, EventArgs e)
        {
            DateTimePicker_Date.Format = DateTimePickerFormat.Custom;
            DateTimePicker_Date.CustomFormat = "dd-MM-yyyy";
            DateTimePicker_Date.Value = DateTime.Now;

            DateTimePicker_NewDate.Format = DateTimePickerFormat.Custom;
            DateTimePicker_NewDate.CustomFormat = "dd-MM-yyyy";
            DateTimePicker_NewDate.Value = DateTime.Now;

            Branch_Combobox_Fill();
            Combobox_NewSession.SelectedIndex = 0;
        }

        // Checkbox click event
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
    }
}

// TESTING //
// * check if DateTimePicker is formated in FormLoad in ALL the Forms....
// * dont know if any error comes when comm.paramter.addValue is given inside loop without comm builder (line 177)...check all the forms...
// // // // FINAL DO // // // //
    // * in Dgv, set auto size rows as displayed cell in ALL the forms