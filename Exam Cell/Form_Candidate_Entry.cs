﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
            Dgv_Students.DataSource = null;
            if (Radio_University.Checked)
            {
                Textbox_ExcelFilepath.ResetText();
                Combobox_ExcelSheets.SelectedItem = null;
                Button_Register_University.Enabled = false;
                Combobox_Branch_Cand_Register.SelectedIndex = 0;
                Textbox_Yoa_SearchCand.ResetText();
            }
            else Combobox_Class.SelectedIndex = 0;
            isFormReset = false;
            SetLoading(false);
        }

        void SetLoading(bool loading)
        {
            if (loading)
            {
                Panel_Body.Enabled = false;
                Panel_ProgressBar.BringToFront();
            }
            else
            {
                Panel_Body.Enabled = true;
                Panel_ProgressBar.SendToBack();
            }
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

        // Register from Excel Sheet event --- Start
        DataTableCollection tableCollection;
        private void Button_Select_ExcelFile_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox(" ExcelSheet must only contains Table data.  \n ExcelSheet Header Naming Must Be as follows and    \n exact ordering not required :  \n RegisterNo ,Name, Semester, Branch, Course  ", "Warning", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Warning);
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Excel Files|*.xls|*xlsx|*.xlsm" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Textbox_ExcelFilepath.Text = openFile.FileName;  //Filepath_textbox.Text --- filepath is displayed in textbox
                    using (var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            Combobox_ExcelSheets.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                Combobox_ExcelSheets.Items.Add(table.TableName); //add sheets to combobox
                        }
                    }
                }
            }
        }

        private void Combobox_ExcelSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combobox_ExcelSheets.SelectedItem != null)
            {
                DataTable dt = tableCollection[Combobox_ExcelSheets.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<Class_Reg_University_Students_Excel> excst = new List<Class_Reg_University_Students_Excel>(); //<--here ExcelStudents is class name
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Class_Reg_University_Students_Excel excclass = new Class_Reg_University_Students_Excel();
                        excclass.Name = dt.Rows[i]["Name"].ToString();  //have to give Excel column names inside the[""]
                        excclass.Reg_No = dt.Rows[i]["RegisterNo"].ToString();
                        excclass.Branch = dt.Rows[i]["Branch"].ToString();
                        excclass.Semester = dt.Rows[i]["Semester"].ToString();
                        excclass.Course = dt.Rows[i]["Course"].ToString();

                        excst.Add(excclass);
                    }
                    Dgv_Students.DataSource = excst;
                    Button_Register_University.Enabled = true;
                }
            }
        }

        void Register_University_Students_From_ExcelSheet()
        {
            CustomMessageBox.ShowMessageBox("Are you sure to Register Students from selected excel sheet ?   ", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        string query = string.Format("Insert into University_Candidates(Name,Reg_No,Branch,Semester,Course)Values(" + "@Name,@Reg_No,@Branch,@Semester,@Course)");
                        SQLiteCommand sqlcomm = new SQLiteCommand(query, dbConnection);
                        foreach (DataGridViewRow dr in Dgv_Students.Rows)
                        {
                            sqlcomm.Parameters.AddWithValue("@Reg_No", dr.Cells["Reg_No"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Name", dr.Cells["Name"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Branch", dr.Cells["Branch"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Semester", dr.Cells["Semester"].Value.ToString());
                            sqlcomm.Parameters.AddWithValue("@Course", dr.Cells["Course"].Value.ToString());
                            sqlcomm.ExecuteNonQuery();
                        }
                    }
                    ResetForm();
                    CustomMessageBox.ShowMessageBox("University candidates registered  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Button_Register_ExcelSheet_Click(object sender, EventArgs e)
        {
            SetLoading(true);
            Register_University_Students_From_ExcelSheet();
        }
    }
}
