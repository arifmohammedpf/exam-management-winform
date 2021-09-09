using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
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

        Form_Message_Box CustomMessageBox = new Form_Message_Box();

        // getting connection string from app.config
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Form_Candidate_Entry_Load(object sender, EventArgs e)
        {
            Radio_University.Checked = true;
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    TabControl.TabPages.Insert(0, Tab_Excel_Import);
        //    this.Tab_Excel_Import.Show();
        //    TabControl.SelectedTab = Tab_Excel_Import;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    TabControl.TabPages.Remove(Tab_Excel_Import);
        //    this.Tab_Excel_Import.Hide();

        //}

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Radio_University_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(Tab_Series_Search);
            TabControl.TabPages.Insert(0, Tab_Excel_Import);
            TabControl.TabPages.Insert(1, Tab_Univeristy_Search);
            TabControl.SelectedTab = Tab_Excel_Import;
            ResetForm();
        }

        private void Radio_Series_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.TabPages.Remove(Tab_Excel_Import);
            TabControl.TabPages.Remove(Tab_Univeristy_Search);
            TabControl.TabPages.Insert(0,Tab_Series_Search);
            TabControl.SelectedTab = Tab_Series_Search;
            ResetForm();
        }

        bool isFormReset = false;
        void ResetForm()
        {
            isFormReset = true;
            HeaderCheckBox.Checked = false;
            Textbox_ExtraCand_Name.ResetText();
            Textbox_ExtraCand_RegNo.ResetText();
            Dgv_Course.DataSource = null;
            Dgv_Students.DataSource = null;
            Combobox_Scheme.SelectedIndex = 0;
            Combobox_Branch_SchemeSearch.SelectedIndex = 0;
            Combobox_Semester.SelectedIndex = 0;
            if (Radio_University.Checked)
            {
                Textbox_ExcelFilepath.ResetText();
                Combobox_ExcelSheets.DataSource = null;
                Combobox_Branch_Cand_Register.SelectedIndex = 0;
                Textbox_Yoa_SearchCand.ResetText();
            }
            else Combobox_Class.SelectedIndex = 0;
            isFormReset = false;
        }
                
        // Checkbox click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void Dgv_Students_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Students.Columns["CheckBoxColumn_Students"].Index)
                Dgv_Students.EndEdit();
        }

        private void Dgv_Students_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Students.Columns["CheckBoxColumn_Students"].Index)
            {
                if (HeaderCheckBox.Checked)
                {
                    isCheckBoxColumn_ClickedEvent = true;
                    HeaderCheckBox.Checked = false;
                }
            }
        }

        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isCheckBoxColumn_ClickedEvent || !isFormReset)
            {
                if (HeaderCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in Dgv_Students.Rows)
                    {
                        row.Cells["CheckBoxColumn_Students"].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in Dgv_Students.Rows)
                    {
                        row.Cells["CheckBoxColumn_Students"].Value = false;
                    }
                }
            }

            isCheckBoxColumn_ClickedEvent = false;
        }

        void SearchCourses()
        {
            if (!isFormReset)
            {
                string scheme = Combobox_Branch_SchemeSearch.SelectedItem.ToString();
                string branch = Combobox_Branch_SchemeSearch.SelectedItem.ToString();
                string semester = Combobox_Semester.SelectedItem.ToString();
                Dgv_Course.DataSource = null;

                string searchRecord = "";

                if (scheme != "-Select-")
                    searchRecord = string.Format("Scheme like '%{0}%'", scheme);
                if (branch != "")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Branch Like '%{0}%'", branch);
                }
                if (semester != "-Select-")
                {
                    if (searchRecord.Length > 0) searchRecord += " AND ";
                    searchRecord += string.Format("Semester Like '%{0}%'", semester);
                }
                if (searchRecord != "")
                {
                    string query = "Select * from Scheme where " + searchRecord;
                    DataTable courseTable;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                        courseTable = new DataTable();
                        dataAdapter.Fill(courseTable);
                    }
                    Dgv_Course.DataSource = courseTable;
                }
            }
        }

        private void Combobox_Scheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCourses();
        }

        private void Combobox_Branch_SchemeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCourses();
        }

        private void Combobox_Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCourses();
        }
    }
}
