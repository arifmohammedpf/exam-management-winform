namespace Exam_Cell
{
    partial class Form_Database_Management
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
            this.components = new System.ComponentModel.Container();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPanel = new System.Windows.Forms.TabControl();
            this.Tab_Add = new System.Windows.Forms.TabPage();
            this.Dgv_ExcelData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Select_ExcelBranch = new System.Windows.Forms.Button();
            this.Button_Add_BranchExcel = new System.Windows.Forms.Button();
            this.Textbox_Filepath_BranchExcel = new System.Windows.Forms.TextBox();
            this.Combobox_BranchSheets = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Select_ExcelStudent = new System.Windows.Forms.Button();
            this.Button_Add_StudExcel = new System.Windows.Forms.Button();
            this.Textbox_Filepath_StudentExcel = new System.Windows.Forms.TextBox();
            this.Combobox_Branch = new System.Windows.Forms.ComboBox();
            this.Combobox_StudSheets = new System.Windows.Forms.ComboBox();
            this.Tab_Update_Student = new System.Windows.Forms.TabPage();
            this.HeaderCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Button_Promote = new System.Windows.Forms.Button();
            this.Button_Demote = new System.Windows.Forms.Button();
            this.Dgv_Student = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Textbox_Yoa = new System.Windows.Forms.TextBox();
            this.Button_Clear_updateStudentTab = new System.Windows.Forms.Button();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            this.Button_Search_updateStudentTab = new System.Windows.Forms.Button();
            this.Textbox_Regno = new System.Windows.Forms.TextBox();
            this.Button_Update_updateStudentTab = new System.Windows.Forms.Button();
            this.Combobox_Class = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Delete_Selected_updateStudentTab = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Combobox_Semester = new System.Windows.Forms.ComboBox();
            this.Combobox_Branch_updateStudTab = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tab_Update_Course = new System.Windows.Forms.TabPage();
            this.Dgv_Course = new System.Windows.Forms.DataGridView();
            this.Button_Clear_updateCourseTab = new System.Windows.Forms.Button();
            this.Button_Search_updateCourseTab = new System.Windows.Forms.Button();
            this.Button_Update_updateCourseTab = new System.Windows.Forms.Button();
            this.Button_DeleteBranch_updateCourseTab = new System.Windows.Forms.Button();
            this.Button_Delete_updateCourseTab = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Combobox_Branch_updateCourseTab = new System.Windows.Forms.ComboBox();
            this.Textbox_ACode = new System.Windows.Forms.TextBox();
            this.Textbox_SubCode = new System.Windows.Forms.TextBox();
            this.Textbox_SubName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProgressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.Panel_ProgressBar = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.TabPanel.SuspendLayout();
            this.Tab_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ExcelData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Tab_Update_Student.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Student)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Tab_Update_Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Course)).BeginInit();
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
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(975, 55);
            this.Panel_Header.TabIndex = 3;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(923, 9);
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
            this.label1.Size = new System.Drawing.Size(228, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Management";
            // 
            // TabPanel
            // 
            this.TabPanel.Controls.Add(this.Tab_Add);
            this.TabPanel.Controls.Add(this.Tab_Update_Student);
            this.TabPanel.Controls.Add(this.Tab_Update_Course);
            this.TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel.Location = new System.Drawing.Point(0, 55);
            this.TabPanel.Multiline = true;
            this.TabPanel.Name = "TabPanel";
            this.TabPanel.SelectedIndex = 0;
            this.TabPanel.Size = new System.Drawing.Size(975, 610);
            this.TabPanel.TabIndex = 4;
            // 
            // Tab_Add
            // 
            this.Tab_Add.Controls.Add(this.Dgv_ExcelData);
            this.Tab_Add.Controls.Add(this.groupBox1);
            this.Tab_Add.Controls.Add(this.groupBox3);
            this.Tab_Add.Location = new System.Drawing.Point(4, 26);
            this.Tab_Add.Name = "Tab_Add";
            this.Tab_Add.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Add.Size = new System.Drawing.Size(967, 580);
            this.Tab_Add.TabIndex = 0;
            this.Tab_Add.Text = "Add to Database";
            this.Tab_Add.UseVisualStyleBackColor = true;
            // 
            // Dgv_ExcelData
            // 
            this.Dgv_ExcelData.AllowUserToAddRows = false;
            this.Dgv_ExcelData.AllowUserToDeleteRows = false;
            this.Dgv_ExcelData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_ExcelData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_ExcelData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_ExcelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ExcelData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_ExcelData.Location = new System.Drawing.Point(3, 231);
            this.Dgv_ExcelData.Name = "Dgv_ExcelData";
            this.Dgv_ExcelData.ReadOnly = true;
            this.Dgv_ExcelData.RowTemplate.Height = 24;
            this.Dgv_ExcelData.Size = new System.Drawing.Size(961, 346);
            this.Dgv_ExcelData.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Select_ExcelBranch);
            this.groupBox1.Controls.Add(this.Button_Add_BranchExcel);
            this.groupBox1.Controls.Add(this.Textbox_Filepath_BranchExcel);
            this.groupBox1.Controls.Add(this.Combobox_BranchSheets);
            this.groupBox1.Location = new System.Drawing.Point(544, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 219);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Branch/Courses";
            // 
            // Button_Select_ExcelBranch
            // 
            this.Button_Select_ExcelBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Select_ExcelBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Select_ExcelBranch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Select_ExcelBranch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Select_ExcelBranch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Select_ExcelBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Select_ExcelBranch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Select_ExcelBranch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Select_ExcelBranch.Location = new System.Drawing.Point(125, 74);
            this.Button_Select_ExcelBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Select_ExcelBranch.Name = "Button_Select_ExcelBranch";
            this.Button_Select_ExcelBranch.Size = new System.Drawing.Size(133, 40);
            this.Button_Select_ExcelBranch.TabIndex = 29;
            this.Button_Select_ExcelBranch.Text = "Select Excel";
            this.Button_Select_ExcelBranch.UseVisualStyleBackColor = false;
            this.Button_Select_ExcelBranch.Click += new System.EventHandler(this.Button_Select_ExcelBranch_Click);
            // 
            // Button_Add_BranchExcel
            // 
            this.Button_Add_BranchExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Add_BranchExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add_BranchExcel.Enabled = false;
            this.Button_Add_BranchExcel.FlatAppearance.BorderSize = 0;
            this.Button_Add_BranchExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Add_BranchExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Add_BranchExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_BranchExcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add_BranchExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add_BranchExcel.Location = new System.Drawing.Point(146, 155);
            this.Button_Add_BranchExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Add_BranchExcel.Name = "Button_Add_BranchExcel";
            this.Button_Add_BranchExcel.Size = new System.Drawing.Size(100, 40);
            this.Button_Add_BranchExcel.TabIndex = 30;
            this.Button_Add_BranchExcel.Text = "Add";
            this.Button_Add_BranchExcel.UseVisualStyleBackColor = false;
            this.Button_Add_BranchExcel.Click += new System.EventHandler(this.Button_Add_BranchExcel_Click);
            // 
            // Textbox_Filepath_BranchExcel
            // 
            this.Textbox_Filepath_BranchExcel.Enabled = false;
            this.Textbox_Filepath_BranchExcel.Location = new System.Drawing.Point(47, 43);
            this.Textbox_Filepath_BranchExcel.Name = "Textbox_Filepath_BranchExcel";
            this.Textbox_Filepath_BranchExcel.ReadOnly = true;
            this.Textbox_Filepath_BranchExcel.Size = new System.Drawing.Size(284, 22);
            this.Textbox_Filepath_BranchExcel.TabIndex = 7;
            // 
            // Combobox_BranchSheets
            // 
            this.Combobox_BranchSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_BranchSheets.FormattingEnabled = true;
            this.Combobox_BranchSheets.Location = new System.Drawing.Point(47, 122);
            this.Combobox_BranchSheets.Name = "Combobox_BranchSheets";
            this.Combobox_BranchSheets.Size = new System.Drawing.Size(284, 25);
            this.Combobox_BranchSheets.TabIndex = 8;
            this.Combobox_BranchSheets.SelectedIndexChanged += new System.EventHandler(this.Combobox_BranchSheets_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Select_ExcelStudent);
            this.groupBox3.Controls.Add(this.Button_Add_StudExcel);
            this.groupBox3.Controls.Add(this.Textbox_Filepath_StudentExcel);
            this.groupBox3.Controls.Add(this.Combobox_Branch);
            this.groupBox3.Controls.Add(this.Combobox_StudSheets);
            this.groupBox3.Location = new System.Drawing.Point(33, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 219);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Students";
            // 
            // Button_Select_ExcelStudent
            // 
            this.Button_Select_ExcelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Select_ExcelStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Select_ExcelStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Select_ExcelStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Select_ExcelStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Select_ExcelStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Select_ExcelStudent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Select_ExcelStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Select_ExcelStudent.Location = new System.Drawing.Point(125, 56);
            this.Button_Select_ExcelStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Select_ExcelStudent.Name = "Button_Select_ExcelStudent";
            this.Button_Select_ExcelStudent.Size = new System.Drawing.Size(133, 40);
            this.Button_Select_ExcelStudent.TabIndex = 29;
            this.Button_Select_ExcelStudent.Text = "Select Excel";
            this.Button_Select_ExcelStudent.UseVisualStyleBackColor = false;
            this.Button_Select_ExcelStudent.Click += new System.EventHandler(this.Button_Select_ExcelStudent_Click);
            // 
            // Button_Add_StudExcel
            // 
            this.Button_Add_StudExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Add_StudExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add_StudExcel.Enabled = false;
            this.Button_Add_StudExcel.FlatAppearance.BorderSize = 0;
            this.Button_Add_StudExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Add_StudExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Add_StudExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_StudExcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add_StudExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Add_StudExcel.Location = new System.Drawing.Point(141, 167);
            this.Button_Add_StudExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Add_StudExcel.Name = "Button_Add_StudExcel";
            this.Button_Add_StudExcel.Size = new System.Drawing.Size(100, 40);
            this.Button_Add_StudExcel.TabIndex = 30;
            this.Button_Add_StudExcel.Text = "Add";
            this.Button_Add_StudExcel.UseVisualStyleBackColor = false;
            this.Button_Add_StudExcel.Click += new System.EventHandler(this.Button_Add_StudExcel_Click);
            // 
            // Textbox_Filepath_StudentExcel
            // 
            this.Textbox_Filepath_StudentExcel.Enabled = false;
            this.Textbox_Filepath_StudentExcel.Location = new System.Drawing.Point(47, 27);
            this.Textbox_Filepath_StudentExcel.Name = "Textbox_Filepath_StudentExcel";
            this.Textbox_Filepath_StudentExcel.ReadOnly = true;
            this.Textbox_Filepath_StudentExcel.Size = new System.Drawing.Size(284, 22);
            this.Textbox_Filepath_StudentExcel.TabIndex = 7;
            // 
            // Combobox_Branch
            // 
            this.Combobox_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch.FormattingEnabled = true;
            this.Combobox_Branch.Location = new System.Drawing.Point(47, 135);
            this.Combobox_Branch.Name = "Combobox_Branch";
            this.Combobox_Branch.Size = new System.Drawing.Size(284, 25);
            this.Combobox_Branch.TabIndex = 8;
            // 
            // Combobox_StudSheets
            // 
            this.Combobox_StudSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_StudSheets.FormattingEnabled = true;
            this.Combobox_StudSheets.Items.AddRange(new object[] {
            "-Select-"});
            this.Combobox_StudSheets.Location = new System.Drawing.Point(47, 103);
            this.Combobox_StudSheets.Name = "Combobox_StudSheets";
            this.Combobox_StudSheets.Size = new System.Drawing.Size(284, 25);
            this.Combobox_StudSheets.TabIndex = 8;
            this.Combobox_StudSheets.SelectedIndexChanged += new System.EventHandler(this.Combobox_StudSheets_SelectedIndexChanged);
            // 
            // Tab_Update_Student
            // 
            this.Tab_Update_Student.Controls.Add(this.HeaderCheckbox);
            this.Tab_Update_Student.Controls.Add(this.groupBox4);
            this.Tab_Update_Student.Controls.Add(this.Dgv_Student);
            this.Tab_Update_Student.Controls.Add(this.groupBox2);
            this.Tab_Update_Student.Location = new System.Drawing.Point(4, 26);
            this.Tab_Update_Student.Name = "Tab_Update_Student";
            this.Tab_Update_Student.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Update_Student.Size = new System.Drawing.Size(967, 580);
            this.Tab_Update_Student.TabIndex = 1;
            this.Tab_Update_Student.Text = "Update Student";
            this.Tab_Update_Student.UseVisualStyleBackColor = true;
            // 
            // HeaderCheckbox
            // 
            this.HeaderCheckbox.AutoSize = true;
            this.HeaderCheckbox.Location = new System.Drawing.Point(55, 208);
            this.HeaderCheckbox.Name = "HeaderCheckbox";
            this.HeaderCheckbox.Size = new System.Drawing.Size(15, 14);
            this.HeaderCheckbox.TabIndex = 30;
            this.HeaderCheckbox.UseVisualStyleBackColor = true;
            this.HeaderCheckbox.CheckedChanged += new System.EventHandler(this.HeaderCheckbox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Button_Promote);
            this.groupBox4.Controls.Add(this.Button_Demote);
            this.groupBox4.Location = new System.Drawing.Point(743, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 184);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Student\'s Semester";
            // 
            // Button_Promote
            // 
            this.Button_Promote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Promote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Promote.FlatAppearance.BorderSize = 0;
            this.Button_Promote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Promote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Promote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Promote.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Promote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Promote.Location = new System.Drawing.Point(50, 49);
            this.Button_Promote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Promote.Name = "Button_Promote";
            this.Button_Promote.Size = new System.Drawing.Size(125, 40);
            this.Button_Promote.TabIndex = 28;
            this.Button_Promote.Text = "Promote";
            this.Button_Promote.UseVisualStyleBackColor = false;
            this.Button_Promote.Click += new System.EventHandler(this.Button_Promote_Click);
            // 
            // Button_Demote
            // 
            this.Button_Demote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Demote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Demote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Demote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Demote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Demote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Demote.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Demote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Demote.Location = new System.Drawing.Point(50, 97);
            this.Button_Demote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Demote.Name = "Button_Demote";
            this.Button_Demote.Size = new System.Drawing.Size(125, 40);
            this.Button_Demote.TabIndex = 25;
            this.Button_Demote.Text = "Demote";
            this.Button_Demote.UseVisualStyleBackColor = false;
            this.Button_Demote.Click += new System.EventHandler(this.Button_Demote_Click);
            // 
            // Dgv_Student
            // 
            this.Dgv_Student.AllowUserToAddRows = false;
            this.Dgv_Student.AllowUserToDeleteRows = false;
            this.Dgv_Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn});
            this.Dgv_Student.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Student.Location = new System.Drawing.Point(3, 205);
            this.Dgv_Student.Name = "Dgv_Student";
            this.Dgv_Student.RowTemplate.Height = 24;
            this.Dgv_Student.Size = new System.Drawing.Size(961, 372);
            this.Dgv_Student.TabIndex = 28;
            this.Dgv_Student.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Student_RowHeaderMouseDoubleClick);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Textbox_Yoa);
            this.groupBox2.Controls.Add(this.Button_Clear_updateStudentTab);
            this.groupBox2.Controls.Add(this.Textbox_Name);
            this.groupBox2.Controls.Add(this.Button_Search_updateStudentTab);
            this.groupBox2.Controls.Add(this.Textbox_Regno);
            this.groupBox2.Controls.Add(this.Button_Update_updateStudentTab);
            this.groupBox2.Controls.Add(this.Combobox_Class);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Button_Delete_Selected_updateStudentTab);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Combobox_Semester);
            this.groupBox2.Controls.Add(this.Combobox_Branch_updateStudTab);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 184);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search/Update";
            // 
            // Textbox_Yoa
            // 
            this.Textbox_Yoa.Location = new System.Drawing.Point(85, 95);
            this.Textbox_Yoa.Name = "Textbox_Yoa";
            this.Textbox_Yoa.Size = new System.Drawing.Size(270, 22);
            this.Textbox_Yoa.TabIndex = 39;
            // 
            // Button_Clear_updateStudentTab
            // 
            this.Button_Clear_updateStudentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Clear_updateStudentTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Clear_updateStudentTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Clear_updateStudentTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Clear_updateStudentTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Clear_updateStudentTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Clear_updateStudentTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clear_updateStudentTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Clear_updateStudentTab.Location = new System.Drawing.Point(366, 132);
            this.Button_Clear_updateStudentTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Clear_updateStudentTab.Name = "Button_Clear_updateStudentTab";
            this.Button_Clear_updateStudentTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Clear_updateStudentTab.TabIndex = 25;
            this.Button_Clear_updateStudentTab.Text = "Clear";
            this.Button_Clear_updateStudentTab.UseVisualStyleBackColor = false;
            this.Button_Clear_updateStudentTab.Click += new System.EventHandler(this.Button_Clear_updateStudentTab_Click);
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.Location = new System.Drawing.Point(85, 61);
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(270, 22);
            this.Textbox_Name.TabIndex = 40;
            // 
            // Button_Search_updateStudentTab
            // 
            this.Button_Search_updateStudentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Search_updateStudentTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Search_updateStudentTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Search_updateStudentTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Search_updateStudentTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Search_updateStudentTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search_updateStudentTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search_updateStudentTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Search_updateStudentTab.Location = new System.Drawing.Point(154, 132);
            this.Button_Search_updateStudentTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Search_updateStudentTab.Name = "Button_Search_updateStudentTab";
            this.Button_Search_updateStudentTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Search_updateStudentTab.TabIndex = 25;
            this.Button_Search_updateStudentTab.Text = "Search";
            this.Button_Search_updateStudentTab.UseVisualStyleBackColor = false;
            this.Button_Search_updateStudentTab.Click += new System.EventHandler(this.Button_Search_updateStudentTab_Click);
            // 
            // Textbox_Regno
            // 
            this.Textbox_Regno.Location = new System.Drawing.Point(85, 27);
            this.Textbox_Regno.Name = "Textbox_Regno";
            this.Textbox_Regno.Size = new System.Drawing.Size(270, 22);
            this.Textbox_Regno.TabIndex = 41;
            // 
            // Button_Update_updateStudentTab
            // 
            this.Button_Update_updateStudentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Update_updateStudentTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Update_updateStudentTab.FlatAppearance.BorderSize = 0;
            this.Button_Update_updateStudentTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Update_updateStudentTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Update_updateStudentTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update_updateStudentTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update_updateStudentTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Update_updateStudentTab.Location = new System.Drawing.Point(260, 132);
            this.Button_Update_updateStudentTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Update_updateStudentTab.Name = "Button_Update_updateStudentTab";
            this.Button_Update_updateStudentTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Update_updateStudentTab.TabIndex = 26;
            this.Button_Update_updateStudentTab.Text = "Update";
            this.Button_Update_updateStudentTab.UseVisualStyleBackColor = false;
            this.Button_Update_updateStudentTab.Click += new System.EventHandler(this.Button_Update_updateStudentTab_Click);
            // 
            // Combobox_Class
            // 
            this.Combobox_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Class.FormattingEnabled = true;
            this.Combobox_Class.Location = new System.Drawing.Point(452, 93);
            this.Combobox_Class.Name = "Combobox_Class";
            this.Combobox_Class.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Class.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Class :";
            // 
            // Button_Delete_Selected_updateStudentTab
            // 
            this.Button_Delete_Selected_updateStudentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete_Selected_updateStudentTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete_Selected_updateStudentTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete_Selected_updateStudentTab.FlatAppearance.BorderSize = 0;
            this.Button_Delete_Selected_updateStudentTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete_Selected_updateStudentTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.Button_Delete_Selected_updateStudentTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete_Selected_updateStudentTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete_Selected_updateStudentTab.ForeColor = System.Drawing.Color.White;
            this.Button_Delete_Selected_updateStudentTab.Location = new System.Drawing.Point(472, 132);
            this.Button_Delete_Selected_updateStudentTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Delete_Selected_updateStudentTab.Name = "Button_Delete_Selected_updateStudentTab";
            this.Button_Delete_Selected_updateStudentTab.Size = new System.Drawing.Size(150, 40);
            this.Button_Delete_Selected_updateStudentTab.TabIndex = 24;
            this.Button_Delete_Selected_updateStudentTab.Text = "Delete Selected";
            this.Button_Delete_Selected_updateStudentTab.UseVisualStyleBackColor = false;
            this.Button_Delete_Selected_updateStudentTab.Click += new System.EventHandler(this.Button_Delete_Selected_updateStudentTab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "YOA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Semester :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Branch :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name :";
            // 
            // Combobox_Semester
            // 
            this.Combobox_Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Semester.FormattingEnabled = true;
            this.Combobox_Semester.Location = new System.Drawing.Point(452, 25);
            this.Combobox_Semester.Name = "Combobox_Semester";
            this.Combobox_Semester.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Semester.TabIndex = 37;
            // 
            // Combobox_Branch_updateStudTab
            // 
            this.Combobox_Branch_updateStudTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch_updateStudTab.FormattingEnabled = true;
            this.Combobox_Branch_updateStudTab.Location = new System.Drawing.Point(452, 59);
            this.Combobox_Branch_updateStudTab.Name = "Combobox_Branch_updateStudTab";
            this.Combobox_Branch_updateStudTab.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Branch_updateStudTab.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Reg No :";
            // 
            // Tab_Update_Course
            // 
            this.Tab_Update_Course.Controls.Add(this.Dgv_Course);
            this.Tab_Update_Course.Controls.Add(this.Button_Clear_updateCourseTab);
            this.Tab_Update_Course.Controls.Add(this.Button_Search_updateCourseTab);
            this.Tab_Update_Course.Controls.Add(this.Button_Update_updateCourseTab);
            this.Tab_Update_Course.Controls.Add(this.Button_DeleteBranch_updateCourseTab);
            this.Tab_Update_Course.Controls.Add(this.Button_Delete_updateCourseTab);
            this.Tab_Update_Course.Controls.Add(this.label11);
            this.Tab_Update_Course.Controls.Add(this.Combobox_Branch_updateCourseTab);
            this.Tab_Update_Course.Controls.Add(this.Textbox_ACode);
            this.Tab_Update_Course.Controls.Add(this.Textbox_SubCode);
            this.Tab_Update_Course.Controls.Add(this.Textbox_SubName);
            this.Tab_Update_Course.Controls.Add(this.label6);
            this.Tab_Update_Course.Controls.Add(this.label7);
            this.Tab_Update_Course.Controls.Add(this.label10);
            this.Tab_Update_Course.Location = new System.Drawing.Point(4, 26);
            this.Tab_Update_Course.Name = "Tab_Update_Course";
            this.Tab_Update_Course.Size = new System.Drawing.Size(967, 580);
            this.Tab_Update_Course.TabIndex = 2;
            this.Tab_Update_Course.Text = "Update Course";
            this.Tab_Update_Course.UseVisualStyleBackColor = true;
            // 
            // Dgv_Course
            // 
            this.Dgv_Course.AllowUserToAddRows = false;
            this.Dgv_Course.AllowUserToDeleteRows = false;
            this.Dgv_Course.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Course.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Course.Location = new System.Drawing.Point(0, 160);
            this.Dgv_Course.Name = "Dgv_Course";
            this.Dgv_Course.RowTemplate.Height = 24;
            this.Dgv_Course.Size = new System.Drawing.Size(967, 420);
            this.Dgv_Course.TabIndex = 67;
            this.Dgv_Course.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Course_RowHeaderMouseDoubleClick);
            // 
            // Button_Clear_updateCourseTab
            // 
            this.Button_Clear_updateCourseTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Clear_updateCourseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Clear_updateCourseTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Clear_updateCourseTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Clear_updateCourseTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Clear_updateCourseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Clear_updateCourseTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clear_updateCourseTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Clear_updateCourseTab.Location = new System.Drawing.Point(529, 99);
            this.Button_Clear_updateCourseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Clear_updateCourseTab.Name = "Button_Clear_updateCourseTab";
            this.Button_Clear_updateCourseTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Clear_updateCourseTab.TabIndex = 64;
            this.Button_Clear_updateCourseTab.Text = "Clear";
            this.Button_Clear_updateCourseTab.UseVisualStyleBackColor = false;
            // 
            // Button_Search_updateCourseTab
            // 
            this.Button_Search_updateCourseTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Search_updateCourseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Search_updateCourseTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Search_updateCourseTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Search_updateCourseTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Search_updateCourseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search_updateCourseTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search_updateCourseTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Search_updateCourseTab.Location = new System.Drawing.Point(211, 99);
            this.Button_Search_updateCourseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Search_updateCourseTab.Name = "Button_Search_updateCourseTab";
            this.Button_Search_updateCourseTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Search_updateCourseTab.TabIndex = 65;
            this.Button_Search_updateCourseTab.Text = "Search";
            this.Button_Search_updateCourseTab.UseVisualStyleBackColor = false;
            this.Button_Search_updateCourseTab.Click += new System.EventHandler(this.Button_Search_updateCourseTab_Click);
            // 
            // Button_Update_updateCourseTab
            // 
            this.Button_Update_updateCourseTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Update_updateCourseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Update_updateCourseTab.FlatAppearance.BorderSize = 0;
            this.Button_Update_updateCourseTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Update_updateCourseTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Update_updateCourseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update_updateCourseTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update_updateCourseTab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Update_updateCourseTab.Location = new System.Drawing.Point(317, 99);
            this.Button_Update_updateCourseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Update_updateCourseTab.Name = "Button_Update_updateCourseTab";
            this.Button_Update_updateCourseTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Update_updateCourseTab.TabIndex = 66;
            this.Button_Update_updateCourseTab.Text = "Update";
            this.Button_Update_updateCourseTab.UseVisualStyleBackColor = false;
            this.Button_Update_updateCourseTab.Click += new System.EventHandler(this.Button_Update_updateCourseTab_Click);
            // 
            // Button_DeleteBranch_updateCourseTab
            // 
            this.Button_DeleteBranch_updateCourseTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_DeleteBranch_updateCourseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DeleteBranch_updateCourseTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_DeleteBranch_updateCourseTab.FlatAppearance.BorderSize = 0;
            this.Button_DeleteBranch_updateCourseTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_DeleteBranch_updateCourseTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.Button_DeleteBranch_updateCourseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DeleteBranch_updateCourseTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DeleteBranch_updateCourseTab.ForeColor = System.Drawing.Color.White;
            this.Button_DeleteBranch_updateCourseTab.Location = new System.Drawing.Point(635, 99);
            this.Button_DeleteBranch_updateCourseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_DeleteBranch_updateCourseTab.Name = "Button_DeleteBranch_updateCourseTab";
            this.Button_DeleteBranch_updateCourseTab.Size = new System.Drawing.Size(145, 40);
            this.Button_DeleteBranch_updateCourseTab.TabIndex = 62;
            this.Button_DeleteBranch_updateCourseTab.Text = "Delete Branch";
            this.Button_DeleteBranch_updateCourseTab.UseVisualStyleBackColor = false;
            // 
            // Button_Delete_updateCourseTab
            // 
            this.Button_Delete_updateCourseTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete_updateCourseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Delete_updateCourseTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete_updateCourseTab.FlatAppearance.BorderSize = 0;
            this.Button_Delete_updateCourseTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(0)))), ((int)(((byte)(87)))));
            this.Button_Delete_updateCourseTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(51)))), ((int)(((byte)(120)))));
            this.Button_Delete_updateCourseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Delete_updateCourseTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Delete_updateCourseTab.ForeColor = System.Drawing.Color.White;
            this.Button_Delete_updateCourseTab.Location = new System.Drawing.Point(423, 99);
            this.Button_Delete_updateCourseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Delete_updateCourseTab.Name = "Button_Delete_updateCourseTab";
            this.Button_Delete_updateCourseTab.Size = new System.Drawing.Size(100, 40);
            this.Button_Delete_updateCourseTab.TabIndex = 63;
            this.Button_Delete_updateCourseTab.Text = "Delete";
            this.Button_Delete_updateCourseTab.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 60;
            this.label11.Text = "Branch :";
            // 
            // Combobox_Branch_updateCourseTab
            // 
            this.Combobox_Branch_updateCourseTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch_updateCourseTab.FormattingEnabled = true;
            this.Combobox_Branch_updateCourseTab.Location = new System.Drawing.Point(208, 23);
            this.Combobox_Branch_updateCourseTab.Name = "Combobox_Branch_updateCourseTab";
            this.Combobox_Branch_updateCourseTab.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Branch_updateCourseTab.TabIndex = 61;
            // 
            // Textbox_ACode
            // 
            this.Textbox_ACode.Location = new System.Drawing.Point(594, 57);
            this.Textbox_ACode.Name = "Textbox_ACode";
            this.Textbox_ACode.Size = new System.Drawing.Size(195, 22);
            this.Textbox_ACode.TabIndex = 57;
            // 
            // Textbox_SubCode
            // 
            this.Textbox_SubCode.Location = new System.Drawing.Point(594, 23);
            this.Textbox_SubCode.Name = "Textbox_SubCode";
            this.Textbox_SubCode.Size = new System.Drawing.Size(195, 22);
            this.Textbox_SubCode.TabIndex = 58;
            // 
            // Textbox_SubName
            // 
            this.Textbox_SubName.Location = new System.Drawing.Point(208, 57);
            this.Textbox_SubName.Name = "Textbox_SubName";
            this.Textbox_SubName.Size = new System.Drawing.Size(270, 22);
            this.Textbox_SubName.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "A Code :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "SubCode :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "SubName :";
            // 
            // ProgressBarTimer
            // 
            this.ProgressBarTimer.Interval = 50;
            this.ProgressBarTimer.Tick += new System.EventHandler(this.ProgressBarTimer_Tick);
            // 
            // Panel_ProgressBar
            // 
            this.Panel_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Panel_ProgressBar.Controls.Add(this.label12);
            this.Panel_ProgressBar.Location = new System.Drawing.Point(327, 325);
            this.Panel_ProgressBar.Name = "Panel_ProgressBar";
            this.Panel_ProgressBar.Size = new System.Drawing.Size(310, 70);
            this.Panel_ProgressBar.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(98, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Please Wait !";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Database_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(975, 665);
            this.Controls.Add(this.TabPanel);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_ProgressBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Database_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Database_Mgmt_Student";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.TabPanel.ResumeLayout(false);
            this.Tab_Add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ExcelData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Tab_Update_Student.ResumeLayout(false);
            this.Tab_Update_Student.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Student)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Tab_Update_Course.ResumeLayout(false);
            this.Tab_Update_Course.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Course)).EndInit();
            this.Panel_ProgressBar.ResumeLayout(false);
            this.Panel_ProgressBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage Tab_Add;
        private System.Windows.Forms.TabPage Tab_Update_Student;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Textbox_Filepath_StudentExcel;
        private System.Windows.Forms.ComboBox Combobox_StudSheets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Select_ExcelBranch;
        private System.Windows.Forms.Button Button_Add_BranchExcel;
        private System.Windows.Forms.TextBox Textbox_Filepath_BranchExcel;
        private System.Windows.Forms.ComboBox Combobox_BranchSheets;
        private System.Windows.Forms.Button Button_Select_ExcelStudent;
        private System.Windows.Forms.Button Button_Add_StudExcel;
        private System.Windows.Forms.TabPage Tab_Update_Course;
        private System.Windows.Forms.Button Button_Clear_updateStudentTab;
        private System.Windows.Forms.Button Button_Search_updateStudentTab;
        private System.Windows.Forms.Button Button_Update_updateStudentTab;
        private System.Windows.Forms.Button Button_Delete_Selected_updateStudentTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Textbox_Yoa;
        private System.Windows.Forms.TextBox Textbox_Name;
        private System.Windows.Forms.TextBox Textbox_Regno;
        private System.Windows.Forms.ComboBox Combobox_Class;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combobox_Semester;
        private System.Windows.Forms.ComboBox Combobox_Branch_updateStudTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_Student;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Button_Promote;
        private System.Windows.Forms.DataGridView Dgv_Course;
        private System.Windows.Forms.Button Button_Clear_updateCourseTab;
        private System.Windows.Forms.Button Button_Search_updateCourseTab;
        private System.Windows.Forms.Button Button_Update_updateCourseTab;
        private System.Windows.Forms.Button Button_DeleteBranch_updateCourseTab;
        private System.Windows.Forms.Button Button_Delete_updateCourseTab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Combobox_Branch_updateCourseTab;
        private System.Windows.Forms.TextBox Textbox_ACode;
        private System.Windows.Forms.TextBox Textbox_SubCode;
        private System.Windows.Forms.TextBox Textbox_SubName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Button_Demote;
        private System.Windows.Forms.DataGridView Dgv_ExcelData;
        private System.Windows.Forms.ComboBox Combobox_Branch;
        private System.Windows.Forms.Timer ProgressBarTimer;
        private System.Windows.Forms.Panel Panel_ProgressBar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.CheckBox HeaderCheckbox;
    }
}