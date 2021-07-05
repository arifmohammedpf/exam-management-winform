namespace Exam_Cell
{
    partial class Form_MainMenu
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_item_timetable = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_candidate_entry = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_room = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_reg_stud_mgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_allotment = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_absentees = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_dropitem_absentees_marking = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_dropitem_absentees_statement = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_postponement = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_database_mgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_dropitem_database_mgmt_student = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_dropitem_database_mgmt_classbranch = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_credits = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.MenuStrip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_item_timetable,
            this.Menu_item_candidate_entry,
            this.Menu_item_room,
            this.Menu_item_reg_stud_mgmt,
            this.Menu_item_allotment,
            this.Menu_item_absentees,
            this.Menu_item_postponement,
            this.Menu_item_database_mgmt,
            this.Menu_item_credits});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.MenuStrip.Size = new System.Drawing.Size(1605, 46);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "Menu";
            // 
            // Menu_item_timetable
            // 
            this.Menu_item_timetable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_timetable.Name = "Menu_item_timetable";
            this.Menu_item_timetable.Padding = new System.Windows.Forms.Padding(10);
            this.Menu_item_timetable.Size = new System.Drawing.Size(122, 46);
            this.Menu_item_timetable.Text = "Timetable";
            this.Menu_item_timetable.Click += new System.EventHandler(this.Menu_item_timetable_Click);
            // 
            // Menu_item_candidate_entry
            // 
            this.Menu_item_candidate_entry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_candidate_entry.Name = "Menu_item_candidate_entry";
            this.Menu_item_candidate_entry.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_candidate_entry.Size = new System.Drawing.Size(186, 46);
            this.Menu_item_candidate_entry.Text = "Candidate Entry";
            // 
            // Menu_item_room
            // 
            this.Menu_item_room.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_room.Name = "Menu_item_room";
            this.Menu_item_room.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_room.Size = new System.Drawing.Size(87, 46);
            this.Menu_item_room.Text = "Room";
            // 
            // Menu_item_reg_stud_mgmt
            // 
            this.Menu_item_reg_stud_mgmt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_reg_stud_mgmt.Name = "Menu_item_reg_stud_mgmt";
            this.Menu_item_reg_stud_mgmt.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_reg_stud_mgmt.Size = new System.Drawing.Size(250, 46);
            this.Menu_item_reg_stud_mgmt.Text = "Reg Stud Management";
            // 
            // Menu_item_allotment
            // 
            this.Menu_item_allotment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_allotment.Name = "Menu_item_allotment";
            this.Menu_item_allotment.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_allotment.Size = new System.Drawing.Size(122, 46);
            this.Menu_item_allotment.Text = "Allotment";
            // 
            // Menu_item_absentees
            // 
            this.Menu_item_absentees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Menu_item_absentees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_dropitem_absentees_marking,
            this.Menu_dropitem_absentees_statement});
            this.Menu_item_absentees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_absentees.Name = "Menu_item_absentees";
            this.Menu_item_absentees.Size = new System.Drawing.Size(119, 46);
            this.Menu_item_absentees.Text = "Absentees";
            // 
            // Menu_dropitem_absentees_marking
            // 
            this.Menu_dropitem_absentees_marking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Menu_dropitem_absentees_marking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_dropitem_absentees_marking.Name = "Menu_dropitem_absentees_marking";
            this.Menu_dropitem_absentees_marking.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Menu_dropitem_absentees_marking.Size = new System.Drawing.Size(182, 44);
            this.Menu_dropitem_absentees_marking.Text = "Marking";
            // 
            // Menu_dropitem_absentees_statement
            // 
            this.Menu_dropitem_absentees_statement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Menu_dropitem_absentees_statement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_dropitem_absentees_statement.Name = "Menu_dropitem_absentees_statement";
            this.Menu_dropitem_absentees_statement.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Menu_dropitem_absentees_statement.Size = new System.Drawing.Size(182, 44);
            this.Menu_dropitem_absentees_statement.Text = "Statement";
            // 
            // Menu_item_postponement
            // 
            this.Menu_item_postponement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_postponement.Name = "Menu_item_postponement";
            this.Menu_item_postponement.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_postponement.Size = new System.Drawing.Size(168, 46);
            this.Menu_item_postponement.Text = "Postponement";
            // 
            // Menu_item_database_mgmt
            // 
            this.Menu_item_database_mgmt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_dropitem_database_mgmt_student,
            this.Menu_dropitem_database_mgmt_classbranch});
            this.Menu_item_database_mgmt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_database_mgmt.Name = "Menu_item_database_mgmt";
            this.Menu_item_database_mgmt.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_database_mgmt.Size = new System.Drawing.Size(259, 46);
            this.Menu_item_database_mgmt.Text = "Database Management";
            // 
            // Menu_dropitem_database_mgmt_student
            // 
            this.Menu_dropitem_database_mgmt_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Menu_dropitem_database_mgmt_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_dropitem_database_mgmt_student.Name = "Menu_dropitem_database_mgmt_student";
            this.Menu_dropitem_database_mgmt_student.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Menu_dropitem_database_mgmt_student.Size = new System.Drawing.Size(205, 44);
            this.Menu_dropitem_database_mgmt_student.Text = "Student ";
            // 
            // Menu_dropitem_database_mgmt_classbranch
            // 
            this.Menu_dropitem_database_mgmt_classbranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Menu_dropitem_database_mgmt_classbranch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_dropitem_database_mgmt_classbranch.Name = "Menu_dropitem_database_mgmt_classbranch";
            this.Menu_dropitem_database_mgmt_classbranch.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Menu_dropitem_database_mgmt_classbranch.Size = new System.Drawing.Size(205, 44);
            this.Menu_dropitem_database_mgmt_classbranch.Text = "Class/Branch";
            // 
            // Menu_item_credits
            // 
            this.Menu_item_credits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_credits.Name = "Menu_item_credits";
            this.Menu_item_credits.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_credits.Size = new System.Drawing.Size(97, 46);
            this.Menu_item_credits.Text = "Credits";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Exam_Cell.Properties.Resources.Kmea_Bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1605, 678);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 678);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_MainMenu";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_MainMenu_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_timetable;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_candidate_entry;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_room;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_reg_stud_mgmt;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_allotment;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_absentees;
        public System.Windows.Forms.ToolStripMenuItem Menu_dropitem_absentees_marking;
        public System.Windows.Forms.ToolStripMenuItem Menu_dropitem_absentees_statement;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_postponement;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_database_mgmt;
        public System.Windows.Forms.ToolStripMenuItem Menu_dropitem_database_mgmt_student;
        public System.Windows.Forms.ToolStripMenuItem Menu_dropitem_database_mgmt_classbranch;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_credits;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}