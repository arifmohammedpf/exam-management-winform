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
    public partial class Form_SplashScreen : Form
    {
        public Form_SplashScreen()
        {
            InitializeComponent();
        }

        int loadingTime = 100;
        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            loadingTime -= 5;
            if (loadingTime <= 0)
            {
                LoadTimer.Stop();
                FadeTimer.Start();
            }
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.025;
            else
            {
                FadeTimer.Stop();
                Form_MainMenu form_MainMenu = new Form_MainMenu();
                form_MainMenu.Show();
                this.Hide();
            }
        }
    }
}
