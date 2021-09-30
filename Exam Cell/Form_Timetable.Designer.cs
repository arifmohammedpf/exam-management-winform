namespace Exam_Cell
{
    partial class Form_Timetable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.HeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.Dgv_Timetable = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn_Timetable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dgv_Courses = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn_Course = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Textbox_ExamCode_Search_Timetable = new System.Windows.Forms.TextBox();
            this.Radio_DateWiseSearch = new System.Windows.Forms.RadioButton();
            this.Combobox_Branch_Search_Timetable = new System.Windows.Forms.ComboBox();
            this.Radio_BranchWiseSearch = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.DateTimePicker_Search_Timetable = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Combobox_Session = new System.Windows.Forms.ComboBox();
            this.DateTimePicker_Add_Timetable = new System.Windows.Forms.DateTimePicker();
            this.GroupBox_Exam_Mode = new System.Windows.Forms.GroupBox();
            this.Textbox_ExamCode_Search_Course = new System.Windows.Forms.TextBox();
            this.Combobox_Semester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Combobox_Branch_Search_Course = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Button_Undo = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Courses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GroupBox_Exam_Mode.SuspendLayout();
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
            this.Panel_Header.Size = new System.Drawing.Size(1415, 69);
            this.Panel_Header.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(68)))), ((int)(((byte)(148)))));
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(1359, 11);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(50, 46);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timetable";
            // 
            // Panel_Body
            // 
            this.Panel_Body.Controls.Add(this.HeaderCheckBox);
            this.Panel_Body.Controls.Add(this.Dgv_Timetable);
            this.Panel_Body.Controls.Add(this.Dgv_Courses);
            this.Panel_Body.Controls.Add(this.groupBox1);
            this.Panel_Body.Controls.Add(this.Combobox_Session);
            this.Panel_Body.Controls.Add(this.DateTimePicker_Add_Timetable);
            this.Panel_Body.Controls.Add(this.GroupBox_Exam_Mode);
            this.Panel_Body.Controls.Add(this.Button_Undo);
            this.Panel_Body.Controls.Add(this.Button_Clear);
            this.Panel_Body.Controls.Add(this.Button_Add);
            this.Panel_Body.Controls.Add(this.label2);
            this.Panel_Body.Controls.Add(this.label6);
            this.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Body.Location = new System.Drawing.Point(0, 69);
            this.Panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1415, 817);
            this.Panel_Body.TabIndex = 0;
            // 
            // HeaderCheckBox
            // 
            this.HeaderCheckBox.AutoSize = true;
            this.HeaderCheckBox.Location = new System.Drawing.Point(19, 392);
            this.HeaderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderCheckBox.Name = "HeaderCheckBox";
            this.HeaderCheckBox.Size = new System.Drawing.Size(18, 17);
            this.HeaderCheckBox.TabIndex = 8;
            this.HeaderCheckBox.UseVisualStyleBackColor = true;
            this.HeaderCheckBox.CheckedChanged += new System.EventHandler(this.HeaderCheckBox_CheckedChanged);
            // 
            // Dgv_Timetable
            // 
            this.Dgv_Timetable.AllowUserToAddRows = false;
            this.Dgv_Timetable.AllowUserToDeleteRows = false;
            this.Dgv_Timetable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dgv_Timetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Timetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Timetable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Timetable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn_Timetable});
            this.Dgv_Timetable.Location = new System.Drawing.Point(4, 390);
            this.Dgv_Timetable.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Timetable.Name = "Dgv_Timetable";
            this.Dgv_Timetable.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Timetable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Timetable.RowTemplate.Height = 24;
            this.Dgv_Timetable.Size = new System.Drawing.Size(950, 423);
            this.Dgv_Timetable.TabIndex = 9;
            this.Dgv_Timetable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Timetable_CellEndEdit);
            this.Dgv_Timetable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Timetable_CellMouseUp);
            // 
            // CheckBoxColumn_Timetable
            // 
            this.CheckBoxColumn_Timetable.HeaderText = "";
            this.CheckBoxColumn_Timetable.MinimumWidth = 8;
            this.CheckBoxColumn_Timetable.Name = "CheckBoxColumn_Timetable";
            this.CheckBoxColumn_Timetable.Width = 8;
            // 
            // Dgv_Courses
            // 
            this.Dgv_Courses.AllowUserToAddRows = false;
            this.Dgv_Courses.AllowUserToDeleteRows = false;
            this.Dgv_Courses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Courses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Courses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Courses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn_Course});
            this.Dgv_Courses.Location = new System.Drawing.Point(471, 4);
            this.Dgv_Courses.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Courses.Name = "Dgv_Courses";
            this.Dgv_Courses.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Courses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Courses.RowTemplate.Height = 24;
            this.Dgv_Courses.Size = new System.Drawing.Size(940, 377);
            this.Dgv_Courses.TabIndex = 7;
            // 
            // CheckBoxColumn_Course
            // 
            this.CheckBoxColumn_Course.HeaderText = "";
            this.CheckBoxColumn_Course.MinimumWidth = 8;
            this.CheckBoxColumn_Course.Name = "CheckBoxColumn_Course";
            this.CheckBoxColumn_Course.Width = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Textbox_ExamCode_Search_Timetable);
            this.groupBox1.Controls.Add(this.Radio_DateWiseSearch);
            this.groupBox1.Controls.Add(this.Combobox_Branch_Search_Timetable);
            this.groupBox1.Controls.Add(this.Radio_BranchWiseSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Button_Delete);
            this.groupBox1.Controls.Add(this.DateTimePicker_Search_Timetable);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(960, 390);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(449, 422);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Scheduled Timetable";
            // 
            // Textbox_ExamCode_Search_Timetable
            // 
            this.Textbox_ExamCode_Search_Timetable.Enabled = false;
            this.Textbox_ExamCode_Search_Timetable.Location = new System.Drawing.Point(152, 255);
            this.Textbox_ExamCode_Search_Timetable.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_ExamCode_Search_Timetable.Name = "Textbox_ExamCode_Search_Timetable";
            this.Textbox_ExamCode_Search_Timetable.Size = new System.Drawing.Size(278, 26);
            this.Textbox_ExamCode_Search_Timetable.TabIndex = 4;
            this.Textbox_ExamCode_Search_Timetable.TextChanged += new System.EventHandler(this.Textbox_ExamCode_Search_Timetable_TextChanged);
            // 
            // Radio_DateWiseSearch
            // 
            this.Radio_DateWiseSearch.AutoSize = true;
            this.Radio_DateWiseSearch.Location = new System.Drawing.Point(11, 56);
            this.Radio_DateWiseSearch.Margin = new System.Windows.Forms.Padding(4);
            this.Radio_DateWiseSearch.Name = "Radio_DateWiseSearch";
            this.Radio_DateWiseSearch.Size = new System.Drawing.Size(159, 24);
            this.Radio_DateWiseSearch.TabIndex = 0;
            this.Radio_DateWiseSearch.TabStop = true;
            this.Radio_DateWiseSearch.Text = "Date Wise Search";
            this.Radio_DateWiseSearch.UseVisualStyleBackColor = true;
            this.Radio_DateWiseSearch.CheckedChanged += new System.EventHandler(this.Radio_DateWiseSearch_CheckedChanged);
            // 
            // Combobox_Branch_Search_Timetable
            // 
            this.Combobox_Branch_Search_Timetable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch_Search_Timetable.Enabled = false;
            this.Combobox_Branch_Search_Timetable.FormattingEnabled = true;
            this.Combobox_Branch_Search_Timetable.Location = new System.Drawing.Point(152, 212);
            this.Combobox_Branch_Search_Timetable.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_Branch_Search_Timetable.Name = "Combobox_Branch_Search_Timetable";
            this.Combobox_Branch_Search_Timetable.Size = new System.Drawing.Size(278, 28);
            this.Combobox_Branch_Search_Timetable.TabIndex = 3;
            this.Combobox_Branch_Search_Timetable.SelectedIndexChanged += new System.EventHandler(this.Combobox_Branch_Search_Timetable_SelectedIndexChanged);
            // 
            // Radio_BranchWiseSearch
            // 
            this.Radio_BranchWiseSearch.AutoSize = true;
            this.Radio_BranchWiseSearch.Location = new System.Drawing.Point(11, 169);
            this.Radio_BranchWiseSearch.Margin = new System.Windows.Forms.Padding(4);
            this.Radio_BranchWiseSearch.Name = "Radio_BranchWiseSearch";
            this.Radio_BranchWiseSearch.Size = new System.Drawing.Size(175, 24);
            this.Radio_BranchWiseSearch.TabIndex = 2;
            this.Radio_BranchWiseSearch.TabStop = true;
            this.Radio_BranchWiseSearch.Text = "Branch Wise Search";
            this.Radio_BranchWiseSearch.UseVisualStyleBackColor = true;
            this.Radio_BranchWiseSearch.CheckedChanged += new System.EventHandler(this.Radio_BranchWiseSearch_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Branch :";
            // 
            // Button_Delete
            // 
            this.Button_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete.FlatAppearance.BorderSize = 0;
            this.Button_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.Button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete.ForeColor = System.Drawing.Color.White;
            this.Button_Delete.Location = new System.Drawing.Point(11, 360);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(125, 50);
            this.Button_Delete.TabIndex = 5;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // DateTimePicker_Search_Timetable
            // 
            this.DateTimePicker_Search_Timetable.Enabled = false;
            this.DateTimePicker_Search_Timetable.Location = new System.Drawing.Point(152, 99);
            this.DateTimePicker_Search_Timetable.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker_Search_Timetable.Name = "DateTimePicker_Search_Timetable";
            this.DateTimePicker_Search_Timetable.Size = new System.Drawing.Size(278, 26);
            this.DateTimePicker_Search_Timetable.TabIndex = 1;
            this.DateTimePicker_Search_Timetable.ValueChanged += new System.EventHandler(this.DateTimePicker_Search_Timetable_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Exam Code :";
            // 
            // Combobox_Session
            // 
            this.Combobox_Session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Session.FormattingEnabled = true;
            this.Combobox_Session.Items.AddRange(new object[] {
            "Forenoon",
            "Afternoon"});
            this.Combobox_Session.Location = new System.Drawing.Point(118, 67);
            this.Combobox_Session.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_Session.Name = "Combobox_Session";
            this.Combobox_Session.Size = new System.Drawing.Size(323, 28);
            this.Combobox_Session.TabIndex = 1;
            // 
            // DateTimePicker_Add_Timetable
            // 
            this.DateTimePicker_Add_Timetable.Location = new System.Drawing.Point(118, 15);
            this.DateTimePicker_Add_Timetable.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker_Add_Timetable.Name = "DateTimePicker_Add_Timetable";
            this.DateTimePicker_Add_Timetable.Size = new System.Drawing.Size(323, 26);
            this.DateTimePicker_Add_Timetable.TabIndex = 0;
            // 
            // GroupBox_Exam_Mode
            // 
            this.GroupBox_Exam_Mode.Controls.Add(this.Textbox_ExamCode_Search_Course);
            this.GroupBox_Exam_Mode.Controls.Add(this.Combobox_Semester);
            this.GroupBox_Exam_Mode.Controls.Add(this.label4);
            this.GroupBox_Exam_Mode.Controls.Add(this.label9);
            this.GroupBox_Exam_Mode.Controls.Add(this.Combobox_Branch_Search_Course);
            this.GroupBox_Exam_Mode.Controls.Add(this.label8);
            this.GroupBox_Exam_Mode.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Exam_Mode.Location = new System.Drawing.Point(15, 137);
            this.GroupBox_Exam_Mode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_Exam_Mode.Name = "GroupBox_Exam_Mode";
            this.GroupBox_Exam_Mode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox_Exam_Mode.Size = new System.Drawing.Size(449, 168);
            this.GroupBox_Exam_Mode.TabIndex = 2;
            this.GroupBox_Exam_Mode.TabStop = false;
            this.GroupBox_Exam_Mode.Text = "Search Courses";
            // 
            // Textbox_ExamCode_Search_Course
            // 
            this.Textbox_ExamCode_Search_Course.Location = new System.Drawing.Point(141, 124);
            this.Textbox_ExamCode_Search_Course.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_ExamCode_Search_Course.Name = "Textbox_ExamCode_Search_Course";
            this.Textbox_ExamCode_Search_Course.Size = new System.Drawing.Size(284, 26);
            this.Textbox_ExamCode_Search_Course.TabIndex = 2;
            this.Textbox_ExamCode_Search_Course.TextChanged += new System.EventHandler(this.Textbox_ExamCode_Search_Course_TextChanged);
            // 
            // Combobox_Semester
            // 
            this.Combobox_Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Semester.FormattingEnabled = true;
            this.Combobox_Semester.Items.AddRange(new object[] {
            "-Select-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Combobox_Semester.Location = new System.Drawing.Point(141, 80);
            this.Combobox_Semester.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_Semester.Name = "Combobox_Semester";
            this.Combobox_Semester.Size = new System.Drawing.Size(284, 28);
            this.Combobox_Semester.TabIndex = 1;
            this.Combobox_Semester.SelectedIndexChanged += new System.EventHandler(this.Combobox_Semester_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Semester :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Branch :";
            // 
            // Combobox_Branch_Search_Course
            // 
            this.Combobox_Branch_Search_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch_Search_Course.FormattingEnabled = true;
            this.Combobox_Branch_Search_Course.Location = new System.Drawing.Point(141, 38);
            this.Combobox_Branch_Search_Course.Margin = new System.Windows.Forms.Padding(4);
            this.Combobox_Branch_Search_Course.Name = "Combobox_Branch_Search_Course";
            this.Combobox_Branch_Search_Course.Size = new System.Drawing.Size(284, 28);
            this.Combobox_Branch_Search_Course.TabIndex = 0;
            this.Combobox_Branch_Search_Course.SelectedIndexChanged += new System.EventHandler(this.Combobox_Branch_Search_Course_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Exam Code :";
            // 
            // Button_Undo
            // 
            this.Button_Undo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Undo.Enabled = false;
            this.Button_Undo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Undo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Undo.Location = new System.Drawing.Point(170, 321);
            this.Button_Undo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.Size = new System.Drawing.Size(125, 50);
            this.Button_Undo.TabIndex = 4;
            this.Button_Undo.Text = "Undo Add";
            this.Button_Undo.UseVisualStyleBackColor = false;
            this.Button_Undo.Click += new System.EventHandler(this.Button_Undo_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Clear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Clear.Location = new System.Drawing.Point(305, 321);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(144, 50);
            this.Button_Clear.TabIndex = 5;
            this.Button_Clear.Text = "Clear Inputs";
            this.Button_Clear.UseVisualStyleBackColor = false;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add.Location = new System.Drawing.Point(35, 321);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(125, 50);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Session :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date :";
            // 
            // Form_Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1415, 886);
            this.Controls.Add(this.Panel_Body);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form_Timetable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Timetable";
            this.Load += new System.EventHandler(this.Form_Timetable_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Courses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox_Exam_Mode.ResumeLayout(false);
            this.GroupBox_Exam_Mode.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.Button Button_Undo;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.GroupBox GroupBox_Exam_Mode;
        private System.Windows.Forms.ComboBox Combobox_Session;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Add_Timetable;
        private System.Windows.Forms.TextBox Textbox_ExamCode_Search_Timetable;
        private System.Windows.Forms.ComboBox Combobox_Semester;
        private System.Windows.Forms.ComboBox Combobox_Branch_Search_Timetable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_DateWiseSearch;
        private System.Windows.Forms.RadioButton Radio_BranchWiseSearch;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Search_Timetable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Textbox_ExamCode_Search_Course;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Combobox_Branch_Search_Course;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox HeaderCheckBox;
        private System.Windows.Forms.DataGridView Dgv_Timetable;
        private System.Windows.Forms.DataGridView Dgv_Courses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn_Timetable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn_Course;
    }
}