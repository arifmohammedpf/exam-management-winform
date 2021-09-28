namespace Exam_Cell
{
    partial class Form_Room
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Panel_Header = new System.Windows.Forms.Label();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.HeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.Dgv_Rooms = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dgv_BranchPriority = new System.Windows.Forms.DataGridView();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            this.Numeric_B_Series = new System.Windows.Forms.NumericUpDown();
            this.Numeric_A_Series = new System.Windows.Forms.NumericUpDown();
            this.Textbox_TotalRoom = new System.Windows.Forms.TextBox();
            this.Textbox_TotalCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_TotalCapacity = new System.Windows.Forms.Label();
            this.Label_TotalRooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_RoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BranchPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_B_Series)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_A_Series)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.Button_Close);
            this.panel1.Controls.Add(this.Panel_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 55);
            this.panel1.TabIndex = 1;
            // 
            // Button_Close
            // 
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Image = global::Exam_Cell.Properties.Resources.cancel;
            this.Button_Close.Location = new System.Drawing.Point(937, 9);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(40, 37);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Panel_Header
            // 
            this.Panel_Header.AutoSize = true;
            this.Panel_Header.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_Header.ForeColor = System.Drawing.Color.White;
            this.Panel_Header.Location = new System.Drawing.Point(11, 14);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(61, 21);
            this.Panel_Header.TabIndex = 0;
            this.Panel_Header.Text = "Room";
            // 
            // Panel_Body
            // 
            this.Panel_Body.AllowDrop = true;
            this.Panel_Body.Controls.Add(this.HeaderCheckBox);
            this.Panel_Body.Controls.Add(this.Dgv_Rooms);
            this.Panel_Body.Controls.Add(this.Dgv_BranchPriority);
            this.Panel_Body.Controls.Add(this.Button_Update);
            this.Panel_Body.Controls.Add(this.Button_Add);
            this.Panel_Body.Controls.Add(this.Button_Delete);
            this.Panel_Body.Controls.Add(this.Numeric_B_Series);
            this.Panel_Body.Controls.Add(this.Numeric_A_Series);
            this.Panel_Body.Controls.Add(this.Textbox_TotalRoom);
            this.Panel_Body.Controls.Add(this.Textbox_TotalCapacity);
            this.Panel_Body.Controls.Add(this.label3);
            this.Panel_Body.Controls.Add(this.Label_TotalCapacity);
            this.Panel_Body.Controls.Add(this.Label_TotalRooms);
            this.Panel_Body.Controls.Add(this.label1);
            this.Panel_Body.Controls.Add(this.Textbox_RoomNo);
            this.Panel_Body.Controls.Add(this.label5);
            this.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Body.Location = new System.Drawing.Point(0, 55);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(989, 436);
            this.Panel_Body.TabIndex = 0;
            // 
            // HeaderCheckBox
            // 
            this.HeaderCheckBox.AutoSize = true;
            this.HeaderCheckBox.Location = new System.Drawing.Point(620, 6);
            this.HeaderCheckBox.Name = "HeaderCheckBox";
            this.HeaderCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HeaderCheckBox.TabIndex = 7;
            this.HeaderCheckBox.UseVisualStyleBackColor = true;
            this.HeaderCheckBox.CheckedChanged += new System.EventHandler(this.HeaderCheckBox_CheckedChanged);
            // 
            // Dgv_Rooms
            // 
            this.Dgv_Rooms.AllowUserToAddRows = false;
            this.Dgv_Rooms.AllowUserToDeleteRows = false;
            this.Dgv_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_Rooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_Rooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn});
            this.Dgv_Rooms.Location = new System.Drawing.Point(567, 3);
            this.Dgv_Rooms.Name = "Dgv_Rooms";
            this.Dgv_Rooms.RowTemplate.Height = 24;
            this.Dgv_Rooms.Size = new System.Drawing.Size(419, 429);
            this.Dgv_Rooms.TabIndex = 6;
            this.Dgv_Rooms.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Rooms_CellEndEdit);
            this.Dgv_Rooms.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Rooms_CellMouseUp);
            this.Dgv_Rooms.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_Rooms_RowHeaderMouseDoubleClick);
            this.Dgv_Rooms.DragDrop += new System.Windows.Forms.DragEventHandler(this.Dgv_Rooms_DragDrop);
            this.Dgv_Rooms.DragOver += new System.Windows.Forms.DragEventHandler(this.Dgv_Rooms_DragOver);
            this.Dgv_Rooms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dgv_Rooms_MouseDown);
            this.Dgv_Rooms.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dgv_Rooms_MouseMove);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 5;
            // 
            // Dgv_BranchPriority
            // 
            this.Dgv_BranchPriority.AllowDrop = true;
            this.Dgv_BranchPriority.AllowUserToAddRows = false;
            this.Dgv_BranchPriority.AllowUserToDeleteRows = false;
            this.Dgv_BranchPriority.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv_BranchPriority.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv_BranchPriority.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.Dgv_BranchPriority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_BranchPriority.Location = new System.Drawing.Point(3, 134);
            this.Dgv_BranchPriority.Name = "Dgv_BranchPriority";
            this.Dgv_BranchPriority.RowTemplate.Height = 24;
            this.Dgv_BranchPriority.Size = new System.Drawing.Size(563, 298);
            this.Dgv_BranchPriority.TabIndex = 8;
            this.Dgv_BranchPriority.DragDrop += new System.Windows.Forms.DragEventHandler(this.Dgv_BranchPriority_DragDrop);
            this.Dgv_BranchPriority.DragOver += new System.Windows.Forms.DragEventHandler(this.Dgv_BranchPriority_DragOver);
            this.Dgv_BranchPriority.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dgv_BranchPriority_MouseDown);
            this.Dgv_BranchPriority.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dgv_BranchPriority_MouseMove);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Update.Location = new System.Drawing.Point(172, 84);
            this.Button_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(100, 40);
            this.Button_Update.TabIndex = 4;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
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
            this.Button_Add.Location = new System.Drawing.Point(66, 84);
            this.Button_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(100, 40);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
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
            this.Button_Delete.Location = new System.Drawing.Point(278, 84);
            this.Button_Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(100, 40);
            this.Button_Delete.TabIndex = 5;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = false;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // Numeric_B_Series
            // 
            this.Numeric_B_Series.Location = new System.Drawing.Point(266, 39);
            this.Numeric_B_Series.Name = "Numeric_B_Series";
            this.Numeric_B_Series.Size = new System.Drawing.Size(63, 22);
            this.Numeric_B_Series.TabIndex = 2;
            // 
            // Numeric_A_Series
            // 
            this.Numeric_A_Series.Location = new System.Drawing.Point(95, 39);
            this.Numeric_A_Series.Name = "Numeric_A_Series";
            this.Numeric_A_Series.Size = new System.Drawing.Size(63, 22);
            this.Numeric_A_Series.TabIndex = 1;
            // 
            // Textbox_TotalRoom
            // 
            this.Textbox_TotalRoom.Location = new System.Drawing.Point(426, 40);
            this.Textbox_TotalRoom.Name = "Textbox_TotalRoom";
            this.Textbox_TotalRoom.ReadOnly = true;
            this.Textbox_TotalRoom.Size = new System.Drawing.Size(135, 22);
            this.Textbox_TotalRoom.TabIndex = 24;
            // 
            // Textbox_TotalCapacity
            // 
            this.Textbox_TotalCapacity.Location = new System.Drawing.Point(426, 88);
            this.Textbox_TotalCapacity.Name = "Textbox_TotalCapacity";
            this.Textbox_TotalCapacity.ReadOnly = true;
            this.Textbox_TotalCapacity.Size = new System.Drawing.Size(135, 22);
            this.Textbox_TotalCapacity.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "B Series :";
            // 
            // Label_TotalCapacity
            // 
            this.Label_TotalCapacity.AutoSize = true;
            this.Label_TotalCapacity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalCapacity.Location = new System.Drawing.Point(423, 68);
            this.Label_TotalCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TotalCapacity.Name = "Label_TotalCapacity";
            this.Label_TotalCapacity.Size = new System.Drawing.Size(101, 17);
            this.Label_TotalCapacity.TabIndex = 22;
            this.Label_TotalCapacity.Text = "Total Capacity :";
            // 
            // Label_TotalRooms
            // 
            this.Label_TotalRooms.AutoSize = true;
            this.Label_TotalRooms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalRooms.Location = new System.Drawing.Point(423, 20);
            this.Label_TotalRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TotalRooms.Name = "Label_TotalRooms";
            this.Label_TotalRooms.Size = new System.Drawing.Size(80, 17);
            this.Label_TotalRooms.TabIndex = 22;
            this.Label_TotalRooms.Text = "Total Room :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "A Series :";
            // 
            // Textbox_RoomNo
            // 
            this.Textbox_RoomNo.Location = new System.Drawing.Point(95, 6);
            this.Textbox_RoomNo.Name = "Textbox_RoomNo";
            this.Textbox_RoomNo.Size = new System.Drawing.Size(234, 22);
            this.Textbox_RoomNo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Room No :";
            // 
            // Form_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(989, 491);
            this.Controls.Add(this.Panel_Body);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Room";
            this.Load += new System.EventHandler(this.Form_Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_Body.ResumeLayout(false);
            this.Panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Rooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BranchPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_B_Series)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_A_Series)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Panel_Header;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel Panel_Body;
        private System.Windows.Forms.NumericUpDown Numeric_B_Series;
        private System.Windows.Forms.NumericUpDown Numeric_A_Series;
        private System.Windows.Forms.TextBox Textbox_TotalCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_TotalRooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_RoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Textbox_TotalRoom;
        private System.Windows.Forms.Label Label_TotalCapacity;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
        private System.Windows.Forms.DataGridView Dgv_Rooms;
        private System.Windows.Forms.DataGridView Dgv_BranchPriority;
        private System.Windows.Forms.CheckBox HeaderCheckBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
    }
}