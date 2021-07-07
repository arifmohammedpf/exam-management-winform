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
    public partial class Form_Candidate_Entry : Form
    {
        public Form_Candidate_Entry()
        {
            InitializeComponent();
        }

        private void Form_Candidate_Entry_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.TabPages.Insert(0, Tab_Excel_Import);
            this.Tab_Excel_Import.Show();
            TabControl.SelectedTab = Tab_Excel_Import;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(Tab_Excel_Import);
            this.Tab_Excel_Import.Hide();

        }
    }
}
