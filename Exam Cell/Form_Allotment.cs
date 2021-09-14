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

        void SetLoading(bool loading)
        {
            if (loading)
            {
                TabPanel.Enabled = false;
                Groupbox_SelectExam.Enabled = false;
                Panel_ProgressBar.BringToFront();
            }
            else
            {
                TabPanel.Enabled = true;
                Groupbox_SelectExam.Enabled = true;
                Panel_ProgressBar.SendToBack();
            }
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

        void AllotStudents(bool isSingleAllot)
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    //get rooms details
                    SQLiteCommand roomCommand = new SQLiteCommand("select * from Rooms order by Priority", dbConnection);
                    SQLiteDataAdapter roomAdapter = new SQLiteDataAdapter(roomCommand);
                    DataTable table_rooms = new DataTable();
                    roomAdapter.Fill(table_rooms);
                    if (table_rooms.Rows.Count == 0)
                    {
                        CustomMessageBox.ShowMessageBox("Create any room to allot", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                        return;
                    }
                    string commandQuery = "";
                    if (Radio_University.Checked)
                        commandQuery = string.Format("select RC.Reg_No,RC.Name,RC.Branch,TT.Sub_Code,TT.Course from University_Candidates as RC,Timetable as TT where TT.Date=@Date and TT.Session=@Session and RC.Branch=TT.Branch and RC.Course=TT.Course order by TT.Branch, TT.Course,RC.Reg_No");
                    else
                        commandQuery = string.Format("select SC.Reg_No,SC.Name,SC.Class,SC.Branch,TT.Sub_Code,TT.Course from Series_Candidates as SC,Timetable as TT where TT.Date=@Date and TT.Session=@Session and SC.Branch=TT.Branch and SC.Course=TT.Course order by TT.Branch, TT.Course,SC.Class,SC.Reg_No");

                    //get registered students details
                    SQLiteCommand studentCommand = new SQLiteCommand(commandQuery,dbConnection);
                    studentCommand.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    studentCommand.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    SQLiteDataAdapter studentAdapter = new SQLiteDataAdapter(studentCommand);
                    DataTable table_students = new DataTable();
                    studentAdapter.Fill(table_students);
                    if (table_students.Rows.Count == 0)
                    {
                        CustomMessageBox.ShowMessageBox("No candidates registered or Timetable set to allot", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                        return;
                    }

                    //get branch priority
                    SQLiteCommand command = new SQLiteCommand("select * from Branch_Priority order by Priority",dbConnection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable table_branchPriority = new DataTable();
                    adapter.Fill(table_branchPriority);

                    //sort table_students according to branch priority                
                    table_students.Columns.Add("BranchPriority");
                    foreach (DataRow branchDr in table_branchPriority.Rows)
                    {
                        foreach (DataRow studDr in table_students.Rows)
                        {
                            if (studDr["Branch"] == branchDr["Branch"])
                            {
                                studDr["BranchPriority"] = branchDr["Priority"];
                            }
                        }
                    }
                    if (Radio_University.Checked) table_students.DefaultView.Sort = "BranchPriority,Course,Reg_No";
                    else table_students.DefaultView.Sort = "BranchPriority,Course,Class,Reg_No";
                    table_students = table_students.DefaultView.ToTable();

                    //Allot
                    if (isSingleAllot) Single_Allotment(table_students, table_rooms);
                    else Multi_Allotment(table_students, table_rooms);
                }                    
            }
            catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show(ex.ToString());
            }
        }

        void Single_Allotment(DataTable table_students, DataTable table_rooms)
        {
            try
            {
                string insertQuery = "";
                int totalStudentsCount = table_students.Rows.Count, currentStudentCount = 0, flag = 0;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    if (Radio_University.Checked) insertQuery = string.Format("insert into University_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Branch,Sub_Code,Course)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Branch,@Sub_Code,@Course)");
                    else insertQuery = string.Format("insert into Series_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Class,Sub_Code,Course)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Class,@Sub_Code,@Course)");
                    SQLiteCommand comm = new SQLiteCommand(insertQuery, dbConnection);

                    foreach (DataRow roomrow in table_rooms.Rows)
                    {
                        int no_of_seats = Int32.Parse(roomrow["A_Series"].ToString());
                        for (int i = 0; i < no_of_seats; i++)
                        {
                            if (currentStudentCount < totalStudentsCount)
                            {                                
                                comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                                comm.Parameters.AddWithValue("@Room_No", roomrow["Room_No"].ToString());
                                comm.Parameters.AddWithValue("@Seat", "A" + (i + 1));
                                comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                                comm.Parameters.AddWithValue("@Reg_No", table_students.Rows[currentStudentCount]["Reg_No"].ToString());
                                comm.Parameters.AddWithValue("@Name", table_students.Rows[currentStudentCount]["Name"].ToString());
                                if (Radio_University.Checked) comm.Parameters.AddWithValue("@Branch", table_students.Rows[currentStudentCount]["Branch"].ToString());
                                else comm.Parameters.AddWithValue("@Class", table_students.Rows[currentStudentCount]["Class"].ToString());
                                comm.Parameters.AddWithValue("@Sub_Code", table_students.Rows[currentStudentCount]["Sub_Code"].ToString());
                                comm.Parameters.AddWithValue("@Course", table_students.Rows[currentStudentCount]["Course"].ToString());
                                comm.ExecuteNonQuery();

                                currentStudentCount++;
                            }
                            else
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 1) break;
                    }
                }
                AllotedRoomComboboxFill();
                SearchAllotedRooms();
                SetLoading(false);
                CustomMessageBox.ShowMessageBox("Single Allotment Complete  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show(ex.ToString());
            }
        }

        void Multi_Allotment(DataTable table_students, DataTable table_rooms)
        {
            try
            {
                string insertQuery = "";
                int totalStudentsCount = table_students.Rows.Count, currentStudentsCount = 0, flag = 0;
                //divide students by half to seat as A & B
                DataTable Students_Aseries = table_students.Clone();
                DataTable Students_Bseries = table_students.Clone();
                table_students.AsEnumerable().Take(totalStudentsCount / 2).CopyToDataTable(Students_Aseries, LoadOption.OverwriteChanges);
                table_students.AsEnumerable().Skip(totalStudentsCount / 2).CopyToDataTable(Students_Bseries, LoadOption.OverwriteChanges);

                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    if (Radio_University.Checked) insertQuery = string.Format("insert into University_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Branch,Sub_Code,Course)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Branch,@Sub_Code,@Course)");
                    else insertQuery = string.Format("insert into Series_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Class,Sub_Code,Course)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Class,@Sub_Code,@Course)");
                    SQLiteCommand command4 = new SQLiteCommand(insertQuery, dbConnection);
                    
                    //allot for A series
                    foreach (DataRow roomrow in table_rooms.Rows)
                    {
                        int No_of_seats = Int32.Parse(roomrow["A_Series"].ToString());
                        for (int i = 0; i < No_of_seats; i++)
                        {
                            if (currentStudentsCount < Students_Aseries.Rows.Count)
                            {
                                command4.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                                command4.Parameters.AddWithValue("@Room_No", roomrow["Room_No"].ToString());
                                command4.Parameters.AddWithValue("@Seat", "A" + (i + 1));
                                command4.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                                command4.Parameters.AddWithValue("@Reg_No", Students_Aseries.Rows[currentStudentsCount]["Reg_No"].ToString());
                                command4.Parameters.AddWithValue("@Name", Students_Aseries.Rows[currentStudentsCount]["Name"].ToString());
                                if (Radio_University.Checked) command4.Parameters.AddWithValue("@Branch", Students_Aseries.Rows[currentStudentsCount]["Branch"].ToString());
                                else command4.Parameters.AddWithValue("@Class", Students_Aseries.Rows[currentStudentsCount]["Class"].ToString());
                                command4.Parameters.AddWithValue("@Sub_Code", Students_Aseries.Rows[currentStudentsCount]["Sub_Code"].ToString());
                                command4.Parameters.AddWithValue("@Course", Students_Aseries.Rows[currentStudentsCount]["Course"].ToString());
                                command4.ExecuteNonQuery();

                                currentStudentsCount++;
                            }
                            else
                            {
                                flag = 1;
                                break;
                            }

                        }
                        if (flag == 1) break;
                    }

                    //allot for B series
                    currentStudentsCount = 0; flag = 0;
                    foreach (DataRow roomrow in table_rooms.Rows)
                    {
                        int No_of_seats = Int32.Parse(roomrow["B_Series"].ToString());
                        for (int i = 0; i < No_of_seats; i++)
                        {
                            if (currentStudentsCount < Students_Bseries.Rows.Count)
                            {                                
                                command4.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                                command4.Parameters.AddWithValue("@Room_No", roomrow["Room_No"].ToString());
                                command4.Parameters.AddWithValue("@Seat", "B" + (i + 1));
                                command4.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                                command4.Parameters.AddWithValue("@Reg_No", Students_Bseries.Rows[currentStudentsCount]["Reg_No"].ToString());
                                command4.Parameters.AddWithValue("@Name", Students_Bseries.Rows[currentStudentsCount]["Name"].ToString());
                                if (Radio_University.Checked) command4.Parameters.AddWithValue("@Branch", Students_Bseries.Rows[currentStudentsCount]["Branch"].ToString());
                                else command4.Parameters.AddWithValue("@Class", Students_Bseries.Rows[currentStudentsCount]["Class"].ToString());
                                command4.Parameters.AddWithValue("@Sub_Code", Students_Bseries.Rows[currentStudentsCount]["Sub_Code"].ToString());
                                command4.Parameters.AddWithValue("@Course", Students_Bseries.Rows[currentStudentsCount]["Course"].ToString());
                                command4.ExecuteNonQuery();

                                currentStudentsCount++;
                            }
                            else
                            {
                                flag = 1;
                                break;
                            }

                        }
                        if (flag == 1) break;
                    }
                }

                AllotedRoomComboboxFill();
                SearchAllotedRooms();
                SetLoading(false);
                CustomMessageBox.ShowMessageBox("Multi Allotment Complete  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_SingleAllot_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            AllotStudents(true);
        }

        private void Button_MultiAllot_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            AllotStudents(false);
        }
    }
}
// TESTING //
// * SearchCandidates, query for Series (line 42) ???