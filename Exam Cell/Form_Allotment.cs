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
    public partial class Form_Allotment : Form
    {
        public Form_Allotment()
        {
            InitializeComponent();
        }

        Form_Message_Box CustomMessageBox = new Form_Message_Box();

        // getting connection string from app.config
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SearchRegisteredCandidates()
        {
            try
            {
                Dgv_RegCandidates_List.DataSource = null;
                string query;
                if (Radio_University.Checked) query = string.Format("Select * from University_Candidates where Course in ( Select Course from Timetable where Date=@Date and Session=@Session)");
                else query = string.Format("Select * from Series_Candidates where Course in ( Select Course from Timetable where Date=@Date and Session=@Session)");
                using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                {
                    SQLiteCommand comm = new SQLiteCommand(query, dbConnection);
                    comm.Parameters.AddWithValue("@Date", DateTimePicker_Date.Text);
                    comm.Parameters.AddWithValue("@Session", Combobox_Session.SelectedItem.ToString());
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(comm);
                    DataTable studentRecords = new DataTable();
                    dataAdapter.Fill(studentRecords);
                    Dgv_RegCandidates_List.DataSource = studentRecords;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {
            if(Combobox_Session.SelectedIndex != 0)
            {
                SearchRegisteredCandidates();
            }
        }

        private void Combobox_Session_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_Session.SelectedIndex != 0)
            {
                SearchRegisteredCandidates();
            }
        }
    }
}
