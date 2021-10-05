using OfficeOpenXml;
using OfficeOpenXml.Style;
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

        void SetLoading(bool loading)
        {
            if (loading) Panel_ProgressBar.Visible = true;
            else Panel_ProgressBar.Visible = false;
        }

        private void Form_Absentees_Load(object sender, EventArgs e)
        {
            Radio_University.Checked = true;
        }

        DataTable GetComboboxDataSourceQuery(string query,bool isRoom)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                if (isRoom)
                {
                    comm.Parameters.AddWithValue("@Date", Combobox_Marking_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Marking_Session.Text);
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
                    SetLoading(true);
                    string query = "";
                    if (Radio_Series.Checked) query = string.Format("select Seat,Roll_No,Status,Name,Class,Course,Sub_Code,Date,Session,Room_No from Series_Alloted Where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                    else query = string.Format("select Seat,Reg_No,Status,Name,Branch,Sub_Code,Course,Date,Session,Room_No from University_Alloted Where Date=@Date and Session=@Session and Room_No=@Room_No order by Seat");
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        command.Parameters.AddWithValue("@Date", Combobox_Marking_Date.Text);
                        command.Parameters.AddWithValue("@Session", Combobox_Marking_Session.Text);
                        command.Parameters.AddWithValue("@Room_No", Combobox_Marking_RoomNo.Text);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        Dgv_Marking.DataSource = table;
                    }
                    SetLoading(false);
                }
                catch (Exception ex)
                {
                    SetLoading(false);
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
                    SetLoading(true);
                    string query = "";
                    if (Radio_Series.Checked) query = string.Format("update Series_Alloted Set Status=@Status where Roll_No=@Roll_No and Name=@Name and Date=@Date and Session=@Session and Room_No=@Room_No");
                    else query = string.Format("update University_Alloted Set Status=@Status where Reg_No=@Reg_No and Name=@Name and Date=@Date and Session=@Session and Room_No=@Room_No");
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow row in Dgv_Marking.Rows)
                        {
                            if(Radio_University.Checked) comm.Parameters.AddWithValue("@Reg_No", row.Cells["Reg_No"].Value);
                            else comm.Parameters.AddWithValue("@Roll_No", row.Cells["Roll_No"].Value);
                            comm.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                            comm.Parameters.AddWithValue("@Status", row.Cells["Status"].Value);
                            comm.Parameters.AddWithValue("@Date", row.Cells["Date"].Value);
                            comm.Parameters.AddWithValue("@Session", row.Cells["Session"].Value);
                            comm.Parameters.AddWithValue("@Room_No", row.Cells["Room_No"].Value);
                            comm.ExecuteNonQuery();
                        }
                    }
                    SetLoading(false);
                    CustomMessageBox.ShowMessageBox("Status saved  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    SetLoading(false);
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        DataTable GetQueryTableData(string query)
        {
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
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
                Combobox_Statement_BranchClass.DataSource = null;
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

        int prescount = 0, abscount = 0;
        void FillCandidatesInfoLabel()
        {
            prescount = 0; abscount = 0;
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
                SetLoading(true);
                string query;
                if (Radio_University.Checked) query = string.Format("select Reg_No,Name,Status,Branch,Course,Sub_Code from University_Alloted Where Date=@Date and Session=@Session and Branch=@Branch and Sub_Code=@Sub_Code order by Reg_No");
                else query = string.Format("select Roll_No,Name,Status,Class,Course,Sub_Code from Series_Alloted Where Date=@Date and Session=@Session and Class=@Class and Sub_Code=@Sub_Code order by Roll_No");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    dbConnection.Open();
                    SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                    command.Parameters.AddWithValue("@Date", Combobox_Statement_Date.Text);
                    command.Parameters.AddWithValue("@Session", Combobox_Statement_Session.Text);
                    if(Radio_University.Checked) command.Parameters.AddWithValue("@Branch", Combobox_Statement_BranchClass.Text);
                    else command.Parameters.AddWithValue("@Class", Combobox_Statement_BranchClass.Text);
                    command.Parameters.AddWithValue("@Sub_Code", Combobox_Statement_SubCode.Text);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Dgv_Statement.DataSource = table;                    
                }
                FillCandidatesInfoLabel();
                SetLoading(false);
            }
            catch (Exception ex)
            {
                SetLoading(false);
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Prepare_Statement_Click(object sender, EventArgs e)
        {
            string savepath;
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand comm = new SQLiteCommand("Select Savepath from DBManagement where Savepath is not null");
                savepath = (string)comm.ExecuteScalar();
            }
            if (Dgv_Statement.Rows.Count != 0 && savepath != "Select Filepath")
            {
                try
                {
                    SetLoading(true);
                    string createStatePath = savepath + @"\Attendance Sheets";
                    Directory.CreateDirectory(createStatePath);

                    using (var package = new ExcelPackage())
                    {
                        //Add a new worksheet to the empty workbook
                        var worksheet = package.Workbook.Worksheets.Add(Combobox_Statement_BranchClass.Text);
                        string Yoa;
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            string query;
                            if (Radio_University.Checked) query = string.Format("select YOA from Students where Reg_No=@Reg_No");
                            else query = string.Format("select YOA from Students where Class=@Class and Roll_No=@Roll_No");
                            dbConnection.Open();
                            SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                            if(Radio_University.Checked) command.Parameters.AddWithValue("@Reg_No", Dgv_Statement.Rows[0].Cells["Reg_No"].Value.ToString());
                            else
                            {
                                command.Parameters.AddWithValue("@Class", Dgv_Statement.Rows[0].Cells["Class"].Value.ToString());
                                command.Parameters.AddWithValue("@Roll_No", Dgv_Statement.Rows[0].Cells["Roll_No"].Value.ToString());
                            }
                            Yoa = (string)command.ExecuteScalar();
                        }
                        
                        //Insert Items to ExcelSheet
                        worksheet.Cells["A1"].Value = "KMEA ENGINEERING COLLEGE";
                        worksheet.Cells["A2"].Value = Textbox_Statement_ExamName.Text;
                        worksheet.Cells["A3"].Value = "ATTENDANCE STATEMENT";
                        worksheet.Cells["A4"].Value = Combobox_Statement_Date.Text;
                        worksheet.Cells["D4"].Value = Combobox_Statement_Session.Text;
                        worksheet.Cells["A5"].Value = Combobox_Statement_BranchClass.Text;
                        worksheet.Cells["C5"].Value = "Year: " + Yoa;
                        worksheet.Cells["D5"].Value = Dgv_Statement.Rows[0].Cells["Course"].Value.ToString() + " " + Combobox_Statement_SubCode.Text;

                        using (var range = worksheet.Cells["A1:D1"])
                        {
                            range.Merge = true;
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            range.Style.Font.Name = "Arial";
                            range.Style.Font.Size = 16;
                            range.Style.Font.Bold = true;
                        }
                        using (var range = worksheet.Cells["A2:D2"])
                        {
                            range.Merge = true;
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            range.Style.Font.Name = "Arial";
                            range.Style.Font.Size = 14;
                            range.Style.Font.Bold = true;
                        }
                        using (var range = worksheet.Cells["A3:D3"])
                        {
                            range.Merge = true;
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            range.Style.Font.Name = "Arial";
                            range.Style.Font.Size = 12;
                            range.Style.Font.Bold = true;
                        }
                        using (var range = worksheet.Cells["A4:D4"])
                        {
                            range.Style.Font.Name = "Arial";
                            range.Style.Font.Size = 11;
                            range.Style.Font.Bold = true;
                        }
                        using (var range = worksheet.Cells["A5:D5"])
                        {
                            range.Style.Font.Name = "Arial";
                            range.Style.Font.Size = 11;
                            range.Style.Font.Bold = true;
                        }

                        // column headings
                        worksheet.Cells[6, 1].Value = "Sl.No";
                        worksheet.Cells[6, 1].Style.Font.Name = "Arial";
                        worksheet.Cells[6, 1].Style.Font.Size = 12;
                        worksheet.Cells[6, 1].Style.Font.Bold = true;
                        for (var i = 0; i < 3; i++)
                        {
                            worksheet.Cells[6, i + 2].Value = Dgv_Statement.Columns[i].HeaderText.ToString();
                            worksheet.Cells[6, i + 2].Style.Font.Name = "Arial";
                            worksheet.Cells[6, i + 2].Style.Font.Size = 12;
                            worksheet.Cells[6, i + 2].Style.Font.Bold = true;
                        }
                        //rows filling
                        int count = 0;
                        for (int i = 0; i < Dgv_Statement.Rows.Count; i++)
                        {
                            worksheet.Cells[i + 7, 1].Value = i + 1;    //Sl.No Filling
                            for (var j = 0; j < 3; j++)
                            {
                                worksheet.Cells[i + 7, j + 2].Value = Dgv_Statement.Rows[i].Cells[j];
                                if (Dgv_Statement.Rows[i].Cells[j].ToString() == "Absent")
                                {
                                    worksheet.Cells[i + 7, j + 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                    worksheet.Cells[i + 7, j + 2].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                                    worksheet.Cells[i + 7, j + 2].Style.Font.Color.SetColor(Color.Red);
                                }
                            }
                            count = i + 9;
                        }
                        using (var range = worksheet.Cells[7, 1, Dgv_Statement.Rows.Count + 6, 4])
                        {
                            range.AutoFitColumns();
                            range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        }
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                        worksheet.Cells[count, 3].Value = "No of Present = " + prescount;
                        worksheet.Cells[count + 1, 3].Value = "No of Absent = " + abscount;

                        //Save Excel File  
                        string path = createStatePath + @"\Attendance " + Combobox_Statement_Session.Text + " " + Combobox_Statement_SubCode.Text + " " + Combobox_Statement_BranchClass.Text + ".xlsx";
                        Stream stream = File.Create(path);
                        package.SaveAs(stream);
                        stream.Close();

                        Combobox_Statement_BranchClass.SelectedIndex = 0;
                        Combobox_Statement_SubCode.SelectedIndex = 0;
                        Label_NoOfCandidates.ResetText();
                        Label_NoOfPresent.ResetText();
                        Label_NoOfAbsent.ResetText();
                        Dgv_Statement.DataSource = null;
                        SetLoading(false);
                        CustomMessageBox.ShowMessageBox("Absentees Statement generated  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    SetLoading(false);
                    MessageBox.Show(ex.ToString());
                }
            }
            else CustomMessageBox.ShowMessageBox("Savepath may not be saved or No student records to generate statement   ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
        }
    }
}


// need loadingPanel for tab selectIndex change ????
