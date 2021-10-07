namespace Exam_Cell
{
    partial class Form_Candidate_Entry
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
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Dgv_Course = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn_Course = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.Dgv_Students = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn_Students = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Combobox_Semester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Combobox_Scheme = new System.Windows.Forms.ComboBox();
            this.Combobox_Branch_SchemeSearch = new System.Windows.Forms.ComboBox();
            this.Groupbox_ExtraCandidateRegister = new System.Windows.Forms.GroupBox();
            this.Button_ExtraCand_Register = new System.Windows.Forms.Button();
            this.Textbox_ExtraCand_Name = new System.Windows.Forms.TextBox();
            this.Textbox_ExtraCand_RegNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab_Excel_Import = new System.Windows.Forms.TabPage();
            this.Panel_Import_Excel = new System.Windows.Forms.Panel();
            this.Button_Select_ExcelFile = new System.Windows.Forms.Button();
            this.Button_Register_ExcelSheet = new System.Windows.Forms.Button();
            this.Textbox_ExcelFilepath = new System.Windows.Forms.TextBox();
            this.Combobox_ExcelSheets = new System.Windows.Forms.ComboBox();
            this.Tab_Univeristy_Search = new System.Windows.Forms.TabPage();
            this.Panel_University_Search = new System.Windows.Forms.Panel();
            this.Button_Register_University = new System.Windows.Forms.Button();
            this.Textbox_Yoa_SearchCand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Combobox_Branch_Cand_Register = new System.Windows.Forms.ComboBox();
            this.Tab_Series_Search = new System.Windows.Forms.TabPage();
            this.Panel_Series_Search = new System.Windows.Forms.Panel();
            this.Button_Register_Series = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Combobox_Semester_ClassSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_Series = new System.Windows.Forms.RadioButton();
            this.Radio_University = new System.Windows.Forms.RadioButton();
            this.Panel_ProgressBar = new System.Windows.Forms.Panel();
            this.Combobox_Class = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Students)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Groupbox_ExtraCandidateRegister.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Tab_Excel_Import.SuspendLayout();
            this.Panel_Import_Excel.SuspendLayout();
            this.Tab_Univeristy_Search.SuspendLayout();
            this.Panel_University_Search.SuspendLayout();
            this.Tab_Series_Search.SuspendLayout();
            this.Panel_Series_Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.Panel_Header.Size = new System.Drawing.Size(1191, 55);
            this.Panel_Header.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(1139, 9);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(40, 37);
            this.Button_Close.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidate Entry";
            // 
            // Panel_Body
            // 
            this.Panel_Body.Controls.Add(this.Dgv_Course);
            this.Panel_Body.Controls.Add(this.HeaderCheckBox);
            this.Panel_Body.Controls.Add(this.Dgv_Students);
            this.Panel_Body.Controls.Add(this.groupBox3);
            this.Panel_Body.Controls.Add(this.Groupbox_ExtraCandidateRegister);
            this.Panel_Body.Controls.Add(this.TabControl);
            this.Panel_Body.Controls.Add(this.groupBox1);
            this.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Body.Location = new System.Drawing.Point(0, 55);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1191, 659);
            this.Panel_Body.TabIndex = 0;
            // 
            // Dgv_Course
            // 
            this.Dgv_Course.AllowUserToAddRows = false;
            this.Dgv_Course.AllowUserToDeleteRows = false;
            this.Dgv_Course.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Course.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Course.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Course.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn_Course});
            this.Dgv_Course.Location = new System.Drawing.Point(541, 245);
            this.Dgv_Course.Name = "Dgv_Course";
            this.Dgv_Course.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Course.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Course.RowTemplate.Height = 24;
            this.Dgv_Course.Size = new System.Drawing.Size(649, 413);
            this.Dgv_Course.TabIndex = 39;
            // 
            // CheckBoxColumn_Course
            // 
            this.CheckBoxColumn_Course.HeaderText = "";
            this.CheckBoxColumn_Course.MinimumWidth = 8;
            this.CheckBoxColumn_Course.Name = "CheckBoxColumn_Course";
            this.CheckBoxColumn_Course.Width = 8;
            // 
            // HeaderCheckBox
            // 
            this.HeaderCheckBox.AutoSize = true;
            this.HeaderCheckBox.Location = new System.Drawing.Point(12, 248);
            this.HeaderCheckBox.Name = "HeaderCheckBox";
            this.HeaderCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HeaderCheckBox.TabIndex = 3;
            this.HeaderCheckBox.UseVisualStyleBackColor = true;
            this.HeaderCheckBox.CheckedChanged += new System.EventHandler(this.HeaderCheckBox_CheckedChanged);
            // 
            // Dgv_Students
            // 
            this.Dgv_Students.AllowUserToAddRows = false;
            this.Dgv_Students.AllowUserToDeleteRows = false;
            this.Dgv_Students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dgv_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Students.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn_Students});
            this.Dgv_Students.Location = new System.Drawing.Point(0, 245);
            this.Dgv_Students.Name = "Dgv_Students";
            this.Dgv_Students.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Students.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_Students.RowTemplate.Height = 24;
            this.Dgv_Students.Size = new System.Drawing.Size(542, 413);
            this.Dgv_Students.TabIndex = 37;
            this.Dgv_Students.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Students_CellEndEdit);
            this.Dgv_Students.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Students_CellMouseUp);
            // 
            // CheckBoxColumn_Students
            // 
            this.CheckBoxColumn_Students.HeaderText = "";
            this.CheckBoxColumn_Students.MinimumWidth = 8;
            this.CheckBoxColumn_Students.Name = "CheckBoxColumn_Students";
            this.CheckBoxColumn_Students.Width = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.Combobox_Semester);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Combobox_Scheme);
            this.groupBox3.Controls.Add(this.Combobox_Branch_SchemeSearch);
            this.groupBox3.Location = new System.Drawing.Point(671, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Course";
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
            this.Combobox_Semester.Location = new System.Drawing.Point(107, 100);
            this.Combobox_Semester.Name = "Combobox_Semester";
            this.Combobox_Semester.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Semester.TabIndex = 2;
            this.Combobox_Semester.SelectedIndexChanged += new System.EventHandler(this.Combobox_Semester_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Semester :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Scheme :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Branch :";
            // 
            // Combobox_Scheme
            // 
            this.Combobox_Scheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Scheme.FormattingEnabled = true;
            this.Combobox_Scheme.Location = new System.Drawing.Point(107, 32);
            this.Combobox_Scheme.Name = "Combobox_Scheme";
            this.Combobox_Scheme.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Scheme.TabIndex = 0;
            this.Combobox_Scheme.SelectedIndexChanged += new System.EventHandler(this.Combobox_Scheme_SelectedIndexChanged);
            // 
            // Combobox_Branch_SchemeSearch
            // 
            this.Combobox_Branch_SchemeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch_SchemeSearch.FormattingEnabled = true;
            this.Combobox_Branch_SchemeSearch.Location = new System.Drawing.Point(107, 66);
            this.Combobox_Branch_SchemeSearch.Name = "Combobox_Branch_SchemeSearch";
            this.Combobox_Branch_SchemeSearch.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Branch_SchemeSearch.TabIndex = 1;
            this.Combobox_Branch_SchemeSearch.SelectedIndexChanged += new System.EventHandler(this.Combobox_Branch_SchemeSearch_SelectedIndexChanged);
            // 
            // Groupbox_ExtraCandidateRegister
            // 
            this.Groupbox_ExtraCandidateRegister.Controls.Add(this.Button_ExtraCand_Register);
            this.Groupbox_ExtraCandidateRegister.Controls.Add(this.Textbox_ExtraCand_Name);
            this.Groupbox_ExtraCandidateRegister.Controls.Add(this.Textbox_ExtraCand_RegNo);
            this.Groupbox_ExtraCandidateRegister.Controls.Add(this.label5);
            this.Groupbox_ExtraCandidateRegister.Controls.Add(this.label4);
            this.Groupbox_ExtraCandidateRegister.Enabled = false;
            this.Groupbox_ExtraCandidateRegister.Location = new System.Drawing.Point(313, 2);
            this.Groupbox_ExtraCandidateRegister.Name = "Groupbox_ExtraCandidateRegister";
            this.Groupbox_ExtraCandidateRegister.Size = new System.Drawing.Size(864, 67);
            this.Groupbox_ExtraCandidateRegister.TabIndex = 4;
            this.Groupbox_ExtraCandidateRegister.TabStop = false;
            this.Groupbox_ExtraCandidateRegister.Text = "Extra Candidate Registration";
            // 
            // Button_ExtraCand_Register
            // 
            this.Button_ExtraCand_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_ExtraCand_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ExtraCand_Register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_ExtraCand_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_ExtraCand_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_ExtraCand_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExtraCand_Register.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExtraCand_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_ExtraCand_Register.Location = new System.Drawing.Point(715, 17);
            this.Button_ExtraCand_Register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_ExtraCand_Register.Name = "Button_ExtraCand_Register";
            this.Button_ExtraCand_Register.Size = new System.Drawing.Size(130, 40);
            this.Button_ExtraCand_Register.TabIndex = 2;
            this.Button_ExtraCand_Register.Text = "Register";
            this.Button_ExtraCand_Register.UseVisualStyleBackColor = false;
            this.Button_ExtraCand_Register.Click += new System.EventHandler(this.Button_ExtraCand_Register_Click);
            // 
            // Textbox_ExtraCand_Name
            // 
            this.Textbox_ExtraCand_Name.Location = new System.Drawing.Point(431, 27);
            this.Textbox_ExtraCand_Name.Name = "Textbox_ExtraCand_Name";
            this.Textbox_ExtraCand_Name.Size = new System.Drawing.Size(270, 22);
            this.Textbox_ExtraCand_Name.TabIndex = 1;
            // 
            // Textbox_ExtraCand_RegNo
            // 
            this.Textbox_ExtraCand_RegNo.Location = new System.Drawing.Point(87, 27);
            this.Textbox_ExtraCand_RegNo.Name = "Textbox_ExtraCand_RegNo";
            this.Textbox_ExtraCand_RegNo.Size = new System.Drawing.Size(270, 22);
            this.Textbox_ExtraCand_RegNo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Reg No :";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Tab_Excel_Import);
            this.TabControl.Controls.Add(this.Tab_Univeristy_Search);
            this.TabControl.Controls.Add(this.Tab_Series_Search);
            this.TabControl.Location = new System.Drawing.Point(38, 71);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(461, 167);
            this.TabControl.TabIndex = 1;
            // 
            // Tab_Excel_Import
            // 
            this.Tab_Excel_Import.Controls.Add(this.Panel_Import_Excel);
            this.Tab_Excel_Import.Location = new System.Drawing.Point(4, 26);
            this.Tab_Excel_Import.Name = "Tab_Excel_Import";
            this.Tab_Excel_Import.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Excel_Import.Size = new System.Drawing.Size(453, 137);
            this.Tab_Excel_Import.TabIndex = 1;
            this.Tab_Excel_Import.Text = "Import from Excel";
            this.Tab_Excel_Import.UseVisualStyleBackColor = true;
            // 
            // Panel_Import_Excel
            // 
            this.Panel_Import_Excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Panel_Import_Excel.Controls.Add(this.Button_Select_ExcelFile);
            this.Panel_Import_Excel.Controls.Add(this.Button_Register_ExcelSheet);
            this.Panel_Import_Excel.Controls.Add(this.Textbox_ExcelFilepath);
            this.Panel_Import_Excel.Controls.Add(this.Combobox_ExcelSheets);
            this.Panel_Import_Excel.Location = new System.Drawing.Point(3, 3);
            this.Panel_Import_Excel.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Import_Excel.Name = "Panel_Import_Excel";
            this.Panel_Import_Excel.Size = new System.Drawing.Size(448, 134);
            this.Panel_Import_Excel.TabIndex = 0;
            // 
            // Button_Select_ExcelFile
            // 
            this.Button_Select_ExcelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Select_ExcelFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Select_ExcelFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Select_ExcelFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Select_ExcelFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Select_ExcelFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Select_ExcelFile.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Select_ExcelFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Select_ExcelFile.Location = new System.Drawing.Point(306, 23);
            this.Button_Select_ExcelFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Select_ExcelFile.Name = "Button_Select_ExcelFile";
            this.Button_Select_ExcelFile.Size = new System.Drawing.Size(130, 40);
            this.Button_Select_ExcelFile.TabIndex = 32;
            this.Button_Select_ExcelFile.Text = "Select Excel";
            this.Button_Select_ExcelFile.UseVisualStyleBackColor = false;
            this.Button_Select_ExcelFile.Click += new System.EventHandler(this.Button_Select_ExcelFile_Click);
            // 
            // Button_Register_ExcelSheet
            // 
            this.Button_Register_ExcelSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Register_ExcelSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Register_ExcelSheet.Enabled = false;
            this.Button_Register_ExcelSheet.FlatAppearance.BorderSize = 0;
            this.Button_Register_ExcelSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Register_ExcelSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Register_ExcelSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register_ExcelSheet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Register_ExcelSheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Register_ExcelSheet.Location = new System.Drawing.Point(306, 71);
            this.Button_Register_ExcelSheet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Register_ExcelSheet.Name = "Button_Register_ExcelSheet";
            this.Button_Register_ExcelSheet.Size = new System.Drawing.Size(130, 40);
            this.Button_Register_ExcelSheet.TabIndex = 34;
            this.Button_Register_ExcelSheet.Text = "Register";
            this.Button_Register_ExcelSheet.UseVisualStyleBackColor = false;
            this.Button_Register_ExcelSheet.Click += new System.EventHandler(this.Button_Register_ExcelSheet_Click);
            // 
            // Textbox_ExcelFilepath
            // 
            this.Textbox_ExcelFilepath.Enabled = false;
            this.Textbox_ExcelFilepath.Location = new System.Drawing.Point(14, 30);
            this.Textbox_ExcelFilepath.Name = "Textbox_ExcelFilepath";
            this.Textbox_ExcelFilepath.Size = new System.Drawing.Size(284, 22);
            this.Textbox_ExcelFilepath.TabIndex = 35;
            // 
            // Combobox_ExcelSheets
            // 
            this.Combobox_ExcelSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_ExcelSheets.FormattingEnabled = true;
            this.Combobox_ExcelSheets.Location = new System.Drawing.Point(14, 78);
            this.Combobox_ExcelSheets.Name = "Combobox_ExcelSheets";
            this.Combobox_ExcelSheets.Size = new System.Drawing.Size(284, 25);
            this.Combobox_ExcelSheets.TabIndex = 33;
            this.Combobox_ExcelSheets.SelectedIndexChanged += new System.EventHandler(this.Combobox_ExcelSheets_SelectedIndexChanged);
            // 
            // Tab_Univeristy_Search
            // 
            this.Tab_Univeristy_Search.Controls.Add(this.Panel_University_Search);
            this.Tab_Univeristy_Search.Location = new System.Drawing.Point(4, 26);
            this.Tab_Univeristy_Search.Name = "Tab_Univeristy_Search";
            this.Tab_Univeristy_Search.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Univeristy_Search.Size = new System.Drawing.Size(453, 137);
            this.Tab_Univeristy_Search.TabIndex = 0;
            this.Tab_Univeristy_Search.Text = "Search Students";
            this.Tab_Univeristy_Search.UseVisualStyleBackColor = true;
            // 
            // Panel_University_Search
            // 
            this.Panel_University_Search.Controls.Add(this.Button_Register_University);
            this.Panel_University_Search.Controls.Add(this.Textbox_Yoa_SearchCand);
            this.Panel_University_Search.Controls.Add(this.label3);
            this.Panel_University_Search.Controls.Add(this.label9);
            this.Panel_University_Search.Controls.Add(this.Combobox_Branch_Cand_Register);
            this.Panel_University_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_University_Search.Location = new System.Drawing.Point(3, 3);
            this.Panel_University_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_University_Search.Name = "Panel_University_Search";
            this.Panel_University_Search.Size = new System.Drawing.Size(447, 131);
            this.Panel_University_Search.TabIndex = 0;
            // 
            // Button_Register_University
            // 
            this.Button_Register_University.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Register_University.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Register_University.FlatAppearance.BorderSize = 0;
            this.Button_Register_University.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Register_University.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Register_University.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register_University.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Register_University.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Register_University.Location = new System.Drawing.Point(268, 81);
            this.Button_Register_University.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Register_University.Name = "Button_Register_University";
            this.Button_Register_University.Size = new System.Drawing.Size(130, 40);
            this.Button_Register_University.TabIndex = 44;
            this.Button_Register_University.Text = "Register";
            this.Button_Register_University.UseVisualStyleBackColor = false;
            this.Button_Register_University.Click += new System.EventHandler(this.Button_Register_University_Click);
            // 
            // Textbox_Yoa_SearchCand
            // 
            this.Textbox_Yoa_SearchCand.Location = new System.Drawing.Point(128, 49);
            this.Textbox_Yoa_SearchCand.Name = "Textbox_Yoa_SearchCand";
            this.Textbox_Yoa_SearchCand.Size = new System.Drawing.Size(270, 22);
            this.Textbox_Yoa_SearchCand.TabIndex = 43;
            this.Textbox_Yoa_SearchCand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_Yoa_SearchCand_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "YOA :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Branch :";
            // 
            // Combobox_Branch_Cand_Register
            // 
            this.Combobox_Branch_Cand_Register.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Branch_Cand_Register.FormattingEnabled = true;
            this.Combobox_Branch_Cand_Register.Location = new System.Drawing.Point(128, 14);
            this.Combobox_Branch_Cand_Register.Name = "Combobox_Branch_Cand_Register";
            this.Combobox_Branch_Cand_Register.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Branch_Cand_Register.TabIndex = 42;
            this.Combobox_Branch_Cand_Register.SelectedIndexChanged += new System.EventHandler(this.Combobox_Branch_Cand_Register_SelectedIndexChanged);
            // 
            // Tab_Series_Search
            // 
            this.Tab_Series_Search.Controls.Add(this.Panel_Series_Search);
            this.Tab_Series_Search.Location = new System.Drawing.Point(4, 26);
            this.Tab_Series_Search.Name = "Tab_Series_Search";
            this.Tab_Series_Search.Size = new System.Drawing.Size(453, 137);
            this.Tab_Series_Search.TabIndex = 2;
            this.Tab_Series_Search.Text = "Search Students";
            this.Tab_Series_Search.UseVisualStyleBackColor = true;
            // 
            // Panel_Series_Search
            // 
            this.Panel_Series_Search.Controls.Add(this.Button_Register_Series);
            this.Panel_Series_Search.Controls.Add(this.label10);
            this.Panel_Series_Search.Controls.Add(this.label2);
            this.Panel_Series_Search.Controls.Add(this.Combobox_Class);
            this.Panel_Series_Search.Controls.Add(this.Combobox_Semester_ClassSearch);
            this.Panel_Series_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Series_Search.Location = new System.Drawing.Point(0, 0);
            this.Panel_Series_Search.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Series_Search.Name = "Panel_Series_Search";
            this.Panel_Series_Search.Size = new System.Drawing.Size(453, 137);
            this.Panel_Series_Search.TabIndex = 0;
            // 
            // Button_Register_Series
            // 
            this.Button_Register_Series.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Register_Series.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Register_Series.FlatAppearance.BorderSize = 0;
            this.Button_Register_Series.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Register_Series.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Register_Series.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register_Series.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Register_Series.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Register_Series.Location = new System.Drawing.Point(249, 86);
            this.Button_Register_Series.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Register_Series.Name = "Button_Register_Series";
            this.Button_Register_Series.Size = new System.Drawing.Size(130, 40);
            this.Button_Register_Series.TabIndex = 45;
            this.Button_Register_Series.Text = "Register";
            this.Button_Register_Series.UseVisualStyleBackColor = false;
            this.Button_Register_Series.Click += new System.EventHandler(this.Button_Register_Series_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Semester :";
            // 
            // Combobox_Semester_ClassSearch
            // 
            this.Combobox_Semester_ClassSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Semester_ClassSearch.FormattingEnabled = true;
            this.Combobox_Semester_ClassSearch.Items.AddRange(new object[] {
            "-Select-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Combobox_Semester_ClassSearch.Location = new System.Drawing.Point(109, 18);
            this.Combobox_Semester_ClassSearch.Name = "Combobox_Semester_ClassSearch";
            this.Combobox_Semester_ClassSearch.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Semester_ClassSearch.TabIndex = 44;
            this.Combobox_Semester_ClassSearch.SelectedIndexChanged += new System.EventHandler(this.Combobox_Semester_ClassSearch_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_Series);
            this.groupBox1.Controls.Add(this.Radio_University);
            this.groupBox1.Location = new System.Drawing.Point(15, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Exam";
            // 
            // Radio_Series
            // 
            this.Radio_Series.AutoSize = true;
            this.Radio_Series.Location = new System.Drawing.Point(165, 30);
            this.Radio_Series.Name = "Radio_Series";
            this.Radio_Series.Size = new System.Drawing.Size(61, 21);
            this.Radio_Series.TabIndex = 1;
            this.Radio_Series.Text = "Series";
            this.Radio_Series.UseVisualStyleBackColor = true;
            this.Radio_Series.CheckedChanged += new System.EventHandler(this.Radio_Series_CheckedChanged);
            // 
            // Radio_University
            // 
            this.Radio_University.AutoSize = true;
            this.Radio_University.Location = new System.Drawing.Point(31, 30);
            this.Radio_University.Name = "Radio_University";
            this.Radio_University.Size = new System.Drawing.Size(83, 21);
            this.Radio_University.TabIndex = 0;
            this.Radio_University.Text = "University";
            this.Radio_University.UseVisualStyleBackColor = true;
            this.Radio_University.CheckedChanged += new System.EventHandler(this.Radio_University_CheckedChanged);
            // 
            // Panel_ProgressBar
            // 
            this.Panel_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Panel_ProgressBar.BackgroundImage = global::Exam_Cell.Properties.Resources.ProgressPanel;
            this.Panel_ProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel_ProgressBar.Location = new System.Drawing.Point(440, 334);
            this.Panel_ProgressBar.Name = "Panel_ProgressBar";
            this.Panel_ProgressBar.Size = new System.Drawing.Size(310, 64);
            this.Panel_ProgressBar.TabIndex = 18;
            this.Panel_ProgressBar.Visible = false;
            // 
            // Combobox_Class
            // 
            this.Combobox_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_Class.FormattingEnabled = true;
            this.Combobox_Class.Location = new System.Drawing.Point(109, 54);
            this.Combobox_Class.Name = "Combobox_Class";
            this.Combobox_Class.Size = new System.Drawing.Size(270, 25);
            this.Combobox_Class.TabIndex = 44;
            this.Combobox_Class.SelectedIndexChanged += new System.EventHandler(this.Combobox_Class_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Class :";
            // 
            // Form_Candidate_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1191, 714);
            this.Controls.Add(this.Panel_ProgressBar);
            this.Controls.Add(this.Panel_Body);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Candidate_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Candidate_Entry";
            this.Load += new System.EventHandler(this.Form_Candidate_Entry_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Students)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Groupbox_ExtraCandidateRegister.ResumeLayout(false);
            this.Groupbox_ExtraCandidateRegister.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Tab_Excel_Import.ResumeLayout(false);
            this.Panel_Import_Excel.ResumeLayout(false);
            this.Panel_Import_Excel.PerformLayout();
            this.Tab_Univeristy_Search.ResumeLayout(false);
            this.Panel_University_Search.ResumeLayout(false);
            this.Panel_University_Search.PerformLayout();
            this.Tab_Series_Search.ResumeLayout(false);
            this.Panel_Series_Search.ResumeLayout(false);
            this.Panel_Series_Search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Combobox_Semester;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Combobox_Scheme;
        private System.Windows.Forms.ComboBox Combobox_Branch_SchemeSearch;
        private System.Windows.Forms.GroupBox Groupbox_ExtraCandidateRegister;
        private System.Windows.Forms.Button Button_ExtraCand_Register;
        private System.Windows.Forms.TextBox Textbox_ExtraCand_Name;
        private System.Windows.Forms.TextBox Textbox_ExtraCand_RegNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab_Excel_Import;
        private System.Windows.Forms.TabPage Tab_Univeristy_Search;
        private System.Windows.Forms.TabPage Tab_Series_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_Series;
        private System.Windows.Forms.RadioButton Radio_University;
        private System.Windows.Forms.Panel Panel_ProgressBar;
        private System.Windows.Forms.CheckBox HeaderCheckBox;
        private System.Windows.Forms.DataGridView Dgv_Students;
        private System.Windows.Forms.DataGridView Dgv_Course;
        private System.Windows.Forms.Panel Panel_Import_Excel;
        private System.Windows.Forms.Button Button_Select_ExcelFile;
        private System.Windows.Forms.Button Button_Register_ExcelSheet;
        private System.Windows.Forms.TextBox Textbox_ExcelFilepath;
        private System.Windows.Forms.ComboBox Combobox_ExcelSheets;
        private System.Windows.Forms.Panel Panel_University_Search;
        private System.Windows.Forms.Button Button_Register_University;
        private System.Windows.Forms.TextBox Textbox_Yoa_SearchCand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Combobox_Branch_Cand_Register;
        private System.Windows.Forms.Panel Panel_Series_Search;
        private System.Windows.Forms.Button Button_Register_Series;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combobox_Semester_ClassSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn_Course;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn_Students;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Combobox_Class;
    }
}