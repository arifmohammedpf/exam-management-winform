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

        void SetLoading(bool loading)
        {
            if (loading) Panel_ProgressBar.Visible = true;
            else Panel_ProgressBar.Visible = false;
        }

        bool isReset = false;
        //void ResetForm()
        //{
        //    isReset = true;
        //    Dgv_Students.DataSource = null;
        //    Textbox_RegNo.ResetText();
        //    if (Radio_University_Alloted.Checked || Radio_University_Reg.Checked) Combobox_Branch.SelectedIndex = 0;
        //    Combobox_Semester.SelectedIndex = 0;
        //    HeaderCheckBox.Checked = false;
        //    isReset = false;
        //}
        
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

        DataTable GetComboboxData(string query)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
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

        void ComboboxFill()
        {
            try
            {
                Combobox_Branch.DataSource = null;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();                                       
                    if(Radio_University_Alloted.Checked || Radio_University_Reg.Checked)
                    {
                        string query = string.Format("Select Branch from Branch_Priority where Branch is not null");
                        DataTable dataTableBranch = GetComboboxData(query);
                        Label_BranchClassSearch.Text = "Branch :";
                        Combobox_Branch.DisplayMember = "Branch";
                        Combobox_Branch.ValueMember = "Branch";
                        Combobox_Branch.DataSource = dataTableBranch;
                    }
                    else
                    {
                        Label_BranchClassSearch.Text = "Class :";
                    }                    
                    Combobox_Semester.SelectedIndex = 0;
                }                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Radio_University_Reg_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_University_Reg.Checked)
            {
                Radio_University_Alloted.Checked = false;
                Radio_Series_Alloted.Checked = false;
                ComboboxFill();
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
                ComboboxFill();
                string query = "Select Count(*) from Series_Candidates";
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
                ComboboxFill();
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
                ComboboxFill();
                string query = "Select Count(*) from Series_Alloted";
                string labelCountText = "Total Students Alloted : ";
                TotalCount(query, labelCountText);
            }
        }

        // checkbox click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent && !isReset)
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
            isCheckBoxColumn_ClickedEvent = false;
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
                SetLoading(true);
                Dgv_Students.DataSource = null;
                string regno = Textbox_RegNo.Text;
                string branch_class = Combobox_Branch.Text;
                string semester = Combobox_Semester.Text;
                string examcode = Textbox_ExamCode.Text;
                HeaderCheckBox.Checked = false;

                string searchRecord = "";
                if (regno != "")
                    searchRecord = string.Format("Reg_No like '%{0}%'", regno);
                if (examcode != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Sub_Code Like '%{0}%'", examcode);
                }
                if ((Radio_University_Alloted.Checked || Radio_University_Reg.Checked) && semester != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Semester Like '%{0}%'", semester);
                }
                if (Combobox_Branch.DataSource != null && branch_class != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    if(Radio_University_Alloted.Checked || Radio_University_Reg.Checked) searchRecord += string.Format("Branch Like '%{0}%'", branch_class);
                    else searchRecord += string.Format("Semester Like '%{0}%' and Class = '{1}'",semester, branch_class);
                }                

                string query;
                if (Radio_University_Reg.Checked) query = "Select * from University_Candidates where " + searchRecord + " order by Semester,Branch,Sub_Code";
                else if (Radio_University_Alloted.Checked) query = "Select * from University_Alloted where " + searchRecord + " order by Date,Session,Room_No,length(Seat),Seat";
                else if (Radio_Series_Reg.Checked) query = "Select * from Series_Candidates where " + searchRecord + " order by Semester,Class,Sub_Code";
                else query = "Select * from Series_Alloted where " + searchRecord + " order by Date,Session,Room_No,length(Seat),Seat";
                if(searchRecord != "")
                {
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
                SetLoading(false);
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
                    SetLoading(true);
                    int flag = 0;
                    string query;
                    if (Radio_University_Reg.Checked) query = string.Format("Delete from University_Candidates where Reg_No=@Reg_No and Name=@Name and Branch=@Branch and Course=@Course");
                    else if (Radio_University_Alloted.Checked) query = string.Format("Delete from University_Alloted where Reg_No=@Reg_No and Name=@Name and Branch=@Branch and Course=@Course and Date=@Date and Session=@Session and Room_No=@Room_No and Seat=@Seat");
                    else if (Radio_Series_Reg.Checked) query = string.Format("Delete from Series_Candidates where Roll_No=@Roll_No and Name=@Name and Class=@Class and Course=@Course");
                    else query = string.Format("Delete from Series_Alloted where Roll_No=@Roll_No and Name=@Name and Class=@Class and Course=@Course and Date=@Date and Session=@Session and Room_No=@Room_No and Seat=@Seat");

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
                                comm.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value.ToString());
                                comm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                                if (Radio_Series_Reg.Checked || Radio_Series_Alloted.Checked)
                                {
                                    comm.Parameters.AddWithValue("@Roll_No", dr.Cells["Roll_No"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Class", dr.Cells["Class"].Value.ToString());
                                }
                                else
                                {
                                    comm.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                                }
                                if (Radio_Series_Alloted.Checked || Radio_University_Alloted.Checked)
                                {
                                    comm.Parameters.AddWithValue("@Date", dr.Cells["Date"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Session", dr.Cells["Session"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Room_No", dr.Cells["Room_No"].Value.ToString());
                                    comm.Parameters.AddWithValue("@Seat", dr.Cells["Seat"].Value.ToString());
                                }
                                comm.ExecuteScalar();
                            }
                        }
                        if (flag == 1)
                        {
                            Dgv_Students.DataSource = null;
                            HeaderCheckBox.Checked = false;
                            SearchStudentRecord();
                            if (Radio_Series_Alloted.Checked)
                            {                                
                                string countQuery = "Select Count(*) from Series_Alloted";
                                string labelCountText = "Total Students Alloted : ";
                                TotalCount(countQuery, labelCountText);
                            }
                            else if (Radio_University_Alloted.Checked)
                            {
                                string countQuery = "Select Count(*) from University_Alloted";
                                string labelCountText = "Total Students Alloted : ";
                                TotalCount(countQuery, labelCountText);
                            }
                            else if (Radio_Series_Reg.Checked)
                            {
                                string countQuery = "Select Count(*) from Series_Candidates";
                                string labelCountText = "Total Students Registered : ";
                                TotalCount(countQuery, labelCountText);
                            }
                            else
                            {
                                string countQuery = "Select Count(*) from University_Candidates";
                                string labelCountText = "Total Students Registered : ";
                                TotalCount(countQuery, labelCountText);
                            }
                            CustomMessageBox.ShowMessageBox("Selected students deleted  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                        }
                        else CustomMessageBox.ShowMessageBox("Select any student to delete  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);                        
                    }
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

        private void Textbox_RegNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchStudentRecord();
        }

        private void Combobox_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchStudentRecord();
        }

        private void Combobox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Radio_Series_Alloted.Checked || Radio_Series_Reg.Checked)
            {
                if (Combobox_Semester.SelectedIndex != 0)
                {
                    string query = string.Format("Select Distinct Class from Students where Semester={0} and Class is not null",Combobox_Semester.Text);
                    DataTable dataTableClass = GetComboboxData(query);
                    Combobox_Branch.DisplayMember = "Class";
                    Combobox_Branch.ValueMember = "Class";
                    Combobox_Branch.DataSource = dataTableClass;
                }
                else Combobox_Branch.DataSource = null;
            }
            SearchStudentRecord();
        }
    }
}

// TESTING //
// check for error, if we remove if condition for dataSource in dgv for headercheckbox event (line 162)
