namespace Exam_Cell
{
    partial class Form_Message_Box
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
            this.PictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Button_No = new System.Windows.Forms.Button();
            this.Button_Yes = new System.Windows.Forms.Button();
            this.Button_Ok = new System.Windows.Forms.Button();
            this.Label_Message = new System.Windows.Forms.Label();
            this.Panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Header
            // 
            this.Panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.Panel_Header.Controls.Add(this.PictureBox_Icon);
            this.Panel_Header.Controls.Add(this.Label_Title);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(0, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(475, 55);
            this.Panel_Header.TabIndex = 2;
            // 
            // PictureBox_Icon
            // 
            this.PictureBox_Icon.Location = new System.Drawing.Point(12, 9);
            this.PictureBox_Icon.Name = "PictureBox_Icon";
            this.PictureBox_Icon.Size = new System.Drawing.Size(43, 37);
            this.PictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Icon.TabIndex = 6;
            this.PictureBox_Icon.TabStop = false;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.ForeColor = System.Drawing.Color.White;
            this.Label_Title.Location = new System.Drawing.Point(63, 17);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(44, 21);
            this.Label_Title.TabIndex = 0;
            this.Label_Title.Text = "Title";
            // 
            // Button_No
            // 
            this.Button_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_No.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_No.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_No.Location = new System.Drawing.Point(363, 157);
            this.Button_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_No.Name = "Button_No";
            this.Button_No.Padding = new System.Windows.Forms.Padding(5);
            this.Button_No.Size = new System.Drawing.Size(100, 40);
            this.Button_No.TabIndex = 1;
            this.Button_No.Text = "No";
            this.Button_No.UseVisualStyleBackColor = false;
            this.Button_No.Click += new System.EventHandler(this.Button_No_Click);
            // 
            // Button_Yes
            // 
            this.Button_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Yes.FlatAppearance.BorderSize = 0;
            this.Button_Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.Button_Yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.Button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Yes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Yes.Location = new System.Drawing.Point(250, 157);
            this.Button_Yes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Yes.Name = "Button_Yes";
            this.Button_Yes.Padding = new System.Windows.Forms.Padding(5);
            this.Button_Yes.Size = new System.Drawing.Size(100, 40);
            this.Button_Yes.TabIndex = 0;
            this.Button_Yes.Text = "Yes";
            this.Button_Yes.UseVisualStyleBackColor = false;
            this.Button_Yes.Click += new System.EventHandler(this.Button_Yes_Click);
            // 
            // Button_Ok
            // 
            this.Button_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Button_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.Button_Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Ok.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.Button_Ok.Location = new System.Drawing.Point(363, 157);
            this.Button_Ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Padding = new System.Windows.Forms.Padding(5);
            this.Button_Ok.Size = new System.Drawing.Size(100, 40);
            this.Button_Ok.TabIndex = 2;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = false;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // Label_Message
            // 
            this.Label_Message.AutoSize = true;
            this.Label_Message.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Message.Location = new System.Drawing.Point(54, 90);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(279, 20);
            this.Label_Message.TabIndex = 44;
            this.Label_Message.Text = "Do you want to exit the application ?";
            // 
            // Form_Message_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(475, 210);
            this.Controls.Add(this.Button_Yes);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.Label_Message);
            this.Controls.Add(this.Panel_Header);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1200, 720);
            this.MinimumSize = new System.Drawing.Size(475, 210);
            this.Name = "Form_Message_Box";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Message_Box";
            this.Panel_Header.ResumeLayout(false);
            this.Panel_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Button Button_No;
        private System.Windows.Forms.Button Button_Yes;
        private System.Windows.Forms.Button Button_Ok;
        private System.Windows.Forms.PictureBox PictureBox_Icon;
        private System.Windows.Forms.Label Label_Message;
    }
}