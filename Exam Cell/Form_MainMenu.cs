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
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
        }
        
        // Menu Strip customize
        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuBorder  //added for changing the menu border
            {
                get { return Color.FromArgb(36,33,50); }
            }

            public override Color MenuItemBorder  //added for changing the menu items hover border
            {
                get { return Color.FromArgb(36,33,50); }
            }

            public override Color ToolStripDropDownBackground  //added for changing the menu dropdown border
            {
                get { return Color.FromArgb(36,33,50); }
            }

            //added for changing the menu items hover
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(37, 34, 51); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(16, 13, 30); }
            }

            //added for changing the menu items clicked state
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(26, 23, 40); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(26, 23, 40); }
            }

            //added for changing the menu dropdown items hover
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(16, 13, 30); }
            }
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            MenuStrip.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        private void Menu_item_timetable_Click(object sender, EventArgs e)
        {
            Form_Timetable form_Timetable = new Form_Timetable();
            form_Timetable.ShowDialog();
        }
    }
}