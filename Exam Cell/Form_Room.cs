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
    public partial class Form_Room : Form
    {
        public Form_Room()
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

        void DgvFill()
        {
            Dgv_BranchPriority.DataSource = null;
            Dgv_Rooms.DataSource = null;
            HeaderCheckBox.Checked = false; // will this bring error ???

            string Rooms_query = "Select * from Rooms";
            string Branch_query = "Select * from Branch_Priority";
            string A_Series_Capacity, B_Series_Capacity;
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                SQLiteCommand Roomscommand, Branchcommand, ASeriesCommand, BSeriesCommand;
                // Rooms
                Roomscommand = new SQLiteCommand(Rooms_query, dbConnection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Roomscommand);
                DataTable RoomsRecord = new DataTable();
                dataAdapter.Fill(RoomsRecord);
                Dgv_Rooms.DataSource = RoomsRecord;

                // Branch Priority
                Branchcommand = new SQLiteCommand(Branch_query, dbConnection);
                SQLiteDataAdapter BranchdataAdapter = new SQLiteDataAdapter(Branchcommand);
                DataTable BranchRecord = new DataTable();
                BranchdataAdapter.Fill(BranchRecord);
                Dgv_BranchPriority.DataSource = BranchRecord;

                // A_Series Capacity Fill
                ASeriesCommand = new SQLiteCommand("Select Sum(A_Series) from Rooms",dbConnection);
                A_Series_Capacity = ASeriesCommand.ExecuteScalar().ToString();
                // B_Series Capacity Fill
                BSeriesCommand = new SQLiteCommand("Select Sum(B_Series) from Rooms", dbConnection);
                B_Series_Capacity = BSeriesCommand.ExecuteScalar().ToString();
            }

            Label_TotalRooms.Text = "Rooms : " + Dgv_Rooms.Rows.Count.ToString();
            Label_TotalCapacity.Text = "Capacity : A - " + A_Series_Capacity + " B - " + B_Series_Capacity;
            // try testing msgbox here for checking tryCatch
        }
        void ResetForm()
        {
            DgvFill();
            Textbox_RoomNo.Clear();
            Numeric_A_Series.ResetText();
            Numeric_B_Series.ResetText();
            this.Enabled = true; // enabling Form
            // try testing msgbox here for checking tryCatch
        }
        
        private void Form_Room_Load(object sender, EventArgs e)
        {
            try
            {
                ResetForm();
                // try testing msgbox here for checking tryCatch
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HeaderCheckBox.Checked)
            {
                foreach (DataGridViewRow row in Dgv_Rooms.Rows)
                {
                    row.Cells["CheckBoxColumn"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in Dgv_Rooms.Rows)
                {
                    row.Cells["CheckBoxColumn"].Value = false;
                }
            }
        }
    }
}

// // // TESTING // // //
// * make error in ResetForm function to check if tryCatch work and exit Form Load function... use msgbox in each function
