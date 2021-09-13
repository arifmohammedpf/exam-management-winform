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
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_Series = new System.Windows.Forms.RadioButton();
            this.Radio_University = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Allot = new System.Windows.Forms.TabPage();
            this.Dgv_RegCourseWise_Count = new System.Windows.Forms.DataGridView();
            this.Dgv_Alloted_Rooms = new System.Windows.Forms.DataGridView();
            this.Dgv_RegCandidates_List = new System.Windows.Forms.DataGridView();
            this.Label_NoOfStudents_Registered = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combobox_Session = new System.Windows.Forms.ComboBox();
            this.DateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.Tab_ExcelSheet = new System.Windows.Forms.TabPage();
            this.Button_RoomSheet = new System.Windows.Forms.Button();
            this.Button_DisplaySheet = new System.Windows.Forms.Button();
            this.Button_SignatureSheet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Textbox_ExamName = new System.Windows.Forms.TextBox();
            this.Tab_ShiftSwap = new System.Windows.Forms.TabPage();
            this.Button_Shift = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Combobox_To_RoomNo = new System.Windows.Forms.ComboBox();
            this.Combobox_To_SeriesAB = new System.Windows.Forms.ComboBox();
            this.Textbox_To_StartSeat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Combobox_From_RoomNo = new System.Windows.Forms.ComboBox();
            this.Combobox_From_SeriesAB = new System.Windows.Forms.ComboBox();
            this.Textbox_From_EndSeat = new System.Windows.Forms.TextBox();
            this.Textbox_From_StartSeat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_MultiAllot = new System.Windows.Forms.Button();
            this.Button_SingleAllot = new System.Windows.Forms.Button();
            this.Button_Swap = new System.Windows.Forms.Button();
            this.Button_SummarySheet = new System.Windows.Forms.Button();
            this.Dgv_Cand_in_AllotedRooms = new System.Windows.Forms.DataGridView();
            this.Label_NoOfStudents = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Combobox_Alloted_Rooms = new System.Windows.Forms.ComboBox();
            this.Textbox_Filepath = new System.Windows.Forms.TextBox();
            this.Button_FilepathChange = new System.Windows.Forms.Button();
            this.Panel_Header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Tab_Allot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCourseWise_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Alloted_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCandidates_List)).BeginInit();
            this.Tab_ExcelSheet.SuspendLayout();
            this.Tab_ShiftSwap.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cand_in_AllotedRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Panel_Header.Controls.Add(this.Button_Close);
            this.Panel_Header.Controls.Add(this.label1);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1073, 55);
            this.Panel_Header.TabIndex = 3;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(1021, 9);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(40, 37);
            this.Button_Close.TabIndex = 5;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allotment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_Series);
            this.groupBox1.Controls.Add(this.Radio_University);
            this.groupBox1.Location = new System.Drawing.Point(9, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 77);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Exam";
            // 
            // Radio_Series
            // 
            this.Radio_Series.AutoSize = true;
            this.Radio_Series.Location = new System.Drawing.Point(165, 32);
            this.Radio_Series.Name = "Radio_Series";
            this.Radio_Series.Size = new System.Drawing.Size(61, 21);
            this.Radio_Series.TabIndex = 5;
            this.Radio_Series.TabStop = true;
            this.Radio_Series.Text = "Series";
            this.Radio_Series.UseVisualStyleBackColor = true;
            // 
            // Radio_University
            // 
            this.Radio_University.AutoSize = true;
            this.Radio_University.Location = new System.Drawing.Point(31, 32);
            this.Radio_University.Name = "Radio_University";
            this.Radio_University.Size = new System.Drawing.Size(83, 21);
            this.Radio_University.TabIndex = 5;
            this.Radio_University.TabStop = true;
            this.Radio_University.Text = "University";
            this.Radio_University.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Allot);
            this.tabControl1.Controls.Add(this.Tab_ExcelSheet);
            this.tabControl1.Controls.Add(this.Tab_ShiftSwap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 609);
            this.tabControl1.TabIndex = 13;
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
            this.Tab_Allot.Location = new System.Drawing.Point(4, 26);
            this.Tab_Allot.Name = "Tab_Allot";
            this.Tab_Allot.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Allot.Size = new System.Drawing.Size(1065, 579);
            this.Tab_Allot.TabIndex = 0;
            this.Tab_Allot.Text = "Allot Students";
            this.Tab_Allot.UseVisualStyleBackColor = true;
            // 
            // Dgv_RegCourseWise_Count
            // 
            this.Dgv_RegCourseWise_Count.AllowUserToAddRows = false;
            this.Dgv_RegCourseWise_Count.AllowUserToDeleteRows = false;
            this.Dgv_RegCourseWise_Count.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_RegCourseWise_Count.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegCourseWise_Count.Location = new System.Drawing.Point(1, 299);
            this.Dgv_RegCourseWise_Count.Name = "Dgv_RegCourseWise_Count";
            this.Dgv_RegCourseWise_Count.RowTemplate.Height = 24;
            this.Dgv_RegCourseWise_Count.Size = new System.Drawing.Size(385, 249);
            this.Dgv_RegCourseWise_Count.TabIndex = 3;
            // 
            // Dgv_Alloted_Rooms
            // 
            this.Dgv_Alloted_Rooms.AllowUserToAddRows = false;
            this.Dgv_Alloted_Rooms.AllowUserToDeleteRows = false;
            this.Dgv_Alloted_Rooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Alloted_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Alloted_Rooms.Location = new System.Drawing.Point(388, 76);
            this.Dgv_Alloted_Rooms.Name = "Dgv_Alloted_Rooms";
            this.Dgv_Alloted_Rooms.RowTemplate.Height = 24;
            this.Dgv_Alloted_Rooms.Size = new System.Drawing.Size(312, 472);
            this.Dgv_Alloted_Rooms.TabIndex = 3;
            // 
            // Dgv_RegCandidates_List
            // 
            this.Dgv_RegCandidates_List.AllowUserToAddRows = false;
            this.Dgv_RegCandidates_List.AllowUserToDeleteRows = false;
            this.Dgv_RegCandidates_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_RegCandidates_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_RegCandidates_List.Location = new System.Drawing.Point(1, 76);
            this.Dgv_RegCandidates_List.Name = "Dgv_RegCandidates_List";
            this.Dgv_RegCandidates_List.RowTemplate.Height = 24;
            this.Dgv_RegCandidates_List.Size = new System.Drawing.Size(385, 220);
            this.Dgv_RegCandidates_List.TabIndex = 3;
            // 
            // Label_NoOfStudents_Registered
            // 
            this.Label_NoOfStudents_Registered.AutoSize = true;
            this.Label_NoOfStudents_Registered.Location = new System.Drawing.Point(8, 551);
            this.Label_NoOfStudents_Registered.Name = "Label_NoOfStudents_Registered";
            this.Label_NoOfStudents_Registered.Size = new System.Drawing.Size(165, 17);
            this.Label_NoOfStudents_Registered.TabIndex = 2;
            this.Label_NoOfStudents_Registered.Text = "No of Students registered :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Session :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :";
            // 
            // Combobox_Session
            // 
            this.Combobox_Session.FormattingEnabled = true;
            this.Combobox_Session.Items.AddRange(new object[] {
            "-Select-",
            "Forenoon",
            "Afternoon"});
            this.Combobox_Session.Location = new System.Drawing.Point(82, 42);
            this.Combobox_Session.Name = "Combobox_Session";
            this.Combobox_Session.Size = new System.Drawing.Size(228, 25);
            this.Combobox_Session.TabIndex = 1;
            this.Combobox_Session.SelectedIndexChanged += new System.EventHandler(this.Combobox_Session_SelectedIndexChanged);
            // 
            // DateTimePicker_Date
            // 
            this.DateTimePicker_Date.Location = new System.Drawing.Point(82, 10);
            this.DateTimePicker_Date.Name = "DateTimePicker_Date";
            this.DateTimePicker_Date.Size = new System.Drawing.Size(228, 22);
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
            this.Tab_ExcelSheet.Location = new System.Drawing.Point(4, 26);
            this.Tab_ExcelSheet.Name = "Tab_ExcelSheet";
            this.Tab_ExcelSheet.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_ExcelSheet.Size = new System.Drawing.Size(1065, 579);
            this.Tab_ExcelSheet.TabIndex = 1;
            this.Tab_ExcelSheet.Text = "Generate Excel Sheets";
            this.Tab_ExcelSheet.UseVisualStyleBackColor = true;
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
            this.Button_RoomSheet.Location = new System.Drawing.Point(432, 179);
            this.Button_RoomSheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_RoomSheet.Name = "Button_RoomSheet";
            this.Button_RoomSheet.Size = new System.Drawing.Size(156, 40);
            this.Button_RoomSheet.TabIndex = 31;
            this.Button_RoomSheet.Text = "Room Sheet";
            this.Button_RoomSheet.UseVisualStyleBackColor = false;
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
            this.Button_DisplaySheet.Location = new System.Drawing.Point(432, 279);
            this.Button_DisplaySheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_DisplaySheet.Name = "Button_DisplaySheet";
            this.Button_DisplaySheet.Size = new System.Drawing.Size(156, 40);
            this.Button_DisplaySheet.TabIndex = 31;
            this.Button_DisplaySheet.Text = "Display Sheet";
            this.Button_DisplaySheet.UseVisualStyleBackColor = false;
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
            this.Button_SignatureSheet.Location = new System.Drawing.Point(432, 230);
            this.Button_SignatureSheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SignatureSheet.Name = "Button_SignatureSheet";
            this.Button_SignatureSheet.Size = new System.Drawing.Size(156, 40);
            this.Button_SignatureSheet.TabIndex = 31;
            this.Button_SignatureSheet.Text = "Signature Sheet";
            this.Button_SignatureSheet.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Examination Name :";
            // 
            // Textbox_ExamName
            // 
            this.Textbox_ExamName.Location = new System.Drawing.Point(350, 133);
            this.Textbox_ExamName.Name = "Textbox_ExamName";
            this.Textbox_ExamName.Size = new System.Drawing.Size(321, 22);
            this.Textbox_ExamName.TabIndex = 0;
            // 
            // Tab_ShiftSwap
            // 
            this.Tab_ShiftSwap.Controls.Add(this.Button_Swap);
            this.Tab_ShiftSwap.Controls.Add(this.Button_Shift);
            this.Tab_ShiftSwap.Controls.Add(this.groupBox3);
            this.Tab_ShiftSwap.Controls.Add(this.groupBox2);
            this.Tab_ShiftSwap.Location = new System.Drawing.Point(4, 26);
            this.Tab_ShiftSwap.Name = "Tab_ShiftSwap";
            this.Tab_ShiftSwap.Size = new System.Drawing.Size(1065, 579);
            this.Tab_ShiftSwap.TabIndex = 2;
            this.Tab_ShiftSwap.Text = "Shift/Swap Students";
            this.Tab_ShiftSwap.UseVisualStyleBackColor = true;
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
            this.Button_Shift.Location = new System.Drawing.Point(417, 285);
            this.Button_Shift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Shift.Name = "Button_Shift";
            this.Button_Shift.Size = new System.Drawing.Size(100, 40);
            this.Button_Shift.TabIndex = 30;
            this.Button_Shift.Text = "Shift";
            this.Button_Shift.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Combobox_To_RoomNo);
            this.groupBox3.Controls.Add(this.Combobox_To_SeriesAB);
            this.groupBox3.Controls.Add(this.Textbox_To_StartSeat);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(572, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 152);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To";
            // 
            // Combobox_To_RoomNo
            // 
            this.Combobox_To_RoomNo.FormattingEnabled = true;
            this.Combobox_To_RoomNo.Location = new System.Drawing.Point(146, 30);
            this.Combobox_To_RoomNo.Name = "Combobox_To_RoomNo";
            this.Combobox_To_RoomNo.Size = new System.Drawing.Size(108, 25);
            this.Combobox_To_RoomNo.TabIndex = 1;
            // 
            // Combobox_To_SeriesAB
            // 
            this.Combobox_To_SeriesAB.FormattingEnabled = true;
            this.Combobox_To_SeriesAB.Location = new System.Drawing.Point(146, 98);
            this.Combobox_To_SeriesAB.Name = "Combobox_To_SeriesAB";
            this.Combobox_To_SeriesAB.Size = new System.Drawing.Size(108, 25);
            this.Combobox_To_SeriesAB.TabIndex = 1;
            // 
            // Textbox_To_StartSeat
            // 
            this.Textbox_To_StartSeat.Location = new System.Drawing.Point(146, 65);
            this.Textbox_To_StartSeat.Name = "Textbox_To_StartSeat";
            this.Textbox_To_StartSeat.Size = new System.Drawing.Size(108, 22);
            this.Textbox_To_StartSeat.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Series :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Starting seat no :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Room No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Combobox_From_RoomNo);
            this.groupBox2.Controls.Add(this.Combobox_From_SeriesAB);
            this.groupBox2.Controls.Add(this.Textbox_From_EndSeat);
            this.groupBox2.Controls.Add(this.Textbox_From_StartSeat);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(192, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 183);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From";
            // 
            // Combobox_From_RoomNo
            // 
            this.Combobox_From_RoomNo.FormattingEnabled = true;
            this.Combobox_From_RoomNo.Location = new System.Drawing.Point(152, 33);
            this.Combobox_From_RoomNo.Name = "Combobox_From_RoomNo";
            this.Combobox_From_RoomNo.Size = new System.Drawing.Size(108, 25);
            this.Combobox_From_RoomNo.TabIndex = 1;
            // 
            // Combobox_From_SeriesAB
            // 
            this.Combobox_From_SeriesAB.FormattingEnabled = true;
            this.Combobox_From_SeriesAB.Location = new System.Drawing.Point(152, 131);
            this.Combobox_From_SeriesAB.Name = "Combobox_From_SeriesAB";
            this.Combobox_From_SeriesAB.Size = new System.Drawing.Size(108, 25);
            this.Combobox_From_SeriesAB.TabIndex = 1;
            // 
            // Textbox_From_EndSeat
            // 
            this.Textbox_From_EndSeat.Location = new System.Drawing.Point(152, 99);
            this.Textbox_From_EndSeat.Name = "Textbox_From_EndSeat";
            this.Textbox_From_EndSeat.Size = new System.Drawing.Size(108, 22);
            this.Textbox_From_EndSeat.TabIndex = 1;
            // 
            // Textbox_From_StartSeat
            // 
            this.Textbox_From_StartSeat.Location = new System.Drawing.Point(152, 67);
            this.Textbox_From_StartSeat.Name = "Textbox_From_StartSeat";
            this.Textbox_From_StartSeat.Size = new System.Drawing.Size(108, 22);
            this.Textbox_From_StartSeat.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Series :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ending seat no :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Starting seat no :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Room No :";
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
            this.Button_MultiAllot.Location = new System.Drawing.Point(565, 22);
            this.Button_MultiAllot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_MultiAllot.Name = "Button_MultiAllot";
            this.Button_MultiAllot.Size = new System.Drawing.Size(100, 40);
            this.Button_MultiAllot.TabIndex = 29;
            this.Button_MultiAllot.Text = "Multi Allot";
            this.Button_MultiAllot.UseVisualStyleBackColor = false;
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
            this.Button_SingleAllot.Location = new System.Drawing.Point(449, 22);
            this.Button_SingleAllot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SingleAllot.Name = "Button_SingleAllot";
            this.Button_SingleAllot.Size = new System.Drawing.Size(100, 40);
            this.Button_SingleAllot.TabIndex = 30;
            this.Button_SingleAllot.Text = "Single Allot";
            this.Button_SingleAllot.UseVisualStyleBackColor = false;
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
            this.Button_Swap.Location = new System.Drawing.Point(552, 285);
            this.Button_Swap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Swap.Name = "Button_Swap";
            this.Button_Swap.Size = new System.Drawing.Size(100, 40);
            this.Button_Swap.TabIndex = 31;
            this.Button_Swap.Text = "Swap";
            this.Button_Swap.UseVisualStyleBackColor = false;
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
            this.Button_SummarySheet.Location = new System.Drawing.Point(432, 327);
            this.Button_SummarySheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_SummarySheet.Name = "Button_SummarySheet";
            this.Button_SummarySheet.Size = new System.Drawing.Size(156, 40);
            this.Button_SummarySheet.TabIndex = 31;
            this.Button_SummarySheet.Text = "Summary Sheet";
            this.Button_SummarySheet.UseVisualStyleBackColor = false;
            // 
            // Dgv_Cand_in_AllotedRooms
            // 
            this.Dgv_Cand_in_AllotedRooms.AllowUserToAddRows = false;
            this.Dgv_Cand_in_AllotedRooms.AllowUserToDeleteRows = false;
            this.Dgv_Cand_in_AllotedRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Cand_in_AllotedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cand_in_AllotedRooms.Location = new System.Drawing.Point(701, 76);
            this.Dgv_Cand_in_AllotedRooms.Name = "Dgv_Cand_in_AllotedRooms";
            this.Dgv_Cand_in_AllotedRooms.RowTemplate.Height = 24;
            this.Dgv_Cand_in_AllotedRooms.Size = new System.Drawing.Size(361, 472);
            this.Dgv_Cand_in_AllotedRooms.TabIndex = 34;
            // 
            // Label_NoOfStudents
            // 
            this.Label_NoOfStudents.AutoSize = true;
            this.Label_NoOfStudents.Location = new System.Drawing.Point(743, 56);
            this.Label_NoOfStudents.Name = "Label_NoOfStudents";
            this.Label_NoOfStudents.Size = new System.Drawing.Size(101, 17);
            this.Label_NoOfStudents.TabIndex = 32;
            this.Label_NoOfStudents.Text = "No of Students :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Allocated Room :";
            // 
            // Combobox_Alloted_Rooms
            // 
            this.Combobox_Alloted_Rooms.FormattingEnabled = true;
            this.Combobox_Alloted_Rooms.Location = new System.Drawing.Point(860, 16);
            this.Combobox_Alloted_Rooms.Name = "Combobox_Alloted_Rooms";
            this.Combobox_Alloted_Rooms.Size = new System.Drawing.Size(199, 25);
            this.Combobox_Alloted_Rooms.TabIndex = 31;
            // 
            // Textbox_Filepath
            // 
            this.Textbox_Filepath.Location = new System.Drawing.Point(6, 543);
            this.Textbox_Filepath.Name = "Textbox_Filepath";
            this.Textbox_Filepath.Size = new System.Drawing.Size(321, 22);
            this.Textbox_Filepath.TabIndex = 0;
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
            this.Button_FilepathChange.Location = new System.Drawing.Point(333, 539);
            this.Button_FilepathChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_FilepathChange.Name = "Button_FilepathChange";
            this.Button_FilepathChange.Size = new System.Drawing.Size(119, 31);
            this.Button_FilepathChange.TabIndex = 31;
            this.Button_FilepathChange.Text = "Change path";
            this.Button_FilepathChange.UseVisualStyleBackColor = false;
            // 
            // Form_Allotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1073, 754);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Allotment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Allotment";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Tab_Allot.ResumeLayout(false);
            this.Tab_Allot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCourseWise_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Alloted_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_RegCandidates_List)).EndInit();
            this.Tab_ExcelSheet.ResumeLayout(false);
            this.Tab_ExcelSheet.PerformLayout();
            this.Tab_ShiftSwap.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cand_in_AllotedRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_Series;
        private System.Windows.Forms.RadioButton Radio_University;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Combobox_To_RoomNo;
        private System.Windows.Forms.ComboBox Combobox_To_SeriesAB;
        private System.Windows.Forms.TextBox Textbox_To_StartSeat;
        private System.Windows.Forms.ComboBox Combobox_From_RoomNo;
        private System.Windows.Forms.ComboBox Combobox_From_SeriesAB;
        private System.Windows.Forms.TextBox Textbox_From_EndSeat;
        private System.Windows.Forms.TextBox Textbox_From_StartSeat;
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
    }
}