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

        private void Form_MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Timetable_Click(object sender, EventArgs e)
        {
            using (Form_Timetable form_Timetable = new Form_Timetable())
            {
                form_Timetable.ShowDialog();
            }
        }

        private void Button_CandidateEntry_Click(object sender, EventArgs e)
        {
            using (Form_Candidate_Entry form_Candidate_Entry = new Form_Candidate_Entry())
                form_Candidate_Entry.ShowDialog();
        }

        private void Button_Room_Click(object sender, EventArgs e)
        {
            using (Form_Room form_Room = new Form_Room())
                form_Room.ShowDialog();
        }

        private void Button_RegStudMgmt_Click(object sender, EventArgs e)
        {
            using (Form_Reg_Student_Mgmt form_Reg_Student_Mgmt = new Form_Reg_Student_Mgmt())
                form_Reg_Student_Mgmt.ShowDialog();
        }

        private void Button_Allotment_Click(object sender, EventArgs e)
        {
            using (Form_Allotment form_Allotment = new Form_Allotment())
                form_Allotment.ShowDialog();
        }

        private void Button_Absentees_Click(object sender, EventArgs e)
        {
            using (Form_Absentees form_Absentees = new Form_Absentees())
                form_Absentees.ShowDialog();
        }

        private void Button_Postponement_Click(object sender, EventArgs e)
        {
            using (Form_Postponement form_Postponement = new Form_Postponement())
                form_Postponement.ShowDialog();
        }

        private void Button_DatabaseMgmt_Click(object sender, EventArgs e)
        {
            using (Form_Database_Management form_Database_Management = new Form_Database_Management())
                form_Database_Management.ShowDialog();
        }

        private void Button_Credits_Click(object sender, EventArgs e)
        {
            using (Form_Credits form_Credits = new Form_Credits())
                form_Credits.ShowDialog();
        }
    }
}