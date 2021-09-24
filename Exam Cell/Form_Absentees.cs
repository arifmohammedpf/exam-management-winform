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
                    if (Radio_Series.Checked) query = string.Format("select Seat,Reg_No,Status,Name,Class,Course,Sub_Code from Series_Alloted Where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                    else query = string.Format("select Seat,Reg_No,Status,Name,Branch,Sub_Code,Course from University_Alloted Where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
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
    }
}
