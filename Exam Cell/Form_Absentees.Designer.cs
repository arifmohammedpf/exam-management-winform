namespace Exam_Cell
{
    partial class Form_Absentees
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab_Marking = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Radio_Series = new System.Windows.Forms.RadioButton();
            this.Radio_University = new System.Windows.Forms.RadioButton();
            this.Button_Marking_Search = new System.Windows.Forms.Button();
            this.Combobox_Marking_Session = new System.Windows.Forms.ComboBox();
            this.Combobox_Marking_RoomNo = new System.Windows.Forms.ComboBox();
            this.Combobox_Marking_Date = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Button_Marking_Save = new System.Windows.Forms.Button();
            this.Dgv_Marking = new System.Windows.Forms.DataGridView();
            this.Tab_Statement = new System.Windows.Forms.TabPage();
            this.Button_Prepare_Statement = new System.Windows.Forms.Button();
            this.Dgv_Statement = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_NoOfAbsent = new System.Windows.Forms.Label();
            this.Label_NoOfPresent = new System.Windows.Forms.Label();
            this.Label_NoOfCandidates = new System.Windows.Forms.Label();
            this.Button_Statement_Search = new System.Windows.Forms.Button();
            this.Combobox_Statement_Session = new System.Windows.Forms.ComboBox();
            this.Combobox_Statement_SubCode = new System.Windows.Forms.ComboBox();
            this.Combobox_Statement_Date = new System.Windows.Forms.ComboBox();
            this.Combobox_Statement_BranchClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_Statement_ExamName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_Header.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Tab_Marking.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Marking)).BeginInit();
            this.Tab_Statement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statement)).BeginInit();
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
            this.Panel_Header.Size = new System.Drawing.Size(900, 55);
            this.Panel_Header.TabIndex = 3;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(848, 9);
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
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Absentees";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Tab_Marking);
            this.TabControl.Controls.Add(this.Tab_Statement);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 55);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(900, 507);
            this.TabControl.TabIndex = 4;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Tab_Marking
            // 
            this.Tab_Marking.Controls.Add(this.groupBox2);
            this.Tab_Marking.Controls.Add(this.Button_Marking_Search);
            this.Tab_Marking.Controls.Add(this.Combobox_Marking_Session);
            this.Tab_Marking.Controls.Add(this.Combobox_Marking_RoomNo);
            this.Tab_Marking.Controls.Add(this.Combobox_Marking_Date);
            this.Tab_Marking.Controls.Add(this.label13);
            this.Tab_Marking.Controls.Add(this.label14);
            this.Tab_Marking.Controls.Add(this.label16);
            this.Tab_Marking.Controls.Add(this.Button_Marking_Save);
            this.Tab_Marking.Controls.Add(this.Dgv_Marking);
            this.Tab_Marking.Location = new System.Drawing.Point(4, 26);
            this.Tab_Marking.Name = "Tab_Marking";
            this.Tab_Marking.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Marking.Size = new System.Drawing.Size(892, 477);
            this.Tab_Marking.TabIndex = 0;
            this.Tab_Marking.Text = "Marking";
            this.Tab_Marking.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Radio_Series);
            this.groupBox2.Controls.Add(this.Radio_University);
            this.groupBox2.Location = new System.Drawing.Point(27, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 77);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Exam";
            // 
            // Radio_Series
            // 
            this.Radio_Series.AutoSize = true;
            this.Radio_Series.Location = new System.Drawing.Point(206, 34);
            this.Radio_Series.Name = "Radio_Series";
            this.Radio_Series.Size = new System.Drawing.Size(61, 21);
            this.Radio_Series.TabIndex = 5;
            this.Radio_Series.TabStop = true;
            this.Radio_Series.Text = "Series";
            this.Radio_Series.UseVisualStyleBackColor = true;
            this.Radio_Series.CheckedChanged += new System.EventHandler(this.Radio_Series_CheckedChanged);
            // 
            // Radio_University
            // 
            this.Radio_University.AutoSize = true;
            this.Radio_University.Location = new System.Drawing.Point(53, 34);
            this.Radio_University.Name = "Radio_University";
            this.Radio_University.Size = new System.Drawing.Size(83, 21);
            this.Radio_University.TabIndex = 5;
            this.Radio_University.TabStop = true;
            this.Radio_University.Text = "University";
            this.Radio_University.UseVisualStyleBackColor = true;
            this.Radio_University.CheckedChanged += new System.EventHandler(this.Radio_University_CheckedChanged);
            // 
            // Button_Marking_Search
            // 
            this.Button_Marking_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Marking_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Marking_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Marking_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Marking_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Marking_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Marking_Search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Marking_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Marking_Search.Location = new System.Drawing.Point(113, 244);
            this.Button_Marking_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Marking_Search.Name = "Button_Marking_Search";
            this.Button_Marking_Search.Size = new System.Drawing.Size(240, 40);
            this.Button_Marking_Search.TabIndex = 41;
            this.Button_Marking_Search.Text = "Search";
            this.Button_Marking_Search.UseVisualStyleBackColor = false;
            this.Button_Marking_Search.Click += new System.EventHandler(this.Button_Marking_Search_Click);
            // 
            // Combobox_Marking_Session
            // 
            this.Combobox_Marking_Session.FormattingEnabled = true;
            this.Combobox_Marking_Session.Items.AddRange(new object[] {
            "-Select-",
            "Forenoon",
            "Afternoon"});
            this.Combobox_Marking_Session.Location = new System.Drawing.Point(113, 174);
            this.Combobox_Marking_Session.Name = "Combobox_Marking_Session";
            this.Combobox_Marking_Session.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Marking_Session.TabIndex = 38;
            this.Combobox_Marking_Session.SelectedIndexChanged += new System.EventHandler(this.Combobox_Marking_Session_SelectedIndexChanged);
            // 
            // Combobox_Marking_RoomNo
            // 
            this.Combobox_Marking_RoomNo.FormattingEnabled = true;
            this.Combobox_Marking_RoomNo.Location = new System.Drawing.Point(113, 209);
            this.Combobox_Marking_RoomNo.Name = "Combobox_Marking_RoomNo";
            this.Combobox_Marking_RoomNo.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Marking_RoomNo.TabIndex = 39;
            // 
            // Combobox_Marking_Date
            // 
            this.Combobox_Marking_Date.FormattingEnabled = true;
            this.Combobox_Marking_Date.Location = new System.Drawing.Point(113, 139);
            this.Combobox_Marking_Date.Name = "Combobox_Marking_Date";
            this.Combobox_Marking_Date.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Marking_Date.TabIndex = 40;
            this.Combobox_Marking_Date.SelectedIndexChanged += new System.EventHandler(this.Combobox_Marking_Date_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Date :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 36;
            this.label14.Text = "Session :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Room No :";
            // 
            // Button_Marking_Save
            // 
            this.Button_Marking_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Marking_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Marking_Save.FlatAppearance.BorderSize = 0;
            this.Button_Marking_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Marking_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Marking_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Marking_Save.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Marking_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Marking_Save.Location = new System.Drawing.Point(113, 296);
            this.Button_Marking_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Marking_Save.Name = "Button_Marking_Save";
            this.Button_Marking_Save.Size = new System.Drawing.Size(240, 40);
            this.Button_Marking_Save.TabIndex = 34;
            this.Button_Marking_Save.Text = "Save";
            this.Button_Marking_Save.UseVisualStyleBackColor = false;
            this.Button_Marking_Save.Click += new System.EventHandler(this.Button_Marking_Save_Click);
            // 
            // Dgv_Marking
            // 
            this.Dgv_Marking.AllowUserToAddRows = false;
            this.Dgv_Marking.AllowUserToDeleteRows = false;
            this.Dgv_Marking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Marking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Marking.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv_Marking.Location = new System.Drawing.Point(385, 3);
            this.Dgv_Marking.Name = "Dgv_Marking";
            this.Dgv_Marking.RowTemplate.Height = 24;
            this.Dgv_Marking.Size = new System.Drawing.Size(504, 471);
            this.Dgv_Marking.TabIndex = 33;
            this.Dgv_Marking.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeStudentStatus);
            // 
            // Tab_Statement
            // 
            this.Tab_Statement.Controls.Add(this.Button_Prepare_Statement);
            this.Tab_Statement.Controls.Add(this.Dgv_Statement);
            this.Tab_Statement.Controls.Add(this.groupBox1);
            this.Tab_Statement.Controls.Add(this.button1);
            this.Tab_Statement.Controls.Add(this.Textbox_Statement_ExamName);
            this.Tab_Statement.Controls.Add(this.label6);
            this.Tab_Statement.Location = new System.Drawing.Point(4, 26);
            this.Tab_Statement.Name = "Tab_Statement";
            this.Tab_Statement.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Statement.Size = new System.Drawing.Size(892, 477);
            this.Tab_Statement.TabIndex = 1;
            this.Tab_Statement.Text = "Statement";
            this.Tab_Statement.UseVisualStyleBackColor = true;
            // 
            // Button_Prepare_Statement
            // 
            this.Button_Prepare_Statement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Prepare_Statement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Prepare_Statement.FlatAppearance.BorderSize = 0;
            this.Button_Prepare_Statement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Prepare_Statement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Prepare_Statement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Prepare_Statement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Prepare_Statement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Prepare_Statement.Location = new System.Drawing.Point(105, 427);
            this.Button_Prepare_Statement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Prepare_Statement.Name = "Button_Prepare_Statement";
            this.Button_Prepare_Statement.Size = new System.Drawing.Size(180, 40);
            this.Button_Prepare_Statement.TabIndex = 32;
            this.Button_Prepare_Statement.Text = "Prepare Statement";
            this.Button_Prepare_Statement.UseVisualStyleBackColor = false;
            // 
            // Dgv_Statement
            // 
            this.Dgv_Statement.AllowUserToAddRows = false;
            this.Dgv_Statement.AllowUserToDeleteRows = false;
            this.Dgv_Statement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Statement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Statement.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv_Statement.Location = new System.Drawing.Point(385, 3);
            this.Dgv_Statement.Name = "Dgv_Statement";
            this.Dgv_Statement.RowTemplate.Height = 24;
            this.Dgv_Statement.Size = new System.Drawing.Size(504, 471);
            this.Dgv_Statement.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label_NoOfAbsent);
            this.groupBox1.Controls.Add(this.Label_NoOfPresent);
            this.groupBox1.Controls.Add(this.Label_NoOfCandidates);
            this.groupBox1.Controls.Add(this.Button_Statement_Search);
            this.groupBox1.Controls.Add(this.Combobox_Statement_Session);
            this.groupBox1.Controls.Add(this.Combobox_Statement_SubCode);
            this.groupBox1.Controls.Add(this.Combobox_Statement_Date);
            this.groupBox1.Controls.Add(this.Combobox_Statement_BranchClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 323);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // Label_NoOfAbsent
            // 
            this.Label_NoOfAbsent.AutoSize = true;
            this.Label_NoOfAbsent.Location = new System.Drawing.Point(197, 287);
            this.Label_NoOfAbsent.Name = "Label_NoOfAbsent";
            this.Label_NoOfAbsent.Size = new System.Drawing.Size(115, 17);
            this.Label_NoOfAbsent.TabIndex = 31;
            this.Label_NoOfAbsent.Text = "No of Absent : 000";
            // 
            // Label_NoOfPresent
            // 
            this.Label_NoOfPresent.AutoSize = true;
            this.Label_NoOfPresent.Location = new System.Drawing.Point(195, 262);
            this.Label_NoOfPresent.Name = "Label_NoOfPresent";
            this.Label_NoOfPresent.Size = new System.Drawing.Size(117, 17);
            this.Label_NoOfPresent.TabIndex = 32;
            this.Label_NoOfPresent.Text = "No of Present : 000";
            // 
            // Label_NoOfCandidates
            // 
            this.Label_NoOfCandidates.AutoSize = true;
            this.Label_NoOfCandidates.Location = new System.Drawing.Point(170, 237);
            this.Label_NoOfCandidates.Name = "Label_NoOfCandidates";
            this.Label_NoOfCandidates.Size = new System.Drawing.Size(142, 17);
            this.Label_NoOfCandidates.TabIndex = 33;
            this.Label_NoOfCandidates.Text = "No of Candidates : 000";
            // 
            // Button_Statement_Search
            // 
            this.Button_Statement_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Statement_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Statement_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Statement_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Statement_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Statement_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Statement_Search.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Statement_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Statement_Search.Location = new System.Drawing.Point(127, 184);
            this.Button_Statement_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Statement_Search.Name = "Button_Statement_Search";
            this.Button_Statement_Search.Size = new System.Drawing.Size(240, 40);
            this.Button_Statement_Search.TabIndex = 30;
            this.Button_Statement_Search.Text = "Search";
            this.Button_Statement_Search.UseVisualStyleBackColor = false;
            this.Button_Statement_Search.Click += new System.EventHandler(this.Button_Statement_Search_Click);
            // 
            // Combobox_Statement_Session
            // 
            this.Combobox_Statement_Session.FormattingEnabled = true;
            this.Combobox_Statement_Session.Items.AddRange(new object[] {
            "-Select-",
            "Forenoon",
            "Afternoon"});
            this.Combobox_Statement_Session.Location = new System.Drawing.Point(127, 72);
            this.Combobox_Statement_Session.Name = "Combobox_Statement_Session";
            this.Combobox_Statement_Session.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Statement_Session.TabIndex = 14;
            // 
            // Combobox_Statement_SubCode
            // 
            this.Combobox_Statement_SubCode.FormattingEnabled = true;
            this.Combobox_Statement_SubCode.Location = new System.Drawing.Point(127, 146);
            this.Combobox_Statement_SubCode.Name = "Combobox_Statement_SubCode";
            this.Combobox_Statement_SubCode.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Statement_SubCode.TabIndex = 14;
            // 
            // Combobox_Statement_Date
            // 
            this.Combobox_Statement_Date.FormattingEnabled = true;
            this.Combobox_Statement_Date.Location = new System.Drawing.Point(127, 35);
            this.Combobox_Statement_Date.Name = "Combobox_Statement_Date";
            this.Combobox_Statement_Date.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Statement_Date.TabIndex = 14;
            // 
            // Combobox_Statement_BranchClass
            // 
            this.Combobox_Statement_BranchClass.FormattingEnabled = true;
            this.Combobox_Statement_BranchClass.Location = new System.Drawing.Point(127, 109);
            this.Combobox_Statement_BranchClass.Name = "Combobox_Statement_BranchClass";
            this.Combobox_Statement_BranchClass.Size = new System.Drawing.Size(240, 25);
            this.Combobox_Statement_BranchClass.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Session :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Branch/Class :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Exam Code :";
            // 
            // Textbox_Statement_ExamName
            // 
            this.Textbox_Statement_ExamName.Location = new System.Drawing.Point(18, 392);
            this.Textbox_Statement_ExamName.Name = "Textbox_Statement_ExamName";
            this.Textbox_Statement_ExamName.Size = new System.Drawing.Size(355, 22);
            this.Textbox_Statement_ExamName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name of Examination :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.button1.Location = new System.Drawing.Point(6, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(373, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "re-load datas button needed ?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_Absentees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Absentees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Absentees_Statement";
            this.Load += new System.EventHandler(this.Form_Absentees_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Tab_Marking.ResumeLayout(false);
            this.Tab_Marking.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Marking)).EndInit();
            this.Tab_Statement.ResumeLayout(false);
            this.Tab_Statement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statement)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab_Marking;
        private System.Windows.Forms.TabPage Tab_Statement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Combobox_Statement_Session;
        private System.Windows.Forms.ComboBox Combobox_Statement_SubCode;
        private System.Windows.Forms.ComboBox Combobox_Statement_Date;
        private System.Windows.Forms.ComboBox Combobox_Statement_BranchClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Textbox_Statement_ExamName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Dgv_Statement;
        private System.Windows.Forms.Label Label_NoOfAbsent;
        private System.Windows.Forms.Label Label_NoOfPresent;
        private System.Windows.Forms.Label Label_NoOfCandidates;
        private System.Windows.Forms.Button Button_Statement_Search;
        private System.Windows.Forms.Button Button_Prepare_Statement;
        private System.Windows.Forms.Button Button_Marking_Search;
        private System.Windows.Forms.ComboBox Combobox_Marking_Session;
        private System.Windows.Forms.ComboBox Combobox_Marking_RoomNo;
        private System.Windows.Forms.ComboBox Combobox_Marking_Date;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button Button_Marking_Save;
        private System.Windows.Forms.DataGridView Dgv_Marking;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Radio_Series;
        private System.Windows.Forms.RadioButton Radio_University;
        private System.Windows.Forms.Button button1;
    }
}