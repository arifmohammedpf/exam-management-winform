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

        private void Label_Copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://arifmohammed.netlify.app/");
        }
        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuBorder  // for changing the menu border
            {
                get { return Color.FromArgb(36, 33, 50); }
            }

            public override Color MenuItemBorder  // for changing the menu items hover border
            {
                get { return Color.FromArgb(36, 33, 50); }
            }

            public override Color ToolStripDropDownBackground  // for changing the menu dropdown border
            {
                get { return Color.FromArgb(36, 33, 50); }
            }

            // for changing the menu items hover (Gradient)
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(37, 34, 51); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(16, 13, 30); }
            }

            // for changing the menu items clicked state (Gradient)
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(37, 34, 51); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(26, 23, 40); }
            }

            // for changing the menu dropdown items hover
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(16, 13, 30); }
            }
        }
        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            // render custom colors
            MenuStrip.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }
    }
}
