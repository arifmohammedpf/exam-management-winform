namespace Exam_Cell
{
    partial class Form_Reg_Student_Mgmt
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
            this.Groupbox_Registered = new System.Windows.Forms.GroupBox();
            this.Radio_Series_Reg = new System.Windows.Forms.RadioButton();
            this.Radio_University_Reg = new System.Windows.Forms.RadioButton();
            this.Groupbox_Alloted = new System.Windows.Forms.GroupBox();
            this.Radio_Series_Alloted = new System.Windows.Forms.RadioButton();
            this.Radio_University_Alloted = new System.Windows.Forms.RadioButton();
            this.Label_NoOfStudents = new System.Windows.Forms.Label();
            this.Textbox_RegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Combobox_Branch = new System.Windows.Forms.ComboBox();
            this.Combobox_Semester = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.HeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.Dgv_Students = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Label_Total = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            this.Groupbox_Registered.SuspendLayout();
            this.Groupbox_Alloted.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Students)).BeginInit();
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
            this.Panel_Header.Size = new System.Drawing.Size(910, 55);
            this.Panel_Header.TabIndex = 5;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(865, 9);
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
            this.label1.Size = new System.Drawing.Size(311, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered Student Management";
            // 
            // Groupbox_Registered
            // 
            this.Groupbox_Registered.Controls.Add(this.Radio_Series_Reg);
            this.Groupbox_Registered.Controls.Add(this.Radio_University_Reg);
            this.Groupbox_Registered.Location = new System.Drawing.Point(25, 95);
            this.Groupbox_Registered.Name = "Groupbox_Registered";
            this.Groupbox_Registered.Size = new System.Drawing.Size(235, 82);
            this.Groupbox_Registered.TabIndex = 0;
            this.Groupbox_Registered.TabStop = false;
            this.Groupbox_Registered.Text = "Registered Students of";
            // 
            // Radio_Series_Reg
            // 
            this.Radio_Series_Reg.AutoSize = true;
            this.Radio_Series_Reg.Location = new System.Drawing.Point(153, 36);
            this.Radio_Series_Reg.Name = "Radio_Series_Reg";
            this.Radio_Series_Reg.Size = new System.Drawing.Size(61, 21);
            this.Radio_Series_Reg.TabIndex = 1;
            this.Radio_Series_Reg.TabStop = true;
            this.Radio_Series_Reg.Text = "Series";
            this.Radio_Series_Reg.UseVisualStyleBackColor = true;
            this.Radio_Series_Reg.CheckedChanged += new System.EventHandler(this.Radio_Series_Reg_CheckedChanged);
            // 
            // Radio_University_Reg
            // 
            this.Radio_University_Reg.AutoSize = true;
            this.Radio_University_Reg.Location = new System.Drawing.Point(10, 36);
            this.Radio_University_Reg.Name = "Radio_University_Reg";
            this.Radio_University_Reg.Size = new System.Drawing.Size(83, 21);
            this.Radio_University_Reg.TabIndex = 0;
            this.Radio_University_Reg.TabStop = true;
            this.Radio_University_Reg.Text = "University";
            this.Radio_University_Reg.UseVisualStyleBackColor = true;
            this.Radio_University_Reg.CheckedChanged += new System.EventHandler(this.Radio_University_Reg_CheckedChanged);
            // 
            // Groupbox_Alloted
            // 
            this.Groupbox_Alloted.Controls.Add(this.Radio_Series_Alloted);
            this.Groupbox_Alloted.Controls.Add(this.Radio_University_Alloted);
            this.Groupbox_Alloted.Location = new System.Drawing.Point(289, 95);
            this.Groupbox_Alloted.Name = "Groupbox_Alloted";
            this.Groupbox_Alloted.Size = new System.Drawing.Size(235, 82);
            this.Groupbox_Alloted.TabIndex = 1;
            this.Groupbox_Alloted.TabStop = false;
            this.Groupbox_Alloted.Text = "Alloted Students of";
            // 
            // Radio_Series_Alloted
            // 
            this.Radio_Series_Alloted.AutoSize = true;
            this.Radio_Series_Alloted.Location = new System.Drawing.Point(153, 36);
            this.Radio_Series_Alloted.Name = "Radio_Series_Alloted";
            this.Radio_Series_Alloted.Size = new System.Drawing.Size(61, 21);
            this.Radio_Series_Alloted.TabIndex = 1;
            this.Radio_Series_Alloted.TabStop = true;
            this.Radio_Series_Alloted.Text = "Series";
            this.Radio_Series_Alloted.UseVisualStyleBackColor = true;
            this.Radio_Series_Alloted.CheckedChanged += new System.EventHandler(this.Radio_Series_Alloted_CheckedChanged);
            // 
            // Radio_University_Alloted
            // 
            this.Radio_University_Alloted.AutoSize = true;
            this.Radio_University_Alloted.Location = new System.Drawing.Point(10, 36);
            this.Radio_University_Alloted.Name = "Radio_University_Alloted";
            this.Radio_University_Alloted.Size = new System.Drawing.Size(83, 21);
            this.Radio_University_Alloted.TabIndex = 0;
            this.Radio_University_Alloted.TabStop = true;
            this.Radio_University_Alloted.Text = "University";
            this.Radio_University_Alloted.UseVisualStyleBackColor = true;
            this.Radio_University_Alloted.CheckedChanged += new System.EventHandler(this.Radio_University_Alloted_CheckedChanged);
            // 
            // Label_NoOfStudents
            // 
            this.Label_NoOfStudents.AutoSize = true;
            this.Label_NoOfStudents.Location = new System.Drawing.Point(22, 216);
            this.Label_NoOfStudents.Name = "Label_NoOfStudents";
            this.Label_NoOfStudents.Size = new System.Drawing.Size(101, 17);
            this.Label_NoOfStudents.TabIndex = 6;
            this.Label_NoOfStudents.Text = "No of Students :";
            // 
            // Textbox_RegNo
            // 
            this.Textbox_RegNo.Location = new System.Drawing.Point(95, 23);
            this.Textbox_RegNo.Name = "Textbox_RegNo";
            this.Textbox_RegNo.Size = new System.Drawing.Size(257, 22);
            this.Textbox_RegNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "RegNo :";
            // 
            // Combobox_Branch
            // 
            this.Combobox_Branch.FormattingEnabled = true;
            this.Combobox_Branch.Location = new System.Drawing.Point(95, 53);
            this.Combobox_Branch.Name = "Combobox_Branch";
            this.Combobox_Branch.Size = new System.Drawing.Size(257, 25);
            this.Combobox_Branch.TabIndex = 1;
            // 
            // Combobox_Semester
            // 
            this.Combobox_Semester.FormattingEnabled = true;
            this.Combobox_Semester.Location = new System.Drawing.Point(95, 86);
            this.Combobox_Semester.Name = "Combobox_Semester";
            this.Combobox_Semester.Size = new System.Drawing.Size(257, 25);
            this.Combobox_Semester.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Branch :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Semester :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_Delete);
            this.groupBox3.Controls.Add(this.Textbox_RegNo);
            this.groupBox3.Controls.Add(this.Combobox_Semester);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Combobox_Branch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(547, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
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
            this.Button_Delete.Location = new System.Drawing.Point(252, 120);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(100, 40);
            this.Button_Delete.TabIndex = 3;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // HeaderCheckBox
            // 
            this.HeaderCheckBox.AutoSize = true;
            this.HeaderCheckBox.Location = new System.Drawing.Point(53, 242);
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
            this.Dgv_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Students.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Students.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn});
            this.Dgv_Students.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_Students.Location = new System.Drawing.Point(0, 239);
            this.Dgv_Students.Name = "Dgv_Students";
            this.Dgv_Students.RowTemplate.Height = 24;
            this.Dgv_Students.Size = new System.Drawing.Size(910, 427);
            this.Dgv_Students.TabIndex = 4;
            this.Dgv_Students.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Students_CellEndEdit);
            this.Dgv_Students.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Students_CellMouseUp);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 5;
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.Location = new System.Drawing.Point(286, 216);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(43, 17);
            this.Label_Total.TabIndex = 6;
            this.Label_Total.Text = "Total :";
            // 
            // Form_Reg_Student_Mgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(910, 666);
            this.Controls.Add(this.HeaderCheckBox);
            this.Controls.Add(this.Dgv_Students);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Label_Total);
            this.Controls.Add(this.Label_NoOfStudents);
            this.Controls.Add(this.Groupbox_Alloted);
            this.Controls.Add(this.Groupbox_Registered);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Reg_Student_Mgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Reg_Student_Mgmt";
            this.Load += new System.EventHandler(this.Form_Reg_Student_Mgmt_Load);
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            this.Groupbox_Registered.ResumeLayout(false);
            this.Groupbox_Registered.PerformLayout();
            this.Groupbox_Alloted.ResumeLayout(false);
            this.Groupbox_Alloted.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.GroupBox Groupbox_Registered;
        private System.Windows.Forms.RadioButton Radio_Series_Reg;
        private System.Windows.Forms.RadioButton Radio_University_Reg;
        private System.Windows.Forms.GroupBox Groupbox_Alloted;
        private System.Windows.Forms.RadioButton Radio_Series_Alloted;
        private System.Windows.Forms.RadioButton Radio_University_Alloted;
        private System.Windows.Forms.Label Label_NoOfStudents;
        private System.Windows.Forms.TextBox Textbox_RegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combobox_Branch;
        private System.Windows.Forms.ComboBox Combobox_Semester;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.CheckBox HeaderCheckBox;
        private System.Windows.Forms.DataGridView Dgv_Students;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.Label Label_Total;
    }
}