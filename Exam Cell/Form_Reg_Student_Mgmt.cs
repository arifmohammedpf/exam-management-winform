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
    public partial class Form_Reg_Student_Mgmt : Form
    {
        public Form_Reg_Student_Mgmt()
        {
            InitializeComponent();
        }

        Form_Message_Box CustomMessageBox = new Form_Message_Box();

        // getting connection string from app.config
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Form_Reg_Student_Mgmt_Load(object sender, EventArgs e)
        {
            Radio_University_Reg.Checked = true;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isReset = false;
        void ResetForm()
        {
            isReset = true;
            Dgv_Students.DataSource = null;
            Textbox_RegNo.ResetText();
            Combobox_Branch.SelectedIndex = 0;
            Combobox_Semester.SelectedIndex = 0;
            HeaderCheckBox.Checked = false;
            isReset = false;
        }
        
        string studentCount;
        void TotalCount(string query, string labelCountText)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                studentCount = comm.ExecuteScalar().ToString();
            }
            Label_Total.Text = labelCountText + studentCount;
        }

        private void Radio_University_Reg_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_University_Reg.Checked)
            {
                Radio_University_Alloted.Checked = false;
                Radio_Series_Alloted.Checked = false;
                ResetForm();
                string query = "Select Count(*) from University_Candidates";
                string labelCountText = "Total Students Registered : ";
                TotalCount(query, labelCountText);
            }
        }

        private void Radio_Series_Reg_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Series_Reg.Checked)
            {
                Radio_University_Alloted.Checked = false;
                Radio_Series_Alloted.Checked = false;
                ResetForm(); string query = "Select Count(*) from Series_Candidates";
                string labelCountText = "Total Students Registered : ";
                TotalCount(query, labelCountText);
            }
        }

        private void Radio_University_Alloted_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_University_Alloted.Checked)
            {
                Radio_University_Reg.Checked = false;
                Radio_Series_Reg.Checked = false;
                ResetForm();
                string query = "Select Count(*) from University_Alloted";
                string labelCountText = "Total Students Alloted : ";
                TotalCount(query, labelCountText);
            }
        }

        private void Radio_Series_Alloted_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Series_Alloted.Checked)
            {
                Radio_University_Reg.Checked = false;
                Radio_Series_Reg.Checked = false;
                ResetForm();
                string query = "Select Count(*) from Series_Alloted";
                string labelCountText = "Total Students Alloted : ";
                TotalCount(query, labelCountText);
            }
        }

        // checkbox click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent || !isReset)
            {
                if(Dgv_Students.DataSource != null)
                {
                    if (HeaderCheckBox.Checked)
                    {
                        foreach (DataGridViewRow row in Dgv_Students.Rows)
                        {
                            row.Cells["CheckBoxColumn"].Value = true;
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in Dgv_Students.Rows)
                        {
                            row.Cells["CheckBoxColumn"].Value = false;
                        }
                    }
                }
            }
        }

        private void Dgv_Students_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Students.Columns["CheckBoxColumn"].Index)
                Dgv_Students.EndEdit();
        }

        private void Dgv_Students_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Students.Columns["CheckBoxColumn"].Index)
            {
                if (HeaderCheckBox.Checked)
                {
                    isCheckBoxColumn_ClickedEvent = true;
                    HeaderCheckBox.Checked = false;
                }
            }
        }

        void SearchStudentRecord()
        {
            if (!isReset)
            {
                Dgv_Students.DataSource = null;
                string regno = Textbox_RegNo.Text;
                string branch = Combobox_Branch.Text;
                string semester = Combobox_Semester.Text;
                HeaderCheckBox.Checked = false;

                string searchRecord = "";
                if (regno != "")
                    searchRecord = string.Format("Reg_No like {0}", regno);
                if (branch != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Branch Like {0}", branch);
                }
                if (semester != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Semester Like {0}", semester);
                }

                string query;
                if (Radio_University_Reg.Checked) query = "Select * from University_Candidates where " + searchRecord;
                else if (Radio_University_Alloted.Checked) query = "Select * from University_Alloted where " + searchRecord;
                else if (Radio_Series_Reg.Checked) query = "Select * from Series_Candidates where " + searchRecord;
                else query = "Select * from Series_Alloted where " + searchRecord;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable studentRecord = new DataTable();
                    dataAdapter.Fill(studentRecord);
                    Dgv_Students.DataSource = studentRecord;
                }
                Label_NoOfStudents.Text = "No of Students : " + Dgv_Students.Rows.Count.ToString();
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Are you sure to Delete the selected students ?  ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    this.Enabled = false;
                    int flag = 0;
                    string query;
                    if (Radio_University_Reg.Checked) query = string.Format("Delete from University_Candidates where Reg_No=@Reg_No and Name=@Name and Branch=@Branch and Course=@Course");
                    else if (Radio_University_Alloted.Checked) query = string.Format("Delete from University_Alloted where Reg_No=@Reg_No and Name=@Name and Branch=@Branch and Course=@Course");
                    else if (Radio_Series_Reg.Checked) query = string.Format("Delete from Series_Candidates where Reg_No=@Reg_No and Name=@Name and Class=@Class and Course=@Course");
                    else query = string.Format("Delete from Series_Alloted where Reg_No=@Reg_No and Name=@Name and Class=@Class and Course=@Course");

                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_Students.Rows)
                        {
                            bool checkboxselect = Convert.ToBoolean(dr.Cells["CheckBoxColumn"].Value);
                            if (checkboxselect)
                            {
                                flag = 1;
                                comm.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value.ToString());
                                comm.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value.ToString());
                                comm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                if (Radio_Series_Reg.Checked || Radio_Series_Alloted.Checked) comm.Parameters.AddWithValue("@Class", dr.Cells["Class"].Value.ToString());
                                else comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                if (Radio_Series_Alloted.Checked || Radio_University_Alloted.Checked)
                                {
                                    comm.Parameters.AddWithValue("@Date", dr.Cells["Date"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Session", dr.Cells["Session"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Room_No", dr.Cells["Room_No"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Seat_No", dr.Cells["Seat_No"].Value.ToString());
                                }
                                comm.ExecuteNonQuery();
                            }
                        }
                        if (flag == 1)
                        {
                            ResetForm();
                            CustomMessageBox.ShowMessageBox("Selected students deleted  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                        }
                        else CustomMessageBox.ShowMessageBox("Select any student to delete  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                        this.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    this.Enabled = true;
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

// TESTING //
// check for error, if we remove if condition for dataSource in dgv for headercheckbox event (line 119)
