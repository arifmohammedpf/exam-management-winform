using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

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
                    dbConnection.Open();
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
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
                    dbConnection.Open();
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
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
                    dbConnection.Open();
                    SQLiteCommand comm = new SQLiteCommand(query,dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
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
                    dbConnection.Open();
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                    comm.Parameters.AddWithValue("@Room_No", Combobox_Alloted_Rooms.Text);
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
                ShiftOrSwap_FormReset();
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
                ShiftOrSwap_FormReset();
            }
        }

        DataTable GetAllotedRooms()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                string query;
                if (Radio_University.Checked) query = string.Format("Select Distinct Room_No from University_Alloted where Date=@Date and Session=@Session order by Room_No");
                else query = string.Format("Select Distinct Room_No from Series_Alloted where Date=@Date and Session=@Session order by Room_No");
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                DataTable roomDatatable = new DataTable();
                adapter.Fill(roomDatatable);
                DataRow roomTableTop = roomDatatable.NewRow();
                roomTableTop[0] = "-Select-";
                roomDatatable.Rows.InsertAt(roomTableTop, 0);
                return roomDatatable;
            }
        }

        void AllotedRoomComboboxFill()
        {
            try
            {
                Combobox_Alloted_Rooms.DataSource = null;
                if (Combobox_Session.SelectedIndex != 0)
                {
                    DataTable roomDatatable = GetAllotedRooms();
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
                    dbConnection.Open();
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
                    studentCommand.Parameters.AddWithValue("@Session", Combobox_Session.Text);
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
                    dbConnection.Open();
                    if (Radio_University.Checked) insertQuery = string.Format("insert into University_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Branch,Sub_Code,Course,Status)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Branch,@Sub_Code,@Course,@Status)");
                    else insertQuery = string.Format("insert into Series_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Class,Sub_Code,Course,Status)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Class,@Sub_Code,@Course,@Status)");
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
                                comm.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                                comm.Parameters.AddWithValue("@Reg_No", table_students.Rows[currentStudentCount]["Reg_No"].ToString());
                                comm.Parameters.AddWithValue("@Name", table_students.Rows[currentStudentCount]["Name"].ToString());
                                if (Radio_University.Checked) comm.Parameters.AddWithValue("@Branch", table_students.Rows[currentStudentCount]["Branch"].ToString());
                                else comm.Parameters.AddWithValue("@Class", table_students.Rows[currentStudentCount]["Class"].ToString());
                                comm.Parameters.AddWithValue("@Sub_Code", table_students.Rows[currentStudentCount]["Sub_Code"].ToString());
                                comm.Parameters.AddWithValue("@Course", table_students.Rows[currentStudentCount]["Course"].ToString());
                                comm.Parameters.AddWithValue("@Status", "Present");
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
                ShiftOrSwap_FormReset();
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
                    dbConnection.Open();
                    if (Radio_University.Checked) insertQuery = string.Format("insert into University_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Branch,Sub_Code,Course,Status)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Branch,@Sub_Code,@Course,@Status)");
                    else insertQuery = string.Format("insert into Series_Alloted(Date,Room_No,Seat,Session,Reg_No,Name,Class,Sub_Code,Course,Status)Values(" + "@Date,@Room_No,@Seat,@Session,@Reg_No,@Name,@Class,@Sub_Code,@Course,@Status)");
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
                                command4.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                                command4.Parameters.AddWithValue("@Reg_No", Students_Aseries.Rows[currentStudentsCount]["Reg_No"].ToString());
                                command4.Parameters.AddWithValue("@Name", Students_Aseries.Rows[currentStudentsCount]["Name"].ToString());
                                if (Radio_University.Checked) command4.Parameters.AddWithValue("@Branch", Students_Aseries.Rows[currentStudentsCount]["Branch"].ToString());
                                else command4.Parameters.AddWithValue("@Class", Students_Aseries.Rows[currentStudentsCount]["Class"].ToString());
                                command4.Parameters.AddWithValue("@Sub_Code", Students_Aseries.Rows[currentStudentsCount]["Sub_Code"].ToString());
                                command4.Parameters.AddWithValue("@Course", Students_Aseries.Rows[currentStudentsCount]["Course"].ToString());
                                command4.Parameters.AddWithValue("@Status", "Present");
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
                                command4.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                                command4.Parameters.AddWithValue("@Reg_No", Students_Bseries.Rows[currentStudentsCount]["Reg_No"].ToString());
                                command4.Parameters.AddWithValue("@Name", Students_Bseries.Rows[currentStudentsCount]["Name"].ToString());
                                if (Radio_University.Checked) command4.Parameters.AddWithValue("@Branch", Students_Bseries.Rows[currentStudentsCount]["Branch"].ToString());
                                else command4.Parameters.AddWithValue("@Class", Students_Bseries.Rows[currentStudentsCount]["Class"].ToString());
                                command4.Parameters.AddWithValue("@Sub_Code", Students_Bseries.Rows[currentStudentsCount]["Sub_Code"].ToString());
                                command4.Parameters.AddWithValue("@Course", Students_Bseries.Rows[currentStudentsCount]["Course"].ToString());
                                command4.Parameters.AddWithValue("@Status", "Present");
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
                ShiftOrSwap_FormReset();
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

        void ResetData()
        {
            Dgv_RegCandidates_List.DataSource = null;
            Dgv_RegCourseWise_Count.DataSource = null;
            Dgv_Alloted_Rooms.DataSource = null;
            Dgv_Cand_in_AllotedRooms.DataSource = null;
            Combobox_Session.SelectedIndex = 0;
            DateTimePicker_Date.Value = DateTime.Now;
            ShiftOrSwap_FormReset();
        }

        private void Radio_University_CheckedChanged(object sender, EventArgs e)
        {
            ResetData();
        }

        private void Radio_Series_CheckedChanged(object sender, EventArgs e)
        {
            ResetData();
        }

        void LoadFilepathToSaveExcel()
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand comm = new SQLiteCommand("Select Savepath from DBManagement where Savepath is not null");
                string savepath = (string)comm.ExecuteScalar();
                Textbox_Filepath.Text = savepath;
            }
        }

        void GetRooms_ToShiftSwap()
        {
            try
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    string query = string.Format("Select Distinct Room_No from Rooms order by Room_No");
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(comm);
                    DataTable roomDatatable = new DataTable();
                    adapter.Fill(roomDatatable);
                    DataRow roomTableTop = roomDatatable.NewRow();
                    roomTableTop[0] = "-Select-";
                    roomDatatable.Rows.InsertAt(roomTableTop, 0);
                    Combobox_From_RoomNo.DataSource = roomDatatable;
                    Combobox_From_RoomNo.DisplayMember = "Room_No";
                    Combobox_From_RoomNo.ValueMember = "Room_No";
                    Combobox_From_RoomNo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void Form_Allotment_Load(object sender, EventArgs e)
        {
            DateTimePicker_Date.Format = DateTimePickerFormat.Custom;
            DateTimePicker_Date.CustomFormat = "dd-MM-yyyy";
            DateTimePicker_Date.Value = DateTime.Now;
            LoadFilepathToSaveExcel();
            // fill To_Room Shift/Swap
            GetRooms_ToShiftSwap();
            Radio_University.Checked = true;
        }

        void ShiftOrSwap_FormReset()
        {
            Combobox_From_RoomNo.DataSource = null;
            Combobox_From_SeriesAB.SelectedIndex = 0;
            Combobox_From_Starting_Seat.Items.Clear();
            Combobox_From_Ending_Seat.Items.Clear();
            //Combobox_To_RoomNo.DataSource = null;
            Combobox_To_SeriesAB.SelectedIndex = 0;
            Combobox_To_Starting_Seat.Items.Clear();

            // Combobox From_RoomNo
            if (Combobox_Session.SelectedIndex != 0)
            {
                DataTable roomDatatable = GetAllotedRooms();
                Combobox_From_RoomNo.DataSource = roomDatatable;
                Combobox_From_RoomNo.DisplayMember = "Room_No";
                Combobox_From_RoomNo.ValueMember = "Room_No";
                Combobox_From_RoomNo.SelectedIndex = 0;
            }
        }

        bool ValidateFromToRoomSeatNo()
        {
            int selectedSeatsInToRoom = (totalSeats_inToRoom - int.Parse(Combobox_To_Starting_Seat.Text)) + 1;
            if(seatsSelectedInFromRoom > selectedSeatsInToRoom)
                return false;
            return true;
        }

        private void Button_Shift_Click(object sender, EventArgs e)
        {
            if (Combobox_From_RoomNo.SelectedIndex != 0 && Combobox_To_RoomNo.SelectedIndex != 0 && Combobox_From_SeriesAB.SelectedIndex != 0 && Combobox_To_SeriesAB.SelectedIndex != 0)
            {
                CustomMessageBox.ShowMessageBox("Are you sure to shift selected students ?   ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
                string result = CustomMessageBox.UserChoice;
                if (result == "Yes")
                {
                    bool canShift = ValidateFromToRoomSeatNo();
                    if (canShift)
                    {
                        try
                        {
                            int fromRoomStartSeat = int.Parse(Combobox_From_Starting_Seat.Text);
                            int fromRoomEndSeat = int.Parse(Combobox_From_Ending_Seat.Text);
                            int toRoomStartSeat = int.Parse(Combobox_To_Starting_Seat.Text);
                            string fromRoomNo = Combobox_From_RoomNo.Text;
                            string toRoomNo = Combobox_To_RoomNo.Text;
                            string fromRoomSeries = Combobox_From_SeriesAB.Text;
                            string toRoomSeries = Combobox_To_SeriesAB.Text;
                            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                            {
                                dbConnection.Open();
                                string query;
                                if (Radio_University.Checked) query = string.Format("update University_Alloted set Room_No=@Room_No,Seat=@Seat where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No and Seat=@SelectedSeat");
                                else query = string.Format("update Series_Alloted set Room_No=@Room_No,Seat=@Seat where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No and Seat=@SelectedSeat");
                                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                                for (int i = fromRoomStartSeat; i <= fromRoomEndSeat; i++)
                                {
                                    MessageBox.Show(toRoomSeries + toRoomStartSeat); // testing msg box.........delete after testing
                                    comm.Parameters.AddWithValue("@Room_No", toRoomNo);
                                    comm.Parameters.AddWithValue("@Seat", toRoomSeries + toRoomStartSeat);
                                    comm.Parameters.AddWithValue("@SelectedDate", DateTimePicker_Date.Text);
                                    comm.Parameters.AddWithValue("@SelectedSession", Combobox_Session.Text);
                                    comm.Parameters.AddWithValue("@SelectedRoom_No", fromRoomNo);
                                    comm.Parameters.AddWithValue("@SelectedSeat", fromRoomSeries + i);
                                    comm.ExecuteNonQuery();

                                    toRoomStartSeat++;
                                }
                            }
                            CustomMessageBox.ShowMessageBox("Students shifted  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else CustomMessageBox.ShowMessageBox("Not enough seats to shift", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                }                    
            }
        }

        bool CheckIfRoomExist()
        {
            int roomCount;
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                string query;
                if (Radio_University.Checked) query = string.Format("Select Count(*) from University_Alloted where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No");
                else query = string.Format("Select Count(*) from Series_Alloted where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No");
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                comm.Parameters.AddWithValue("@SelectedDate", DateTimePicker_Date.Text);
                comm.Parameters.AddWithValue("@SelectedSession", Combobox_Session.Text);
                comm.Parameters.AddWithValue("@SelectedRoom_No", Combobox_To_RoomNo.Text);
                roomCount = (int)comm.ExecuteScalar();
            }
            if (roomCount > 0) return true;
            return false;
        }

        private void Button_Swap_Click(object sender, EventArgs e)
        {
            bool isToRoomExist = CheckIfRoomExist();
            if (isToRoomExist)
            {
                if (Combobox_From_RoomNo.SelectedIndex != 0 && Combobox_To_RoomNo.SelectedIndex != 0 && Combobox_From_SeriesAB.SelectedIndex != 0 && Combobox_To_SeriesAB.SelectedIndex != 0)
                {
                    CustomMessageBox.ShowMessageBox("Are you sure to swap selected students ?   ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
                    string result = CustomMessageBox.UserChoice;
                    if (result == "Yes")
                    {
                        bool canSwap = ValidateFromToRoomSeatNo();
                        if (canSwap)
                        {
                            try
                            {
                                int fromRoomStartSeat = int.Parse(Combobox_From_Starting_Seat.Text);
                                int fromRoomEndSeat = int.Parse(Combobox_From_Ending_Seat.Text);
                                int toRoomStartSeat = int.Parse(Combobox_To_Starting_Seat.Text);
                                string fromRoomNo = Combobox_From_RoomNo.Text;
                                string toRoomNo = Combobox_To_RoomNo.Text;
                                string fromRoomSeries = Combobox_From_SeriesAB.Text;
                                string toRoomSeries = Combobox_To_SeriesAB.Text;
                                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                                {
                                    dbConnection.Open();
                                    string query, secondQuery;
                                    if (Radio_University.Checked) query = string.Format("Select Room_No,Seat,Reg_No from University_Alloted where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                                    else query = string.Format("Select Room_No,Seat,Reg_No from Series_Alloted where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                                    SQLiteCommand selectCommand = new SQLiteCommand(query, dbConnection);
                                    selectCommand.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                                    selectCommand.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                                    selectCommand.Parameters.AddWithValue("@Room_No", toRoomNo);
                                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectCommand);
                                    DataTable dataTableStudents = new DataTable();
                                    adapter.Fill(dataTableStudents);

                                    if (Radio_University.Checked)
                                    {
                                        query = string.Format("update University_Alloted set Room_No=@Room_No,Seat=@Seat where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No and Seat=@SelectedSeat");
                                        secondQuery = string.Format("update University_Alloted set Room_No=@Room_No,Seat=@Seat where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No and Reg_No=@SelectedReg_No");
                                    }
                                    else
                                    {
                                        query = string.Format("update Series_Alloted set Room_No=@Room_No,Seat=@Seat where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No and Seat=@SelectedSeat");
                                        secondQuery = string.Format("update Series_Alloted set Room_No=@Room_No,Seat=@Seat where Date=@SelectedDate and Session=@SelectedSession and Room_No=@SelectedRoom_No and Reg_No=@SelectedReg_No");
                                    }
                                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                                    SQLiteCommand updateCommand = new SQLiteCommand(secondQuery, dbConnection);
                                    for (int i = fromRoomStartSeat; i <= fromRoomEndSeat; i++)
                                    {
                                        MessageBox.Show(toRoomSeries + toRoomStartSeat); // testing msg box.........delete after testing
                                                                                         // fromRoom to toRoom
                                        comm.Parameters.AddWithValue("@Room_No", toRoomNo);
                                        comm.Parameters.AddWithValue("@Seat", toRoomSeries + toRoomStartSeat);
                                        comm.Parameters.AddWithValue("@SelectedDate", DateTimePicker_Date.Text);
                                        comm.Parameters.AddWithValue("@SelectedSession", Combobox_Session.Text);
                                        comm.Parameters.AddWithValue("@SelectedRoom_No", fromRoomNo);
                                        comm.Parameters.AddWithValue("@SelectedSeat", fromRoomSeries + i);
                                        comm.ExecuteNonQuery();

                                        // toRoom to fromRoom
                                        foreach (DataRow dataRow in dataTableStudents.Rows)
                                        {
                                            if (dataRow["Seat"].ToString() == toRoomSeries + toRoomStartSeat)
                                            {
                                                updateCommand.Parameters.AddWithValue("@Room_No", fromRoomNo);
                                                updateCommand.Parameters.AddWithValue("@Seat", fromRoomSeries + i);
                                                updateCommand.Parameters.AddWithValue("@SelectedDate", DateTimePicker_Date.Text);
                                                updateCommand.Parameters.AddWithValue("@SelectedSession", Combobox_Session.Text);
                                                updateCommand.Parameters.AddWithValue("@SelectedRoom_No", toRoomNo);
                                                updateCommand.Parameters.AddWithValue("@SelectedReg_No", dataRow["Reg_No"]);
                                                updateCommand.ExecuteNonQuery();
                                                break;
                                            }
                                        }

                                        toRoomStartSeat++;
                                    }
                                }
                                CustomMessageBox.ShowMessageBox("Students swapped  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        else CustomMessageBox.ShowMessageBox("Not enough seats to swap", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                string messageText = string.Format("Room '%{0}%' does not exist in Alloted records  ", Combobox_To_RoomNo.Text);
                CustomMessageBox.ShowMessageBox(messageText, "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            }
        }

        private void Combobox_From_SeriesAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_From_Starting_Seat.Items.Clear();
            Combobox_From_Ending_Seat.Items.Clear();
            if (Combobox_From_SeriesAB.SelectedIndex != 0)
            {
                int noOfSeats;
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    string query = string.Format("Select @Series from Rooms where Room_No=@Room_No");
                    string selectedSeries = Combobox_From_SeriesAB.Text + "_Series";
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Series", selectedSeries);
                    comm.Parameters.AddWithValue("@Room_No", Combobox_From_RoomNo.Text);
                    noOfSeats = (int)comm.ExecuteScalar();
                }
                // fill start & end seat combobox
                for(int i=1; i<=noOfSeats; i++)
                {
                    Combobox_From_Starting_Seat.Items.Add(i);
                    Combobox_From_Ending_Seat.Items.Add(i);
                }
                Combobox_From_Starting_Seat.SelectedIndex = 0;
                Combobox_From_Ending_Seat.SelectedIndex = 0;
            }
        }

        int totalSeats_inToRoom;
        private void Combobox_To_SeriesAB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combobox_To_Starting_Seat.Items.Clear();
            if (Combobox_To_SeriesAB.SelectedIndex != 0)
            {                
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    string query = string.Format("Select @Series from Rooms where Room_No=@Room_No");
                    string selectedSeries = Combobox_To_SeriesAB.Text + "_Series";
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Series", selectedSeries);
                    comm.Parameters.AddWithValue("@Room_No", Combobox_To_RoomNo.Text);
                    totalSeats_inToRoom = (int)comm.ExecuteScalar();
                }
                // fill start & end seat combobox
                for (int i = 1; i <= totalSeats_inToRoom; i++)
                {
                    Combobox_To_Starting_Seat.Items.Add(i);
                }
                Combobox_To_Starting_Seat.SelectedIndex = 0;
            }
        }

        int seatsSelectedInFromRoom;
        void Get_No_Of_Students_Selected()
        {
            try
            {
                Label_No_Of_Students_Selected.Text = "No of students selected : ";
                if (Combobox_From_Starting_Seat.SelectedIndex != 0 && Combobox_From_Ending_Seat.SelectedIndex != 0)
                {
                    int startSeat, endSeat;
                    startSeat = int.Parse(Combobox_From_Ending_Seat.Text);
                    endSeat = int.Parse(Combobox_From_Starting_Seat.Text);
                    if (startSeat <= endSeat)
                    {
                        seatsSelectedInFromRoom = (endSeat - startSeat) + 1;
                        Label_No_Of_Students_Selected.Text = "No of students selected : " + seatsSelectedInFromRoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void Combobox_From_Starting_Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_No_Of_Students_Selected();
        }

        private void Combobox_From_Ending_Seat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_No_Of_Students_Selected();
        }

        private void Button_FilepathChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand comm = new SQLiteCommand("update DBManagement set Savepath=@savepath where Savepath is not null", dbConnection);
                    comm.Parameters.AddWithValue("@savepath", fdb.SelectedPath.ToString());
                    comm.ExecuteNonQuery();
                    Textbox_Filepath.Text = fdb.SelectedPath;
                }                    
            }
        }

        bool CheckStudentsAlloted()
        {
            string commandtext;
            if (Radio_Series.Checked) commandtext = string.Format("SELECT Count(*) from Series_Alloted where Date=@Date and Session=@Session");
            else commandtext = string.Format("SELECT Count(*) from University_Alloted where Date=@Date and Session=@Session");
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(commandtext, dbConnection);
                command.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                command.Parameters.AddWithValue("@Session", Combobox_Session.Text);
                Int32 Checkcount = Convert.ToInt32(command.ExecuteScalar());
                if (Checkcount == 0)
                {
                    CustomMessageBox.ShowMessageBox("No students alloted    ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
        }
        void Generate_Excel_Room_Signature_Sheet(string f)
        {
            if (Combobox_Session.SelectedIndex != 0 && Textbox_Filepath.Text != "Select Filepath")
            {
                bool isStudentsAlloted = CheckStudentsAlloted();
                if (!isStudentsAlloted) return;
                try
                {
                    string createRoomPath = Textbox_Filepath.Text + @"\Room Sheets";
                    string createSignaturePath = Textbox_Filepath.Text + @"\Signature Sheets";
                    Directory.CreateDirectory(createRoomPath);
                    Directory.CreateDirectory(createSignaturePath);


                    string selectQuery = "", date = DateTimePicker_Date.Text, session = Combobox_Session.Text;
                    //Create a query and fill the data table with the data from the DB            
                    if (Radio_Series.Checked) selectQuery = string.Format("SELECT Seat,Reg_No,Name,Sub_Code,Room_No from Series_Alloted Where Date=@Date and Session=@Session order by Room_No");
                    else selectQuery = string.Format("SELECT Seat,Reg_No,Name,Sub_Code,Room_No from University_Alloted Where Date=@Date and Session=@Session order by Room_No");
                    DataTable dt, dstnctroomdatatable;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand cmd = new SQLiteCommand(selectQuery, dbConnection);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Session", session);
                        SQLiteDataAdapter adptr = new SQLiteDataAdapter(cmd);
                        dt = new DataTable();
                        adptr.Fill(dt);

                        if (Radio_Series.Checked) selectQuery = string.Format("SELECT Distinct Room_No from Series_Alloted Where Date=@Date and Session=@Session");
                        else selectQuery = string.Format("SELECT Distinct Room_No from University_Alloted Where Date=@Date and Session=@Session");

                        SQLiteCommand commandroom = new SQLiteCommand(selectQuery, dbConnection);
                        commandroom.Parameters.AddWithValue("@Date", date);
                        commandroom.Parameters.AddWithValue("@Session", session);
                        SQLiteDataAdapter distinctroomadapter = new SQLiteDataAdapter(commandroom);
                        dstnctroomdatatable = new DataTable();
                        distinctroomadapter.Fill(dstnctroomdatatable);
                    }
                    using (var package = new ExcelPackage())
                    {
                        foreach (DataRow dstrw in dstnctroomdatatable.Rows)
                        {
                            string checkroom = dstrw["Room_No"].ToString();
                            //Add a new worksheet to the empty workbook
                            var worksheet = package.Workbook.Worksheets.Add(checkroom);
                            //Insert Items to ExcelSheet
                            worksheet.Cells["A1"].Value = "KMEA ENGINEERING COLLEGE";
                            worksheet.Cells["A2"].Value = Textbox_ExamName.Text;
                            if (f == "Room_Sheet") worksheet.Cells["A3"].Value = "STUDENTS LIST";
                            else worksheet.Cells["A3"].Value = "ATTENDANCE STATEMENT";
                            worksheet.Cells["A4"].Value = "Room No: " + checkroom;
                            worksheet.Cells["E4"].Value = date + " " + session;

                            using (var range = worksheet.Cells["A1:F1"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 14;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (var range = worksheet.Cells["A2:F2"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 12;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (var range = worksheet.Cells["A3:F3"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 10;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (var range = worksheet.Cells["A4:C4"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 10;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                            }
                            using (var range = worksheet.Cells["A4:F4"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 10;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                            }

                            // column headings
                            worksheet.Cells[5, 1].Value = "Sl.No";
                            worksheet.Cells[5, 1].Style.Font.Name = "Arial";
                            worksheet.Cells[5, 1].Style.Font.Size = 10;
                            worksheet.Cells[5, 1].Style.Font.Bold = true;
                            if (f == "Signature_Sheet")
                            {
                                worksheet.Cells[5, dt.Columns.Count + 2].Value = "Signature";
                                worksheet.Cells[5, dt.Columns.Count + 2].Style.Font.Bold = true;
                            }
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                worksheet.Cells[5, i + 2].Value = dt.Columns[i].ColumnName;
                                worksheet.Cells[5, i + 2].Style.Font.Name = "Arial";
                                worksheet.Cells[5, i + 2].Style.Font.Size = 10;
                                worksheet.Cells[5, i + 2].Style.Font.Bold = true;
                            }

                            // rows
                            int rc = 0;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (dt.Rows[i]["Room_No"].ToString() == checkroom)
                                {
                                    worksheet.Cells[rc + 6, 1].Value = rc + 1;    //Sl.No Filling
                                    for (int j = 0; j < dt.Columns.Count; j++)
                                    {
                                        worksheet.Cells[rc + 6, j + 2].Value = dt.Rows[i][j];
                                    }
                                    rc++;
                                }

                            }
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                            if (f == "Room_Sheet")
                            {
                                using (var range = worksheet.Cells[5, 1, rc + 5, dt.Columns.Count + 1])
                                {
                                    range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                }
                            }
                            else
                            {
                                using (var range = worksheet.Cells[5, 1, rc + 5, dt.Columns.Count + 2])
                                {
                                    range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                    range.Merge = true;
                                }
                                worksheet.Cells[rc + 7, 1].Value = " Write the Register Numbers of the absentees in the box";
                                using (var range = worksheet.Cells[rc + 8, 1, rc + 16, 4])
                                {
                                    range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                }
                                worksheet.Cells[rc + 16, 5].Value = " Name and Signature of Invigilator(s)";
                            }
                        }
                        //Save Excel File
                        string path = createRoomPath + @"\Room Sheet " + date + " " + session + ".xlsx";
                        if (f == "Signature_Sheet") path = createSignaturePath + @"\Signature Sheet " + date + " " + session + ".xlsx";

                        Stream stream = File.Create(path);
                        package.SaveAs(stream);
                        stream.Close();
                    }
                    CustomMessageBox.ShowMessageBox("Excel sheets generated  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else CustomMessageBox.ShowMessageBox("Check whether Session and filepath is selected or not   ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
        }

        private void Button_RoomSheet_Click(object sender, EventArgs e)
        {
            Generate_Excel_Room_Signature_Sheet("Room_Sheet");
        }

        private void Button_SignatureSheet_Click(object sender, EventArgs e)
        {
            Generate_Excel_Room_Signature_Sheet("Signature_Sheet");
        }

        void Generate_Excel_Display_Sheet()
        {
            if (Combobox_Session.SelectedIndex != 0 && Textbox_Filepath.Text != "Select Filepath")
            {
                bool isStudentsAlloted = CheckStudentsAlloted();
                if (!isStudentsAlloted) return;
                try
                {
                    string createDisplayPath = Textbox_Filepath.Text + @"\Display Sheets";
                    Directory.CreateDirectory(createDisplayPath);

                    string selectQuery = "", date = DateTimePicker_Date.Text, session = Combobox_Session.Text;

                    if (Radio_University.Checked) selectQuery = string.Format("SELECT Distinct Branch from University_Alloted Where Date=@Date and Session=@Session");
                    else selectQuery = string.Format("SELECT Distinct Class from Series_Alloted Where Date=@Date and Session=@Session");
                    DataTable dataTableBranchClass;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand commandroom = new SQLiteCommand(selectQuery,dbConnection);
                        commandroom.Parameters.AddWithValue("@Date", date);
                        commandroom.Parameters.AddWithValue("@Session", session);
                        SQLiteDataAdapter adptr2 = new SQLiteDataAdapter(commandroom);
                        dataTableBranchClass = new DataTable();
                        adptr2.Fill(dataTableBranchClass);
                    }
                    using (var package = new ExcelPackage())
                    {
                        foreach (DataRow dstrw in dataTableBranchClass.Rows)
                        {
                            string checkbranch;
                            if (Radio_University.Checked) checkbranch = dstrw["Branch"].ToString();
                            else checkbranch = dstrw["Class"].ToString();
                            //Add a new worksheet to the empty workbook
                            var worksheet = package.Workbook.Worksheets.Add(checkbranch);
                            //Insert Items to ExcelSheet
                            worksheet.Cells["A1"].Value = "KMEA ENGINEERING COLLEGE";
                            worksheet.Cells["A2"].Value = Textbox_ExamName.Text;
                            worksheet.Cells["A3"].Value = date + " " + session;
                            worksheet.Cells["A4"].Value = checkbranch;
                            worksheet.Cells["A5"].Value = "Register No - Room No - Seat No";
                            using (var range = worksheet.Cells["A5"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 14;
                                range.Style.Font.Bold = true;
                            }
                            using (var range = worksheet.Cells["A1:D1"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 16;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (var range = worksheet.Cells["A2:D2"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 14;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (var range = worksheet.Cells["A3:D3"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 14;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (var range = worksheet.Cells["A4:D4"])
                            {
                                range.Style.Font.Name = "Arial";
                                range.Style.Font.Size = 14;
                                range.Style.Font.Bold = true;
                                range.Merge = true;
                                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                            {
                                dbConnection.Open();
                                if (Radio_University.Checked)
                                {
                                    SQLiteCommand coursecommand = new SQLiteCommand("Select Course from University_Alloted where Branch=@Branch and Date=@Date and Session=@Session ", dbConnection);
                                    coursecommand.Parameters.AddWithValue("@Branch", checkbranch);
                                    coursecommand.Parameters.AddWithValue("@Date", date);
                                    coursecommand.Parameters.AddWithValue("@Session", session);
                                    string Course = (string)coursecommand.ExecuteScalar();
                                    SQLiteCommand examcodecommand = new SQLiteCommand("Select Sub_Code from University_Alloted where Branch=@Branch and Date=@Date and Session=@Session ", dbConnection);
                                    examcodecommand.Parameters.AddWithValue("@Branch", checkbranch);
                                    examcodecommand.Parameters.AddWithValue("@Date", date);
                                    examcodecommand.Parameters.AddWithValue("@Session", session);
                                    string ExamCode = (string)examcodecommand.ExecuteScalar();
                                    worksheet.Cells["A6"].Value = Course + " " + ExamCode;
                                    using (var range = worksheet.Cells["A6"])
                                    {
                                        range.Style.Font.Name = "Arial";
                                        range.Style.Font.Size = 14;
                                        range.Style.Font.Bold = true;
                                    }
                                    SQLiteCommand coursecmd = new SQLiteCommand("SELECT Reg_No,Room_No,Seat from University_Alloted Where Date=@Date and Session=@Session and Course=@Course order by Reg_No", dbConnection);
                                    coursecmd.Parameters.AddWithValue("@Date", date);
                                    coursecmd.Parameters.AddWithValue("@Session", session);
                                    coursecmd.Parameters.AddWithValue("@Course", Course);
                                    DataTable coursedt = new DataTable();
                                    SQLiteDataAdapter courseadptr = new SQLiteDataAdapter(coursecmd);
                                    courseadptr.Fill(coursedt);
                                    //excel table format
                                    int j = 7, k = 1, limit = coursedt.Rows.Count / 3;
                                    for (var i = 0; i < coursedt.Rows.Count; i++)
                                    {
                                        worksheet.Cells[j, k].Value = coursedt.Rows[i][0] + " - " + coursedt.Rows[i][1] + " - " + coursedt.Rows[i][2];
                                        if (j == limit + 7)
                                        {
                                            k++;
                                            j = 7;
                                        }
                                        j++;
                                    }
                                    using (var range = worksheet.Cells[7, 1, limit + 7, k])
                                    {
                                        range.Style.Font.Name = "Arial";
                                        range.Style.Font.Size = 14;
                                        range.Style.Font.Bold = true;
                                    }
                                }
                                else
                                {
                                    SQLiteCommand coursecommand = new SQLiteCommand("Select Distinct Course,Sub_Code from Series_Alloted where Class=@Class and Date=@Date and Session=@Session ", dbConnection);
                                    coursecommand.Parameters.AddWithValue("@Class", checkbranch);
                                    coursecommand.Parameters.AddWithValue("@Date", date);
                                    coursecommand.Parameters.AddWithValue("@Session", session);
                                    DataTable coursedata = new DataTable();
                                    SQLiteDataAdapter coursedataadptr = new SQLiteDataAdapter(coursecommand);
                                    coursedataadptr.Fill(coursedata);
                                    int sheet_row = 6;
                                    foreach (DataRow dataRow in coursedata.Rows)
                                    {
                                        worksheet.Cells[sheet_row, 1].Value = dataRow["Course"].ToString() + " " + dataRow["Exam_code"].ToString();
                                        using (var range = worksheet.Cells[sheet_row, 1])
                                        {
                                            range.Style.Font.Name = "Arial";
                                            range.Style.Font.Size = 14;
                                            range.Style.Font.Bold = true;
                                        }
                                        sheet_row++;
                                        SQLiteCommand coursecmd = new SQLiteCommand("SELECT Reg_No,Room_No,Seat from Series_Alloted Where Date=@Date and Session=@Session and Course=@Course order by Reg_No", dbConnection);
                                        coursecmd.Parameters.AddWithValue("@Date", date);
                                        coursecmd.Parameters.AddWithValue("@Session", session);
                                        coursecommand.Parameters.AddWithValue("@Course", dataRow["Course"].ToString());
                                        DataTable coursedt = new DataTable();
                                        SQLiteDataAdapter courseadptr = new SQLiteDataAdapter(coursecmd);
                                        courseadptr.Fill(coursedt);
                                        int limit = (coursedt.Rows.Count / 3) + sheet_row, col = 1, current_row = sheet_row;
                                        for (var i = 0; i < coursedt.Rows.Count; i++)
                                        {
                                            worksheet.Cells[sheet_row, col].Value = coursedt.Rows[i][0] + " - " + coursedt.Rows[i][1] + " - " + coursedt.Rows[i][2];
                                            if (sheet_row == limit)
                                            {
                                                sheet_row = current_row;
                                                col++;
                                            }
                                            sheet_row++;
                                        }
                                        using (var range = worksheet.Cells[7, 1, limit, col])
                                        {
                                            range.Style.Font.Name = "Arial";
                                            range.Style.Font.Size = 14;
                                            range.Style.Font.Bold = true;
                                        }
                                        sheet_row++;
                                    }
                                }
                            }
                                
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                        }
                        //Save Excel File
                        string path = createDisplayPath + @"\Display Sheet " + date + " " + session + ".xlsx";
                        Stream stream = File.Create(path);
                        package.SaveAs(stream);
                        stream.Close();
                    }
                    CustomMessageBox.ShowMessageBox("Display sheets generated  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else CustomMessageBox.ShowMessageBox("Check whether Session and filepath is selected or not   ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
        }
        private void Button_DisplaySheet_Click(object sender, EventArgs e)
        {
            Generate_Excel_Display_Sheet();
        }
    }
}
// TESTING //
// * line 545, executescalar may give error...check
// * SearchCandidates, query for Series (line 42) ??? since in series exam, 2 branches may have same course but exams in different days