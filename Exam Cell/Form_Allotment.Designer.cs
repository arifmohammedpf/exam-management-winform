namespace Exam_Cell
{
    partial class Form_Allotment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Groupbox_SelectExam = new System.Windows.Forms.GroupBox();
            this.Radio_Series = new System.Windows.Forms.RadioButton();
            this.Radio_University = new System.Windows.Forms.RadioButton();
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.Tab_Allot = new System.Windows.Forms.TabPage();
            this.Dgv_Cand_in_AllotedRooms = new System.Windows.Forms.DataGridView();
            this.Label_NoOfStudents = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Combobox_Alloted_Rooms = new System.Windows.Forms.ComboBox();
            this.Button_MultiAllot = new System.Windows.Forms.Button();
            this.Button_SingleAllot = new System.Windows.Forms.Button();
            this.Dgv_RegCourseWise_Count = new System.Windows.Forms.DataGridView();
            this.Dgv_Alloted_Rooms = new System.Windows.Forms.DataGridView();
            this.Dgv_RegCandidates_List = new System.Windows.Forms.DataGridView();
            this.Label_NoOfStudents_Registered = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combobox_Session = new System.Windows.Forms.ComboBox();
            this.DateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.Tab_ExcelSheet = new System.Windows.Forms.TabPage();
            this.Button_FilepathChange = new System.Windows.Forms.Button();
            this.Button_RoomSheet = new System.Windows.Forms.Button();
            this.Button_SummarySheet = new System.Windows.Forms.Button();
            this.Button_DisplaySheet = new System.Windows.Forms.Button();
            this.Button_SignatureSheet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Textbox_Filepath = new System.Windows.Forms.TextBox();
            this.Textbox_ExamName = new System.Windows.Forms.TextBox();
            this.Tab_ShiftSwap = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Swap = new System.Windows.Forms.Button();
            this.Button_Shift = new System.Windows.Forms.Button();
            this.Combobox_To_Starting_Seat = new System.Windows.Forms.ComboBox();
            this.Combobox_To_SeriesAB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Combobox_To_RoomNo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Combobox_From_Ending_Seat = new System.Windows.Forms.ComboBox();
            this.Combobox_From_Starting_Seat = new System.Windows.Forms.ComboBox();
            this.Combobox_From_SeriesAB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Combobox_From_RoomNo = new System.Windows.Forms.ComboBox();
            this.Label_No_Of_Students_Selected = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel_ProgressBar = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Groupbox_SelectExam.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.Tab_Allot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cand_in_AllotedRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCourseWise_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Alloted_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCandidates_List)).BeginInit();
            this.Tab_ExcelSheet.SuspendLayout();
            this.Tab_ShiftSwap.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panel_ProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Panel_Header.Controls.Add(this.Button_Close);
            this.Panel_Header.Controls.Add(this.label1);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1341, 60);
            this.Panel_Header.TabIndex = 2;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(1276, 7);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(50, 46);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allotment";
            // 
            // Groupbox_SelectExam
            // 
            this.Groupbox_SelectExam.Controls.Add(this.Radio_Series);
            this.Groupbox_SelectExam.Controls.Add(this.Radio_University);
            this.Groupbox_SelectExam.Location = new System.Drawing.Point(11, 60);
            this.Groupbox_SelectExam.Margin = new System.Windows.Forms.Padding(4);
            this.Groupbox_SelectExam.Name = "Groupbox_SelectExam";
            this.Groupbox_SelectExam.Padding = new System.Windows.Forms.Padding(4);
            this.Groupbox_SelectExam.Size = new System.Drawing.Size(313, 73);
            this.Groupbox_SelectExam.TabIndex = 0;
            this.Groupbox_SelectExam.TabStop = false;
            this.Groupbox_SelectExam.Text = "Select Exam";
            // 
            // Radio_Series
            // 
            this.Radio_Series.AutoSize = true;
            this.Radio_Series.Location = new System.Drawing.Point(206, 31);
            this.Radio_Series.Margin = new System.Windows.Forms.Padding(4);
            this.Radio_Series.Name = "Radio_Series";
            this.Radio_Series.Size = new System.Drawing.Size(71, 24);
            this.Radio_Series.TabIndex = 1;
            this.Radio_Series.TabStop = true;
            this.Radio_Series.Text = "Series";
            this.Radio_Series.UseVisualStyleBackColor = true;
            this.Radio_Series.CheckedChanged += new System.EventHandler(this.Radio_Series_CheckedChanged);
            // 
            // Radio_University
            // 
            this.Radio_University.AutoSize = true;
            this.Radio_University.Location = new System.Drawing.Point(39, 31);
            this.Radio_University.Margin = new System.Windows.Forms.Padding(4);
            this.Radio_University.Name = "Radio_University";
            this.Radio_University.Size = new System.Drawing.Size(100, 24);
            this.Radio_University.TabIndex = 0;
            this.Radio_University.TabStop = true;
            this.Radio_University.Text = "University";
            this.Radio_University.UseVisualStyleBackColor = true;
            this.Radio_University.CheckedChanged += new System.EventHandler(this.Radio_University_CheckedChanged);
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.Tab_Allot);
            this.TabPanel.Controls.Add(this.Tab_ExcelSheet);
            this.TabPanel.Controls.Add(this.Tab_ShiftSwap);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabPanel.Location = new System.Drawing.Point(0, 162);
            this.TabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(1341, 738);
            this.TabPanel.TabIndex = 1;
            // 
            // Tab_Allot
            // 
            this.Tab_Allot.Controls.Add(this.Dgv_Cand_in_AllotedRooms);
            this.Tab_Allot.Controls.Add(this.Label_NoOfStudents);
            this.Tab_Allot.Controls.Add(this.label5);
            this.Tab_Allot.Controls.Add(this.Combobox_Alloted_Rooms);
            this.Tab_Allot.Controls.Add(this.Button_MultiAllot);
            this.Tab_Allot.Controls.Add(this.Button_SingleAllot);
            this.Tab_Allot.Controls.Add(this.Dgv_RegCourseWise_Count);
            this.Tab_Allot.Controls.Add(this.Dgv_Alloted_Rooms);
            this.Tab_Allot.Controls.Add(this.Dgv_RegCandidates_List);
            this.Tab_Allot.Controls.Add(this.Label_NoOfStudents_Registered);
            this.Tab_Allot.Controls.Add(this.label3);
            this.Tab_Allot.Controls.Add(this.label2);
            this.Tab_Allot.Controls.Add(this.Combobox_Session);
            this.Tab_Allot.Controls.Add(this.DateTimePicker_Date);
            this.Tab_Allot.Location = new System.Drawing.Point(4, 29);
            this.Tab_Allot.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_Allot.Name = "Tab_Allot";
            this.Tab_Allot.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_Allot.Size = new System.Drawing.Size(1333, 705);
            this.Tab_Allot.TabIndex = 0;
            this.Tab_Allot.Text = "Allot Students";
            this.Tab_Allot.UseVisualStyleBackColor = true;
            // 
            // Dgv_Cand_in_AllotedRooms
            // 
            this.Dgv_Cand_in_AllotedRooms.AllowUserToAddRows = false;
            this.Dgv_Cand_in_AllotedRooms.AllowUserToDeleteRows = false;
            this.Dgv_Cand_in_AllotedRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Cand_in_AllotedRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Cand_in_AllotedRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Cand_in_AllotedRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Cand_in_AllotedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cand_in_AllotedRooms.Location = new System.Drawing.Point(876, 95);
            this.Dgv_Cand_in_AllotedRooms.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Cand_in_AllotedRooms.Name = "Dgv_Cand_in_AllotedRooms";
            this.Dgv_Cand_in_AllotedRooms.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Cand_in_AllotedRooms.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Cand_in_AllotedRooms.RowTemplate.Height = 24;
            this.Dgv_Cand_in_AllotedRooms.Size = new System.Drawing.Size(451, 573);
            this.Dgv_Cand_in_AllotedRooms.TabIndex = 34;
            // 
            // Label_NoOfStudents
            // 
            this.Label_NoOfStudents.AutoSize = true;
            this.Label_NoOfStudents.Location = new System.Drawing.Point(929, 70);
            this.Label_NoOfStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NoOfStudents.Name = "Label_NoOfStudents";
            this.Label_NoOfStudents.Size = new System.Drawing.Size(122, 20);
            this.Label_NoOfStudents.TabIndex = 32;
            this.Label_NoOfStudents.Text = "No of Students :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(929, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Allocated Room :";
            // 
            // Combobox_Alloted_Rooms
            // 
            this.Combobox_Alloted_Rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Alloted_Rooms.FormattingEnabled = true;
            this.Combobox_Alloted_Rooms.Location = new System.Drawing.Point(1075, 20);
            this.Combobox_Alloted_Rooms.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_Alloted_Rooms.Name = "Combobox_Alloted_Rooms";
            this.Combobox_Alloted_Rooms.Size = new System.Drawing.Size(248, 28);
            this.Combobox_Alloted_Rooms.TabIndex = 4;
            this.Combobox_Alloted_Rooms.SelectedIndexChanged += new System.EventHandler(this.Combobox_Alloted_Rooms_SelectedIndexChanged);
            // 
            // Button_MultiAllot
            // 
            this.Button_MultiAllot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_MultiAllot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_MultiAllot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_MultiAllot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_MultiAllot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_MultiAllot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MultiAllot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MultiAllot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_MultiAllot.Location = new System.Drawing.Point(706, 28);
            this.Button_MultiAllot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_MultiAllot.Name = "Button_MultiAllot";
            this.Button_MultiAllot.Size = new System.Drawing.Size(125, 50);
            this.Button_MultiAllot.TabIndex = 3;
            this.Button_MultiAllot.Text = "Multi Allot";
            this.Button_MultiAllot.UseVisualStyleBackColor = false;
            this.Button_MultiAllot.Click += new System.EventHandler(this.Button_MultiAllot_Click);
            // 
            // Button_SingleAllot
            // 
            this.Button_SingleAllot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_SingleAllot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SingleAllot.FlatAppearance.BorderSize = 0;
            this.Button_SingleAllot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_SingleAllot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_SingleAllot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SingleAllot.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SingleAllot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_SingleAllot.Location = new System.Drawing.Point(561, 28);
            this.Button_SingleAllot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_SingleAllot.Name = "Button_SingleAllot";
            this.Button_SingleAllot.Size = new System.Drawing.Size(125, 50);
            this.Button_SingleAllot.TabIndex = 2;
            this.Button_SingleAllot.Text = "Single Allot";
            this.Button_SingleAllot.UseVisualStyleBackColor = false;
            this.Button_SingleAllot.Click += new System.EventHandler(this.Button_SingleAllot_Click);
            // 
            // Dgv_RegCourseWise_Count
            // 
            this.Dgv_RegCourseWise_Count.AllowUserToAddRows = false;
            this.Dgv_RegCourseWise_Count.AllowUserToDeleteRows = false;
            this.Dgv_RegCourseWise_Count.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_RegCourseWise_Count.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_RegCourseWise_Count.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_RegCourseWise_Count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_RegCourseWise_Count.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegCourseWise_Count.Location = new System.Drawing.Point(1, 374);
            this.Dgv_RegCourseWise_Count.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_RegCourseWise_Count.Name = "Dgv_RegCourseWise_Count";
            this.Dgv_RegCourseWise_Count.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_RegCourseWise_Count.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_RegCourseWise_Count.RowTemplate.Height = 24;
            this.Dgv_RegCourseWise_Count.Size = new System.Drawing.Size(481, 294);
            this.Dgv_RegCourseWise_Count.TabIndex = 3;
            // 
            // Dgv_Alloted_Rooms
            // 
            this.Dgv_Alloted_Rooms.AllowUserToAddRows = false;
            this.Dgv_Alloted_Rooms.AllowUserToDeleteRows = false;
            this.Dgv_Alloted_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Alloted_Rooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Alloted_Rooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Alloted_Rooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Alloted_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Alloted_Rooms.Location = new System.Drawing.Point(485, 95);
            this.Dgv_Alloted_Rooms.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Alloted_Rooms.Name = "Dgv_Alloted_Rooms";
            this.Dgv_Alloted_Rooms.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Alloted_Rooms.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Alloted_Rooms.RowTemplate.Height = 24;
            this.Dgv_Alloted_Rooms.Size = new System.Drawing.Size(390, 573);
            this.Dgv_Alloted_Rooms.TabIndex = 3;
            // 
            // Dgv_RegCandidates_List
            // 
            this.Dgv_RegCandidates_List.AllowUserToAddRows = false;
            this.Dgv_RegCandidates_List.AllowUserToDeleteRows = false;
            this.Dgv_RegCandidates_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_RegCandidates_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_RegCandidates_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_RegCandidates_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_RegCandidates_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegCandidates_List.Location = new System.Drawing.Point(1, 95);
            this.Dgv_RegCandidates_List.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_RegCandidates_List.Name = "Dgv_RegCandidates_List";
            this.Dgv_RegCandidates_List.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_RegCandidates_List.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_RegCandidates_List.RowTemplate.Height = 24;
            this.Dgv_RegCandidates_List.Size = new System.Drawing.Size(481, 275);
            this.Dgv_RegCandidates_List.TabIndex = 3;
            // 
            // Label_NoOfStudents_Registered
            // 
            this.Label_NoOfStudents_Registered.AutoSize = true;
            this.Label_NoOfStudents_Registered.Location = new System.Drawing.Point(10, 674);
            this.Label_NoOfStudents_Registered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_NoOfStudents_Registered.Name = "Label_NoOfStudents_Registered";
            this.Label_NoOfStudents_Registered.Size = new System.Drawing.Size(200, 20);
            this.Label_NoOfStudents_Registered.TabIndex = 2;
            this.Label_NoOfStudents_Registered.Text = "No of Students registered :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Session :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :";
            // 
            // Combobox_Session
            // 
            this.Combobox_Session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Session.FormattingEnabled = true;
            this.Combobox_Session.Items.AddRange(new object[] {
            "-Select-",
            "Forenoon",
            "Afternoon"});
            this.Combobox_Session.Location = new System.Drawing.Point(102, 52);
            this.Combobox_Session.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_Session.Name = "Combobox_Session";
            this.Combobox_Session.Size = new System.Drawing.Size(284, 28);
            this.Combobox_Session.TabIndex = 1;
            this.Combobox_Session.SelectedIndexChanged += new System.EventHandler(this.Combobox_Session_SelectedIndexChanged);
            // 
            // DateTimePicker_Date
            // 
            this.DateTimePicker_Date.Location = new System.Drawing.Point(102, 12);
            this.DateTimePicker_Date.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker_Date.Name = "DateTimePicker_Date";
            this.DateTimePicker_Date.Size = new System.Drawing.Size(284, 26);
            this.DateTimePicker_Date.TabIndex = 0;
            this.DateTimePicker_Date.ValueChanged += new System.EventHandler(this.DateTimePicker_Date_ValueChanged);
            // 
            // Tab_ExcelSheet
            // 
            this.Tab_ExcelSheet.Controls.Add(this.Button_FilepathChange);
            this.Tab_ExcelSheet.Controls.Add(this.Button_RoomSheet);
            this.Tab_ExcelSheet.Controls.Add(this.Button_SummarySheet);
            this.Tab_ExcelSheet.Controls.Add(this.Button_DisplaySheet);
            this.Tab_ExcelSheet.Controls.Add(this.Button_SignatureSheet);
            this.Tab_ExcelSheet.Controls.Add(this.label12);
            this.Tab_ExcelSheet.Controls.Add(this.Textbox_Filepath);
            this.Tab_ExcelSheet.Controls.Add(this.Textbox_ExamName);
            this.Tab_ExcelSheet.Location = new System.Drawing.Point(4, 29);
            this.Tab_ExcelSheet.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_ExcelSheet.Name = "Tab_ExcelSheet";
            this.Tab_ExcelSheet.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_ExcelSheet.Size = new System.Drawing.Size(1333, 705);
            this.Tab_ExcelSheet.TabIndex = 1;
            this.Tab_ExcelSheet.Text = "Generate Excel Sheets";
            this.Tab_ExcelSheet.UseVisualStyleBackColor = true;
            // 
            // Button_FilepathChange
            // 
            this.Button_FilepathChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_FilepathChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_FilepathChange.FlatAppearance.BorderSize = 0;
            this.Button_FilepathChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_FilepathChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_FilepathChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_FilepathChange.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_FilepathChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_FilepathChange.Location = new System.Drawing.Point(416, 657);
            this.Button_FilepathChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_FilepathChange.Name = "Button_FilepathChange";
            this.Button_FilepathChange.Size = new System.Drawing.Size(149, 39);
            this.Button_FilepathChange.TabIndex = 5;
            this.Button_FilepathChange.Text = "Change path";
            this.Button_FilepathChange.UseVisualStyleBackColor = false;
            this.Button_FilepathChange.Click += new System.EventHandler(this.Button_FilepathChange_Click);
            // 
            // Button_RoomSheet
            // 
            this.Button_RoomSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_RoomSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RoomSheet.FlatAppearance.BorderSize = 0;
            this.Button_RoomSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_RoomSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_RoomSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RoomSheet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RoomSheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_RoomSheet.Location = new System.Drawing.Point(540, 224);
            this.Button_RoomSheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_RoomSheet.Name = "Button_RoomSheet";
            this.Button_RoomSheet.Size = new System.Drawing.Size(195, 50);
            this.Button_RoomSheet.TabIndex = 1;
            this.Button_RoomSheet.Text = "Room Sheet";
            this.Button_RoomSheet.UseVisualStyleBackColor = false;
            this.Button_RoomSheet.Click += new System.EventHandler(this.Button_RoomSheet_Click);
            // 
            // Button_SummarySheet
            // 
            this.Button_SummarySheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_SummarySheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SummarySheet.FlatAppearance.BorderSize = 0;
            this.Button_SummarySheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_SummarySheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_SummarySheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SummarySheet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SummarySheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_SummarySheet.Location = new System.Drawing.Point(540, 409);
            this.Button_SummarySheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_SummarySheet.Name = "Button_SummarySheet";
            this.Button_SummarySheet.Size = new System.Drawing.Size(195, 50);
            this.Button_SummarySheet.TabIndex = 4;
            this.Button_SummarySheet.Text = "Summary Sheet";
            this.Button_SummarySheet.UseVisualStyleBackColor = false;
            // 
            // Button_DisplaySheet
            // 
            this.Button_DisplaySheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_DisplaySheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DisplaySheet.FlatAppearance.BorderSize = 0;
            this.Button_DisplaySheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_DisplaySheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_DisplaySheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DisplaySheet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DisplaySheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_DisplaySheet.Location = new System.Drawing.Point(540, 349);
            this.Button_DisplaySheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_DisplaySheet.Name = "Button_DisplaySheet";
            this.Button_DisplaySheet.Size = new System.Drawing.Size(195, 50);
            this.Button_DisplaySheet.TabIndex = 3;
            this.Button_DisplaySheet.Text = "Display Sheet";
            this.Button_DisplaySheet.UseVisualStyleBackColor = false;
            this.Button_DisplaySheet.Click += new System.EventHandler(this.Button_DisplaySheet_Click);
            // 
            // Button_SignatureSheet
            // 
            this.Button_SignatureSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_SignatureSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SignatureSheet.FlatAppearance.BorderSize = 0;
            this.Button_SignatureSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_SignatureSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_SignatureSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SignatureSheet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SignatureSheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_SignatureSheet.Location = new System.Drawing.Point(540, 288);
            this.Button_SignatureSheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_SignatureSheet.Name = "Button_SignatureSheet";
            this.Button_SignatureSheet.Size = new System.Drawing.Size(195, 50);
            this.Button_SignatureSheet.TabIndex = 2;
            this.Button_SignatureSheet.Text = "Signature Sheet";
            this.Button_SignatureSheet.UseVisualStyleBackColor = false;
            this.Button_SignatureSheet.Click += new System.EventHandler(this.Button_SignatureSheet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(432, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Examination Name :";
            // 
            // Textbox_Filepath
            // 
            this.Textbox_Filepath.Location = new System.Drawing.Point(8, 662);
            this.Textbox_Filepath.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_Filepath.Name = "Textbox_Filepath";
            this.Textbox_Filepath.Size = new System.Drawing.Size(400, 26);
            this.Textbox_Filepath.TabIndex = 0;
            // 
            // Textbox_ExamName
            // 
            this.Textbox_ExamName.Location = new System.Drawing.Point(438, 166);
            this.Textbox_ExamName.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_ExamName.Name = "Textbox_ExamName";
            this.Textbox_ExamName.Size = new System.Drawing.Size(400, 26);
            this.Textbox_ExamName.TabIndex = 0;
            // 
            // Tab_ShiftSwap
            // 
            this.Tab_ShiftSwap.Controls.Add(this.groupBox3);
            this.Tab_ShiftSwap.Controls.Add(this.groupBox2);
            this.Tab_ShiftSwap.Controls.Add(this.label6);
            this.Tab_ShiftSwap.Location = new System.Drawing.Point(4, 29);
            this.Tab_ShiftSwap.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_ShiftSwap.Name = "Tab_ShiftSwap";
            this.Tab_ShiftSwap.Size = new System.Drawing.Size(1333, 728);
            this.Tab_ShiftSwap.TabIndex = 2;
            this.Tab_ShiftSwap.Text = "Shift/Swap Students";
            this.Tab_ShiftSwap.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Swap);
            this.groupBox3.Controls.Add(this.Button_Shift);
            this.groupBox3.Controls.Add(this.Combobox_To_Starting_Seat);
            this.groupBox3.Controls.Add(this.Combobox_To_SeriesAB);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Combobox_To_RoomNo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(715, 156);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(412, 269);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To";
            // 
            // Button_Swap
            // 
            this.Button_Swap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Swap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Swap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Swap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Swap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Swap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Swap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Swap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Swap.Location = new System.Drawing.Point(236, 202);
            this.Button_Swap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Swap.Name = "Button_Swap";
            this.Button_Swap.Size = new System.Drawing.Size(125, 50);
            this.Button_Swap.TabIndex = 4;
            this.Button_Swap.Text = "Swap";
            this.Button_Swap.UseVisualStyleBackColor = false;
            this.Button_Swap.Click += new System.EventHandler(this.Button_Swap_Click);
            // 
            // Button_Shift
            // 
            this.Button_Shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Shift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Shift.FlatAppearance.BorderSize = 0;
            this.Button_Shift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Shift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Shift.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Shift.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Shift.Location = new System.Drawing.Point(61, 202);
            this.Button_Shift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Shift.Name = "Button_Shift";
            this.Button_Shift.Size = new System.Drawing.Size(125, 50);
            this.Button_Shift.TabIndex = 3;
            this.Button_Shift.Text = "Shift";
            this.Button_Shift.UseVisualStyleBackColor = false;
            this.Button_Shift.Click += new System.EventHandler(this.Button_Shift_Click);
            // 
            // Combobox_To_Starting_Seat
            // 
            this.Combobox_To_Starting_Seat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_To_Starting_Seat.FormattingEnabled = true;
            this.Combobox_To_Starting_Seat.Location = new System.Drawing.Point(226, 140);
            this.Combobox_To_Starting_Seat.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_To_Starting_Seat.Name = "Combobox_To_Starting_Seat";
            this.Combobox_To_Starting_Seat.Size = new System.Drawing.Size(134, 28);
            this.Combobox_To_Starting_Seat.TabIndex = 2;
            // 
            // Combobox_To_SeriesAB
            // 
            this.Combobox_To_SeriesAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_To_SeriesAB.FormattingEnabled = true;
            this.Combobox_To_SeriesAB.Items.AddRange(new object[] {
            "-Select-",
            "A",
            "B"});
            this.Combobox_To_SeriesAB.Location = new System.Drawing.Point(226, 90);
            this.Combobox_To_SeriesAB.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_To_SeriesAB.Name = "Combobox_To_SeriesAB";
            this.Combobox_To_SeriesAB.Size = new System.Drawing.Size(134, 28);
            this.Combobox_To_SeriesAB.TabIndex = 1;
            this.Combobox_To_SeriesAB.SelectedIndexChanged += new System.EventHandler(this.Combobox_To_SeriesAB_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 95);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Series :";
            // 
            // Combobox_To_RoomNo
            // 
            this.Combobox_To_RoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_To_RoomNo.FormattingEnabled = true;
            this.Combobox_To_RoomNo.Location = new System.Drawing.Point(226, 40);
            this.Combobox_To_RoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_To_RoomNo.Name = "Combobox_To_RoomNo";
            this.Combobox_To_RoomNo.Size = new System.Drawing.Size(134, 28);
            this.Combobox_To_RoomNo.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 145);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Starting seat no :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 45);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Room No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Combobox_From_Ending_Seat);
            this.groupBox2.Controls.Add(this.Combobox_From_Starting_Seat);
            this.groupBox2.Controls.Add(this.Combobox_From_SeriesAB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Combobox_From_RoomNo);
            this.groupBox2.Controls.Add(this.Label_No_Of_Students_Selected);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(190, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(412, 269);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // Combobox_From_Ending_Seat
            // 
            this.Combobox_From_Ending_Seat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_From_Ending_Seat.FormattingEnabled = true;
            this.Combobox_From_Ending_Seat.Location = new System.Drawing.Point(231, 188);
            this.Combobox_From_Ending_Seat.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_From_Ending_Seat.Name = "Combobox_From_Ending_Seat";
            this.Combobox_From_Ending_Seat.Size = new System.Drawing.Size(134, 28);
            this.Combobox_From_Ending_Seat.TabIndex = 3;
            this.Combobox_From_Ending_Seat.SelectedIndexChanged += new System.EventHandler(this.Combobox_From_Ending_Seat_SelectedIndexChanged);
            // 
            // Combobox_From_Starting_Seat
            // 
            this.Combobox_From_Starting_Seat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_From_Starting_Seat.FormattingEnabled = true;
            this.Combobox_From_Starting_Seat.Location = new System.Drawing.Point(231, 139);
            this.Combobox_From_Starting_Seat.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_From_Starting_Seat.Name = "Combobox_From_Starting_Seat";
            this.Combobox_From_Starting_Seat.Size = new System.Drawing.Size(134, 28);
            this.Combobox_From_Starting_Seat.TabIndex = 2;
            this.Combobox_From_Starting_Seat.SelectedIndexChanged += new System.EventHandler(this.Combobox_From_Starting_Seat_SelectedIndexChanged);
            // 
            // Combobox_From_SeriesAB
            // 
            this.Combobox_From_SeriesAB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_From_SeriesAB.FormattingEnabled = true;
            this.Combobox_From_SeriesAB.Items.AddRange(new object[] {
            "-Select-",
            "A",
            "B"});
            this.Combobox_From_SeriesAB.Location = new System.Drawing.Point(231, 90);
            this.Combobox_From_SeriesAB.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_From_SeriesAB.Name = "Combobox_From_SeriesAB";
            this.Combobox_From_SeriesAB.Size = new System.Drawing.Size(134, 28);
            this.Combobox_From_SeriesAB.TabIndex = 1;
            this.Combobox_From_SeriesAB.SelectedIndexChanged += new System.EventHandler(this.Combobox_From_SeriesAB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Series :";
            // 
            // Combobox_From_RoomNo
            // 
            this.Combobox_From_RoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_From_RoomNo.FormattingEnabled = true;
            this.Combobox_From_RoomNo.Location = new System.Drawing.Point(231, 41);
            this.Combobox_From_RoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_From_RoomNo.Name = "Combobox_From_RoomNo";
            this.Combobox_From_RoomNo.Size = new System.Drawing.Size(134, 28);
            this.Combobox_From_RoomNo.TabIndex = 0;
            // 
            // Label_No_Of_Students_Selected
            // 
            this.Label_No_Of_Students_Selected.AutoSize = true;
            this.Label_No_Of_Students_Selected.Location = new System.Drawing.Point(8, 244);
            this.Label_No_Of_Students_Selected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_No_Of_Students_Selected.Name = "Label_No_Of_Students_Selected";
            this.Label_No_Of_Students_Selected.Size = new System.Drawing.Size(189, 20);
            this.Label_No_Of_Students_Selected.TabIndex = 0;
            this.Label_No_Of_Students_Selected.Text = "No of students selected :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 192);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ending seat no :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Starting seat no :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Room No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Note : Select Date and Session from \"Allot Students\" Tab";
            // 
            // Panel_ProgressBar
            // 
            this.Panel_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Panel_ProgressBar.Controls.Add(this.label4);
            this.Panel_ProgressBar.Location = new System.Drawing.Point(476, 478);
            this.Panel_ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_ProgressBar.Name = "Panel_ProgressBar";
            this.Panel_ProgressBar.Size = new System.Drawing.Size(388, 46);
            this.Panel_ProgressBar.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(122, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Please Wait !";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Allotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1341, 900);
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.Groupbox_SelectExam);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_ProgressBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Allotment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Allotment";
            this.Load += new System.EventHandler(this.Form_Allotment_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Groupbox_SelectExam.ResumeLayout(false);
            this.Groupbox_SelectExam.PerformLayout();
            this.TabPanel.ResumeLayout(false);
            this.Tab_Allot.ResumeLayout(false);
            this.Tab_Allot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cand_in_AllotedRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCourseWise_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Alloted_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCandidates_List)).EndInit();
            this.Tab_ExcelSheet.ResumeLayout(false);
            this.Tab_ExcelSheet.PerformLayout();
            this.Tab_ShiftSwap.ResumeLayout(false);
            this.Tab_ShiftSwap.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panel_ProgressBar.ResumeLayout(false);
            this.Panel_ProgressBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.GroupBox Groupbox_SelectExam;
        private System.Windows.Forms.RadioButton Radio_Series;
        private System.Windows.Forms.RadioButton Radio_University;
        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage Tab_Allot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combobox_Session;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Date;
        private System.Windows.Forms.TabPage Tab_ExcelSheet;
        private System.Windows.Forms.TabPage Tab_ShiftSwap;
        private System.Windows.Forms.DataGridView Dgv_RegCourseWise_Count;
        private System.Windows.Forms.DataGridView Dgv_Alloted_Rooms;
        private System.Windows.Forms.DataGridView Dgv_RegCandidates_List;
        private System.Windows.Forms.Label Label_NoOfStudents_Registered;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Combobox_To_RoomNo;
        private System.Windows.Forms.ComboBox Combobox_From_RoomNo;
        private System.Windows.Forms.Button Button_Shift;
        private System.Windows.Forms.Button Button_RoomSheet;
        private System.Windows.Forms.Button Button_DisplaySheet;
        private System.Windows.Forms.Button Button_SignatureSheet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Textbox_ExamName;
        private System.Windows.Forms.Button Button_MultiAllot;
        private System.Windows.Forms.Button Button_SingleAllot;
        private System.Windows.Forms.Button Button_Swap;
        private System.Windows.Forms.Button Button_SummarySheet;
        private System.Windows.Forms.DataGridView Dgv_Cand_in_AllotedRooms;
        private System.Windows.Forms.Label Label_NoOfStudents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Combobox_Alloted_Rooms;
        private System.Windows.Forms.Button Button_FilepathChange;
        private System.Windows.Forms.TextBox Textbox_Filepath;
        private System.Windows.Forms.Panel Panel_ProgressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Combobox_To_Starting_Seat;
        private System.Windows.Forms.ComboBox Combobox_To_SeriesAB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Combobox_From_Ending_Seat;
        private System.Windows.Forms.ComboBox Combobox_From_Starting_Seat;
        private System.Windows.Forms.ComboBox Combobox_From_SeriesAB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label_No_Of_Students_Selected;
        private System.Windows.Forms.Label label6;
    }
}