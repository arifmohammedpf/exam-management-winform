﻿using System;
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

        private void Menu_item_candidate_entry_Click(object sender, EventArgs e)
        {
            Form_Candidate_Entry form_Candidate_Entry = new Form_Candidate_Entry();
            form_Candidate_Entry.ShowDialog();
        }

        private void Menu_item_room_Click(object sender, EventArgs e)
        {
            Form_Room form_Room = new Form_Room();
            form_Room.ShowDialog();
        }

        private void Menu_item_reg_stud_mgmt_Click(object sender, EventArgs e)
        {
            Form_Reg_Student_Mgmt form_Reg_Student_Mgmt = new Form_Reg_Student_Mgmt();
            form_Reg_Student_Mgmt.ShowDialog();
        }

        private void Menu_item_allotment_Click(object sender, EventArgs e)
        {
            Form_Allotment form_Allotment = new Form_Allotment();
            form_Allotment.ShowDialog();
        }

        private void Menu_item_absentees_Click(object sender, EventArgs e)
        {
            Form_Absentees form_Absentees = new Form_Absentees();
            form_Absentees.ShowDialog();
        }

        private void Menu_item_postponement_Click(object sender, EventArgs e)
        {
            Form_Postponement form_Postponement = new Form_Postponement();
            form_Postponement.ShowDialog();
        }

        private void Menu_item_database_mgmt_Click(object sender, EventArgs e)
        {
            Form_Database_Management form_Database_Management = new Form_Database_Management();
            form_Database_Management.ShowDialog();
        }

        private void Menu_item_credits_Click(object sender, EventArgs e)
        {
            Form_Credits form_Credits = new Form_Credits();
            form_Credits.ShowDialog();
        }

        private void Label_Copyright_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://arifmohammed.netlify.app/");
        }
    }
}