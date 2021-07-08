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
            this.Menu_item_postponement = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_database_mgmt = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_item_credits = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_Copyright = new System.Windows.Forms.Label();
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
            this.Menu_item_candidate_entry.Click += new System.EventHandler(this.Menu_item_candidate_entry_Click);
            // 
            // Menu_item_room
            // 
            this.Menu_item_room.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_room.Name = "Menu_item_room";
            this.Menu_item_room.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_room.Size = new System.Drawing.Size(87, 46);
            this.Menu_item_room.Text = "Room";
            this.Menu_item_room.Click += new System.EventHandler(this.Menu_item_room_Click);
            // 
            // Menu_item_reg_stud_mgmt
            // 
            this.Menu_item_reg_stud_mgmt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_reg_stud_mgmt.Name = "Menu_item_reg_stud_mgmt";
            this.Menu_item_reg_stud_mgmt.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_reg_stud_mgmt.Size = new System.Drawing.Size(250, 46);
            this.Menu_item_reg_stud_mgmt.Text = "Reg Stud Management";
            this.Menu_item_reg_stud_mgmt.Click += new System.EventHandler(this.Menu_item_reg_stud_mgmt_Click);
            // 
            // Menu_item_allotment
            // 
            this.Menu_item_allotment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_allotment.Name = "Menu_item_allotment";
            this.Menu_item_allotment.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_allotment.Size = new System.Drawing.Size(122, 46);
            this.Menu_item_allotment.Text = "Allotment";
            this.Menu_item_allotment.Click += new System.EventHandler(this.Menu_item_allotment_Click);
            // 
            // Menu_item_absentees
            // 
            this.Menu_item_absentees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Menu_item_absentees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_absentees.Name = "Menu_item_absentees";
            this.Menu_item_absentees.Size = new System.Drawing.Size(119, 46);
            this.Menu_item_absentees.Text = "Absentees";
            this.Menu_item_absentees.Click += new System.EventHandler(this.Menu_item_absentees_Click);
            // 
            // Menu_item_postponement
            // 
            this.Menu_item_postponement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_postponement.Name = "Menu_item_postponement";
            this.Menu_item_postponement.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_postponement.Size = new System.Drawing.Size(168, 46);
            this.Menu_item_postponement.Text = "Postponement";
            this.Menu_item_postponement.Click += new System.EventHandler(this.Menu_item_postponement_Click);
            // 
            // Menu_item_database_mgmt
            // 
            this.Menu_item_database_mgmt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_database_mgmt.Name = "Menu_item_database_mgmt";
            this.Menu_item_database_mgmt.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_database_mgmt.Size = new System.Drawing.Size(259, 46);
            this.Menu_item_database_mgmt.Text = "Database Management";
            this.Menu_item_database_mgmt.Click += new System.EventHandler(this.Menu_item_database_mgmt_Click);
            // 
            // Menu_item_credits
            // 
            this.Menu_item_credits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu_item_credits.Name = "Menu_item_credits";
            this.Menu_item_credits.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Menu_item_credits.Size = new System.Drawing.Size(97, 46);
            this.Menu_item_credits.Text = "Credits";
            this.Menu_item_credits.Click += new System.EventHandler(this.Menu_item_credits_Click);
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
            // Label_Copyright
            // 
            this.Label_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Copyright.AutoSize = true;
            this.Label_Copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Label_Copyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Copyright.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Label_Copyright.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Copyright.ForeColor = System.Drawing.Color.White;
            this.Label_Copyright.Location = new System.Drawing.Point(1037, 594);
            this.Label_Copyright.Name = "Label_Copyright";
            this.Label_Copyright.Size = new System.Drawing.Size(464, 21);
            this.Label_Copyright.TabIndex = 9;
            this.Label_Copyright.Text = "© 2021 Developed by Arif Mohammed, CSE (2016-2021)";
            this.Label_Copyright.Click += new System.EventHandler(this.Label_Copyright_Click);
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 678);
            this.Controls.Add(this.Label_Copyright);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_timetable;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_candidate_entry;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_room;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_reg_stud_mgmt;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_allotment;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_absentees;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_postponement;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_database_mgmt;
        public System.Windows.Forms.ToolStripMenuItem Menu_item_credits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_Copyright;
    }
}