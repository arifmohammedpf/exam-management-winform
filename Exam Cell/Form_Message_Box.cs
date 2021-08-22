using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Cell
{
    public partial class Form_Message_Box : Form
    {
        public Form_Message_Box()
        {
            InitializeComponent();
        }

        //COPY BELOW CODE TO CALL THIS CUSTOM MESSAGE BOX IN FORMS !
        //Form_Message_Box messageBox = new Form_Message_Box();
        //messageBox.ShowMessageBox("Message", "Title", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Error);
        //var result = messageBox.UserChoice;

        public enum MessageBoxButtons
        {
            OK = 0, YesNo = 1
        };
        public enum MessageBoxIcon
        {
            Information = 0, Warning = 1, Error = 2, Question = 3
        };
        public string UserChoice { get; set; }
        public void ShowMessageBox(string message, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            Label_Message.Text = "";
            Label_Title.Text = "";
            Label_Message.Text = message;
            Label_Title.Text = title;

            if (MessageBoxButtons.OK == button)
            {
                Button_Ok.Visible = true;
                Button_Yes.Visible = false;
                Button_No.Visible = false;
            }
            else if (MessageBoxButtons.YesNo == button)
            {
                Button_Ok.Visible = false;
                Button_Yes.Visible = true;
                Button_No.Visible = true;
            }

            if (MessageBoxIcon.Error == icon)
            {
                PictureBox_Icon.Image = SystemIcons.Error.ToBitmap();
            }
            else if (MessageBoxIcon.Information == icon)
            {
                PictureBox_Icon.Image = SystemIcons.Information.ToBitmap();
            }
            else if (MessageBoxIcon.Warning == icon)
            {
                PictureBox_Icon.Image = SystemIcons.Warning.ToBitmap();
            }
            else if (MessageBoxIcon.Question == icon)
            {
                PictureBox_Icon.Image = SystemIcons.Question.ToBitmap();
            }

            this.ShowDialog();
        }
        private void Button_Yes_Click(object sender, EventArgs e)
        {
            UserChoice = "Yes";
            this.Hide();
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            UserChoice = "No";
            this.Hide();
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            UserChoice = "Ok";
            this.Hide();
        }
    }
}
