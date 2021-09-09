namespace Exam_Cell
{
    partial class Form_Postponement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.Dgv_Timetable = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn_Timetable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_Postpone = new System.Windows.Forms.Button();
            this.DateTimePicker_NewDate = new System.Windows.Forms.DateTimePicker();
            this.Combobox_NewSession = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Checkbox_Datewise = new System.Windows.Forms.CheckBox();
            this.DateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.Textbox_SubCode = new System.Windows.Forms.TextBox();
            this.Combobox_Semester = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Combobox_Branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Timetable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.Panel_Header.Size = new System.Drawing.Size(937, 55);
            this.Panel_Header.TabIndex = 3;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(885, 9);
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
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Postponement";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HeaderCheckBox);
            this.panel1.Controls.Add(this.Dgv_Timetable);
            this.panel1.Controls.Add(this.Button_Clear);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 507);
            this.panel1.TabIndex = 4;
            // 
            // HeaderCheckBox
            // 
            this.HeaderCheckBox.AutoSize = true;
            this.HeaderCheckBox.Location = new System.Drawing.Point(56, 214);
            this.HeaderCheckBox.Name = "HeaderCheckBox";
            this.HeaderCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HeaderCheckBox.TabIndex = 36;
            this.HeaderCheckBox.UseVisualStyleBackColor = true;
            this.HeaderCheckBox.CheckedChanged += new System.EventHandler(this.HeaderCheckBox_CheckedChanged);
            // 
            // Dgv_Timetable
            // 
            this.Dgv_Timetable.AllowUserToAddRows = false;
            this.Dgv_Timetable.AllowUserToDeleteRows = false;
            this.Dgv_Timetable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Timetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn_Timetable});
            this.Dgv_Timetable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Timetable.Location = new System.Drawing.Point(0, 211);
            this.Dgv_Timetable.Name = "Dgv_Timetable";
            this.Dgv_Timetable.RowTemplate.Height = 24;
            this.Dgv_Timetable.Size = new System.Drawing.Size(937, 296);
            this.Dgv_Timetable.TabIndex = 35;
            this.Dgv_Timetable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Timetable_CellEndEdit);
            this.Dgv_Timetable.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Timetable_CellMouseUp);
            // 
            // CheckBoxColumn_Timetable
            // 
            this.CheckBoxColumn_Timetable.HeaderText = "";
            this.CheckBoxColumn_Timetable.Name = "CheckBoxColumn_Timetable";
            this.CheckBoxColumn_Timetable.Width = 35;
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
            this.Button_Clear.Location = new System.Drawing.Point(417, 165);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(100, 40);
            this.Button_Clear.TabIndex = 28;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = false;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_Postpone);
            this.groupBox1.Controls.Add(this.DateTimePicker_NewDate);
            this.groupBox1.Controls.Add(this.Combobox_NewSession);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(523, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 199);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Postpone to";
            // 
            // Button_Postpone
            // 
            this.Button_Postpone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Postpone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Postpone.FlatAppearance.BorderSize = 0;
            this.Button_Postpone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Postpone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Postpone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Postpone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Postpone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Postpone.Location = new System.Drawing.Point(299, 133);
            this.Button_Postpone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Postpone.Name = "Button_Postpone";
            this.Button_Postpone.Size = new System.Drawing.Size(100, 40);
            this.Button_Postpone.TabIndex = 29;
            this.Button_Postpone.Text = "Postpone";
            this.Button_Postpone.UseVisualStyleBackColor = false;
            this.Button_Postpone.Click += new System.EventHandler(this.Button_Postpone_Click);
            // 
            // DateTimePicker_NewDate
            // 
            this.DateTimePicker_NewDate.Location = new System.Drawing.Point(115, 54);
            this.DateTimePicker_NewDate.Name = "DateTimePicker_NewDate";
            this.DateTimePicker_NewDate.Size = new System.Drawing.Size(284, 22);
            this.DateTimePicker_NewDate.TabIndex = 9;
            // 
            // Combobox_NewSession
            // 
            this.Combobox_NewSession.FormattingEnabled = true;
            this.Combobox_NewSession.Items.AddRange(new object[] {
            "-Optional-",
            "Forenoon",
            "Afternoon"});
            this.Combobox_NewSession.Location = new System.Drawing.Point(115, 91);
            this.Combobox_NewSession.Name = "Combobox_NewSession";
            this.Combobox_NewSession.Size = new System.Drawing.Size(284, 25);
            this.Combobox_NewSession.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "New Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "New Session :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Checkbox_Datewise);
            this.groupBox3.Controls.Add(this.DateTimePicker_Date);
            this.groupBox3.Controls.Add(this.Textbox_SubCode);
            this.groupBox3.Controls.Add(this.Combobox_Semester);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Combobox_Branch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // Checkbox_Datewise
            // 
            this.Checkbox_Datewise.AutoSize = true;
            this.Checkbox_Datewise.Location = new System.Drawing.Point(383, 159);
            this.Checkbox_Datewise.Name = "Checkbox_Datewise";
            this.Checkbox_Datewise.Size = new System.Drawing.Size(15, 14);
            this.Checkbox_Datewise.TabIndex = 10;
            this.Checkbox_Datewise.UseVisualStyleBackColor = true;
            this.Checkbox_Datewise.CheckedChanged += new System.EventHandler(this.Checkbox_Datewise_CheckedChanged);
            // 
            // DateTimePicker_Date
            // 
            this.DateTimePicker_Date.Enabled = false;
            this.DateTimePicker_Date.Location = new System.Drawing.Point(113, 154);
            this.DateTimePicker_Date.Name = "DateTimePicker_Date";
            this.DateTimePicker_Date.Size = new System.Drawing.Size(263, 22);
            this.DateTimePicker_Date.TabIndex = 9;
            this.DateTimePicker_Date.ValueChanged += new System.EventHandler(this.DateTimePicker_Date_ValueChanged);
            // 
            // Textbox_SubCode
            // 
            this.Textbox_SubCode.Location = new System.Drawing.Point(113, 36);
            this.Textbox_SubCode.Name = "Textbox_SubCode";
            this.Textbox_SubCode.Size = new System.Drawing.Size(284, 22);
            this.Textbox_SubCode.TabIndex = 7;
            this.Textbox_SubCode.TextChanged += new System.EventHandler(this.Textbox_SubCode_TextChanged);
            // 
            // Combobox_Semester
            // 
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
            this.Combobox_Semester.Location = new System.Drawing.Point(113, 114);
            this.Combobox_Semester.Name = "Combobox_Semester";
            this.Combobox_Semester.Size = new System.Drawing.Size(284, 25);
            this.Combobox_Semester.TabIndex = 8;
            this.Combobox_Semester.SelectedIndexChanged += new System.EventHandler(this.Combobox_Semester_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sub Code :";
            // 
            // Combobox_Branch
            // 
            this.Combobox_Branch.FormattingEnabled = true;
            this.Combobox_Branch.Location = new System.Drawing.Point(113, 74);
            this.Combobox_Branch.Name = "Combobox_Branch";
            this.Combobox_Branch.Size = new System.Drawing.Size(284, 25);
            this.Combobox_Branch.TabIndex = 8;
            this.Combobox_Branch.SelectedIndexChanged += new System.EventHandler(this.Combobox_Branch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branch :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Semester :";
            // 
            // Form_Postponement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Postponement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Postponement";
            this.Load += new System.EventHandler(this.Form_Postponement_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Timetable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateTimePicker_NewDate;
        private System.Windows.Forms.ComboBox Combobox_NewSession;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Date;
        private System.Windows.Forms.TextBox Textbox_SubCode;
        private System.Windows.Forms.ComboBox Combobox_Semester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combobox_Branch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Postpone;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.CheckBox Checkbox_Datewise;
        private System.Windows.Forms.CheckBox HeaderCheckBox;
        private System.Windows.Forms.DataGridView Dgv_Timetable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn_Timetable;
    }
}