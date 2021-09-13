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
    public partial class Form_Allotment : Form
    {
        public Form_Allotment()
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

        void SearchRegisteredCandidates()
        {
            try
            {
                Dgv_RegCandidates_List.DataSource = null;
                string query;
                if (Radio_University.Checked) query = string.Format("Select * from University_Candidates where Course in ( Select Course from Timetable where Date=@Date and Session=@Session)");
                else query = string.Format("Select SC.* from Series_Candidates as SC ,Timetable as TT where TT.Date=@Date and TT.Session=@Session and SC.Branch=TT.Branch and SC.Course=TT.Course ");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(comm);
                    DataTable studentRecords = new DataTable();
                    dataAdapter.Fill(studentRecords);
                    Dgv_RegCandidates_List.DataSource = studentRecords;
                    Label_NoOfStudents_Registered.Text = "No of Students registered : " + studentRecords.Rows.Count.ToString();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void SearchRegisteredCourseWiseCount()
        {
            try
            {
                Dgv_RegCourseWise_Count.DataSource = null;
                string query, query_NoOfStudents;
                if (Radio_University.Checked) query = string.Format("Select Distinct Sub_Code, Branch from University_Candidates where Sub_Code in ( Select Sub_Code from Timetable where Date=@Date and Session=@Session)");
                else query = string.Format("Select Distinct SC.Sub_Code, SC.Branch from Series_Candidates as SC ,Timetable as TT where TT.Date=@Date and TT.Session=@Session and SC.Branch=TT.Branch and SC.Course=TT.Course ");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(comm);
                    DataTable studentRecords = new DataTable();
                    dataAdapter.Fill(studentRecords);
                    studentRecords.Columns.Add("No of Students", typeof(int));
                    if (Radio_University.Checked) query_NoOfStudents = string.Format("select Count(Reg_No) from University_Candidates where Course=@Course and Branch=@Branch");
                    else query_NoOfStudents = string.Format("select Count(Reg_No) from Series_Candidates where Course=@Course and Branch=@Branch");
                    SQLiteCommand comm2 = new SQLiteCommand(query_NoOfStudents, dbConnection);
                    foreach (DataRow dr in studentRecords.Rows)
                    {
                        comm2.Parameters.AddWithValue("@Course", dr["Course"]);
                        comm2.Parameters.AddWithValue("@Branch", dr["Branch"]);
                        int count = Convert.ToInt32(comm2.ExecuteScalar());
                        dr["No of Students"] = count;
                    }
                    Dgv_RegCourseWise_Count.DataSource = studentRecords;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void SearchAllotedRooms()
        {
            try
            {
                Dgv_Alloted_Rooms.DataSource = null;
                string query = "";
                if (Radio_University.Checked) query = string.Format("select distinct R.Room_No,R.A_Series,R.B_Series from Rooms as R, University_Alloted as UA where UA.Date=@Date and UA.Session=@Session and R.Room_No=UA.Room_No order by R.Room_No");
                else query = string.Format("select distinct R.Room_No,R.A_Series,R.B_Series from Rooms as R, Series_Alloted as SA where SA.Date=@Date and SA.Session=@Session and R.Room_No=SA.Room_No order by R.Room_No");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand comm = new SQLiteCommand(query,dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Dgv_Alloted_Rooms.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void SearchCandidatesInAllotedRooms()
        {
            Dgv_Cand_in_AllotedRooms.DataSource = null;
            Label_NoOfStudents.Text = "No of Students : ";
            if (Combobox_Alloted_Rooms.SelectedIndex != 0)
            {
                string query = "";
                if (Radio_University.Checked) query = string.Format("select Reg_No,Name,Sub_Code,Room_No,Seat from University_Alloted where Date=@Date and Session=@Session and Room_No=@Room_No order by Reg_No");
                else query = string.Format("select Reg_No,Name,Sub_Code,Room_No,Seat from Series_Alloted where Date=@Date and Session=@Session and Room_No=@Room_No order by Reg_No");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    comm.Parameters.AddWithValue("@Room_No", Combobox_Alloted_Rooms.SelectedItem.ToString());
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    Dgv_Cand_in_AllotedRooms.DataSource = dataTable;
                    Label_NoOfStudents.Text = "No of Students : " + dataTable.Rows.Count.ToString();
                }
            }
        }

        private void DateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {
            if(Combobox_Session.SelectedIndex != 0)
            {
                SearchRegisteredCandidates();
                SearchRegisteredCourseWiseCount();
                SearchAllotedRooms();
                AllotedRoomComboboxFill();
            }
        }

        private void Combobox_Session_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_Session.SelectedIndex != 0)
            {
                SearchRegisteredCandidates();
                SearchRegisteredCourseWiseCount();
                SearchAllotedRooms();
                AllotedRoomComboboxFill();
            }
        }

        void AllotedRoomComboboxFill()
        {
            try
            {
                Dgv_Cand_in_AllotedRooms.DataSource = null;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    string query;
                    if (Radio_University.Checked) query = string.Format("Select Distinct Room_No from University_Alloted where Date=@Date and Session=@Session order by Room_No");
                    else query = string.Format("Select Distinct Room_No from Series_Alloted where Date=@Date and Session=@Session order by Room_No");
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                    DataTable roomDatatable = new DataTable();
                    adapter.Fill(roomDatatable);
                    DataRow roomTableTop = roomDatatable.NewRow();
                    roomTableTop[0] = "-Select-";
                    roomDatatable.Rows.InsertAt(roomTableTop, 0);

                    Combobox_Alloted_Rooms.DataSource = roomDatatable;
                    Combobox_Alloted_Rooms.DisplayMember = "Room_No";
                    Combobox_Alloted_Rooms.ValueMember = "Room_No";
                    Combobox_Alloted_Rooms.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Combobox_Alloted_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCandidatesInAllotedRooms();
        }
    }
}
// TESTING //
// * SearchCandidates, query for Series (line 42) ???