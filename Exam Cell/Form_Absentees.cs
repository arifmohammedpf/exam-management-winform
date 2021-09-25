﻿using System;
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
    public partial class Form_Absentees : Form
    {
        public Form_Absentees()
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

        private void Form_Absentees_Load(object sender, EventArgs e)
        {
            Radio_University.Checked = true;
        }

        DataTable GetComboboxDataSourceQuery(string query,bool isRoom)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                if (isRoom)
                {
                    comm.Parameters.AddWithValue("@Date", Combobox_Marking_Date.SelectedItem.ToString());
                    comm.Parameters.AddWithValue("@Session", Combobox_Marking_Session.SelectedItem.ToString());
                }
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow top = table.NewRow();
                top[0] = "-Select-";
                table.Rows.InsertAt(top, 0);
                return table;
            }
        }

        void FillDateCombobox(string query)
        {
            try
            {
                DataTable table = GetComboboxDataSourceQuery(query,false);
                Combobox_Marking_Date.DisplayMember = "Date";
                Combobox_Marking_Date.ValueMember = "Date";
                Combobox_Marking_Date.DataSource = table;
                Combobox_Marking_Date.SelectedIndex = 0;
                Combobox_Marking_Session.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Radio_University_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_University.Checked)
            {
                Dgv_Marking.DataSource = null;
                FillDateCombobox("Select distinct Date from University_Alloted order by Date");
            }
        }

        private void Radio_Series_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Series.Checked)
            {
                Dgv_Marking.DataSource = null;
                FillDateCombobox("Select distinct Date from Series_Alloted order by Date");
            }
        }

        void FillRoomNoCombobox(string query)
        {
            try
            {
                bool isRoom = true;
                DataTable table = GetComboboxDataSourceQuery(query, isRoom);
                Combobox_Marking_RoomNo.DisplayMember = "Room_No";
                Combobox_Marking_RoomNo.ValueMember = "Room_No";
                Combobox_Marking_RoomNo.DataSource = table;
                Combobox_Marking_RoomNo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Combobox_Marking_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_Marking_RoomNo.DataSource = null;
            if (Combobox_Marking_Date.SelectedIndex!=0 && Combobox_Marking_Session.SelectedIndex != 0)
            {
                string query;
                if (Radio_University.Checked) query = string.Format("Select distinct Room_No from University_Alloted where Date=@Date and Session=@Session order by Room_No");
                else query = string.Format("Select distinct Room_No from Series_Alloted where Date=@Date and Session=@Session order by Room_No");
                FillRoomNoCombobox(query);
            }
        }

        private void Combobox_Marking_Session_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_Marking_RoomNo.DataSource = null;
            if (Combobox_Marking_Date.SelectedIndex != 0 && Combobox_Marking_Session.SelectedIndex != 0)
            {
                string query;
                if (Radio_University.Checked) query = string.Format("Select distinct Room_No from University_Alloted where Date=@Date and Session=@Session order by Room_No");
                else query = string.Format("Select distinct Room_No from Series_Alloted where Date=@Date and Session=@Session order by Room_No");
                FillRoomNoCombobox(query);
            }
        }

        private void Button_Marking_Search_Click(object sender, EventArgs e)
        {
            if(Combobox_Marking_Date.SelectedIndex!=0 && Combobox_Marking_Session.SelectedIndex!=0 && Combobox_Marking_RoomNo.SelectedIndex != 0)
            {
                try
                {
                    string query = "";
                    if (Radio_Series.Checked) query = string.Format("select Seat,Reg_No,Status,Name,Class,Course,Sub_Code,Date,Session,Room_No from Series_Alloted Where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                    else query = string.Format("select Seat,Reg_No,Status,Name,Branch,Sub_Code,Course,Date,Session,Room_No from University_Alloted Where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        command.Parameters.AddWithValue("@Date", Combobox_Marking_Date.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Session", Combobox_Marking_Session.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Room_No", Combobox_Marking_RoomNo.SelectedItem.ToString());
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        Dgv_Marking.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else CustomMessageBox.ShowMessageBox("Select Date, Session and Room No  ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
        }

        private void ChangeStudentStatus(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv)
            {
                DataGridViewCell cell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value is string value && value == "Present")
                {
                    cell.Value = "Absent";
                    cell.Style.ForeColor = Color.Red;
                }
                else if (cell.Value is string value2 && value2 == "Absent")
                {
                    cell.Value = "Present";
                    cell.Style.ForeColor = Color.Black;
                }
            }
        }

        private void Button_Marking_Save_Click(object sender, EventArgs e)
        {
            if (Dgv_Marking.Rows.Count != 0)
            {
                try
                {
                    string query = "";
                    if (Radio_Series.Checked) query = string.Format("update Series_Alloted Set Status=@Status where Reg_No=@Reg_No and Name=@Name and Date=@Date and Session=@Session and Room_No=@Room_No");
                    else query = string.Format("update University_Alloted Set Status=@Status where Reg_No=@Reg_No and Name=@Name and Date=@Date and Session=@Session and Room_No=@Room_No");
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow row in Dgv_Marking.Rows)
                        {
                            comm.Parameters.AddWithValue("@Reg_No", row.Cells["Reg_No"].Value);
                            comm.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                            comm.Parameters.AddWithValue("@Status", row.Cells["Status"].Value);
                            comm.Parameters.AddWithValue("@Date", row.Cells["Date"].Value);
                            comm.Parameters.AddWithValue("@Session", row.Cells["Session"].Value);
                            comm.Parameters.AddWithValue("@Room_No", row.Cells["Room_No"].Value);
                            comm.ExecuteNonQuery();
                        }
                    }
                    CustomMessageBox.ShowMessageBox("Status saved  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        DataTable GetQueryTableData(string query)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow top = table.NewRow();
                top[0] = "-Select-";
                table.Rows.InsertAt(top, 0);
                return table;
            }                
        }

        void DateComboboxFillForSatetment()
        {
            try
            {
                string query;
                if (Radio_University.Checked) query = string.Format("Select Distinct Date from University_Alloted order by Date");
                else query = string.Format("Select Distinct Date from Series_Alloted order by Date");
                DataTable table = GetQueryTableData(query);
                Combobox_Statement_Date.DisplayMember = "Date";
                Combobox_Statement_Date.ValueMember = "Date";
                Combobox_Statement_Date.DataSource = table;
                Combobox_Statement_Date.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void BranchComboboxFillForSatetment()
        {
            try
            {
                string query;
                if (Radio_University.Checked) query = string.Format("Select Distinct Branch from University_Alloted order by Branch");
                else query = string.Format("Select Distinct Class from Series_Alloted order by Class");
                DataTable table = GetQueryTableData(query);
                if (Radio_University.Checked)
                {
                    Combobox_Statement_BranchClass.DisplayMember = "Branch";
                    Combobox_Statement_BranchClass.ValueMember = "Branch";
                }
                else
                {
                    Combobox_Statement_BranchClass.DisplayMember = "Class";
                    Combobox_Statement_BranchClass.ValueMember = "Class";
                }
                Combobox_Statement_BranchClass.DataSource = table;
                Combobox_Statement_BranchClass.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void Sub_CodeSub_CodeComboboxFillForSatetment()
        {
            try
            {
                string query;
                if (Radio_University.Checked) query = string.Format("Select Distinct Sub_Code from University_Alloted order by Sub_Code");
                else query = string.Format("Select Distinct Sub_Code from Series_Alloted order by Sub_Code");
                DataTable table = GetQueryTableData(query);
                Combobox_Statement_SubCode.DisplayMember = "Sub_Code";
                Combobox_Statement_SubCode.ValueMember = "Sub_Code";
                Combobox_Statement_SubCode.DataSource = table;
                Combobox_Statement_SubCode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl.SelectedTab == Tab_Statement)
            {
                Dgv_Statement.DataSource = null;
                Combobox_Statement_Session.SelectedIndex = 0;
                DateComboboxFillForSatetment();
                BranchComboboxFillForSatetment();
                Sub_CodeSub_CodeComboboxFillForSatetment();
            }
        }

        void FillCandidatesInfoLabel()
        {
            int prescount = 0, abscount = 0;
            foreach(DataGridViewRow viewRow in Dgv_Statement.Rows)
            {
                if (viewRow.Cells["Status"].Value.ToString() == "Absent")
                {
                    abscount++;
                    viewRow.Cells["Status"].Style.ForeColor = Color.Red;
                }
                else prescount++;
            }
            Label_NoOfCandidates.Text = "No of Candidates : " + Dgv_Statement.Rows.Count.ToString();
            Label_NoOfPresent.Text = "No of Present : " + prescount.ToString();
            Label_NoOfAbsent.Text = "No of Absent : " + abscount.ToString();
        }

        private void Button_Statement_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                if (Radio_University.Checked) query = string.Format("select Reg_No,Name,Status,Branch,Course,Sub_Code from University_Alloted Where Date=@Date and Session=@Session and Branch=@Branch and Sub_Code=@Sub_Code order by Reg_No");
                else query = string.Format("select Reg_No,Name,Status,Class,Course,Sub_Code from Series_Alloted Where Date=@Date and Session=@Session and Class=@Class and Sub_Code=@Sub_Code order by Reg_No");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    command.Parameters.AddWithValue("@Date", Combobox_Statement_Date.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Session", Combobox_Statement_Session.SelectedItem.ToString());
                    if(Radio_University.Checked) command.Parameters.AddWithValue("@Branch", Combobox_Statement_BranchClass.SelectedItem.ToString());
                    else command.Parameters.AddWithValue("@Class", Combobox_Statement_BranchClass.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Sub_Code", Combobox_Statement_SubCode.SelectedItem.ToString());
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Dgv_Statement.DataSource = table;                    
                }
                FillCandidatesInfoLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
