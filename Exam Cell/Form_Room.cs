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

        DataTable RoomsRecord, BranchRecord;
        void DgvFill()
        {
            Dgv_BranchPriority.DataSource = null;
            Dgv_Rooms.DataSource = null;            

            string Rooms_query = "Select * from Rooms order by Priority";
            string Branch_query = "Select * from Branch_Priority order by Priority";
            
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand Roomscommand, Branchcommand;
                // Rooms
                Roomscommand = new SQLiteCommand(Rooms_query, dbConnection);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Roomscommand);
                RoomsRecord = new DataTable();
                dataAdapter.Fill(RoomsRecord);
                Dgv_Rooms.DataSource = RoomsRecord;

                // Branch Priority
                Branchcommand = new SQLiteCommand(Branch_query, dbConnection);
                SQLiteDataAdapter BranchdataAdapter = new SQLiteDataAdapter(Branchcommand);
                BranchRecord = new DataTable();
                BranchdataAdapter.Fill(BranchRecord);
                Dgv_BranchPriority.DataSource = BranchRecord;
            }

            HeaderCheckBox.Checked = false;
            // try testing msgbox here for checking tryCatch
        }
        void ResetForm()
        {
            DgvFill();
            Textbox_RoomNo.Clear();
            Numeric_A_Series.ResetText();
            Numeric_B_Series.ResetText();
            selectedRoomNo = "";
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

        void Fill_Full_Room_capacity()
        {
            string A_Series_Capacity, B_Series_Capacity;
            using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                dbConnection.Open();
                SQLiteCommand ASeriesCommand, BSeriesCommand;

                // A_Series Capacity Fill
                ASeriesCommand = new SQLiteCommand("Select Sum(A_Series) from Rooms", dbConnection);
                A_Series_Capacity = ASeriesCommand.ExecuteScalar().ToString();

                // B_Series Capacity Fill
                BSeriesCommand = new SQLiteCommand("Select Sum(B_Series) from Rooms", dbConnection);
                B_Series_Capacity = BSeriesCommand.ExecuteScalar().ToString();
            }
            Label_TotalRooms.Text = "Rooms : " + Dgv_Rooms.Rows.Count.ToString();
            Label_TotalCapacity.Text = "Capacity : A - " + A_Series_Capacity + " B - " + B_Series_Capacity;
        }

        // when headerCheckbox state change event triggers we need to make sure it is not triggered from Dgv CheckBox Click event
        bool isCheckBoxColumn_ClickedEvent = false;
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // no need to fill full capacity and check/uncheck all checkboxes for 'dgv checkBoxColumn click event'
            if (!isCheckBoxColumn_ClickedEvent)
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
                Fill_Full_Room_capacity();
            }                

            isCheckBoxColumn_ClickedEvent = false;
        }

        // Events to Update capacity when checkbox is clicked --- Start
        void Fill_Selected_Room_capacity()
        {
            if (HeaderCheckBox.Checked)
            {
                isCheckBoxColumn_ClickedEvent = true;
                HeaderCheckBox.Checked = false;
            }

            int a, b, A_Series_Capacity = 0, B_Series_Capacity = 0, Room_count = 0;
            foreach (DataGridViewRow dr in Dgv_Rooms.Rows)
            {
                bool chckselected = Convert.ToBoolean(dr.Cells["CheckBoxColumn"].Value);
                if (chckselected)
                {
                    Room_count += 1;
                    a = int.Parse(dr.Cells["A_Series"].Value.ToString());
                    b = int.Parse(dr.Cells["B_Series"].Value.ToString());
                    A_Series_Capacity += a;
                    B_Series_Capacity += b;
                }
            }

            Label_TotalRooms.Text = "Rooms : " + Room_count.ToString();
            Label_TotalCapacity.Text = "Capacity : A - " + A_Series_Capacity + " B - " + B_Series_Capacity;
        }

        private void Dgv_Rooms_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Rooms.Columns["CheckBoxColumn"].Index)
                Dgv_Rooms.EndEdit();
        }

        private void Dgv_Rooms_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Dgv_Rooms.Columns["CheckBoxColumn"].Index)
                Fill_Selected_Room_capacity();
        }
        // Events to Update capacity when checkbox is clicked --- End

        string selectedRoomNo;
        private void Dgv_Rooms_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // fill the form
            Textbox_RoomNo.Text = Dgv_Rooms.CurrentRow.Cells["Room_No"].Value.ToString();
            Numeric_A_Series.Value = int.Parse(Dgv_Rooms.CurrentRow.Cells["A_Series"].Value.ToString());
            Numeric_B_Series.Value = int.Parse(Dgv_Rooms.CurrentRow.Cells["B_Series"].Value.ToString());

            // selected Room to be updated
            selectedRoomNo= Dgv_Rooms.CurrentRow.Cells["Room_No"].Value.ToString();
        }

        // Drag and Drop rows event to change Room priority --- Start
        private Rectangle dragBoxFromMouseDown_Room;
        private int rowIndexFromMouseDown_Room;
        private int rowIndexOfItemUnderMouseToDrop_Room = 0;
        private void Dgv_Rooms_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown_Room = Dgv_Rooms.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown_Room != -1)
            {
                // Remember the point where the mouse down occurred.
                // The DragSize indicates the size that the mouse can move
                // before a drag event should be started.               
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown_Room = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown_Room = Rectangle.Empty;
            }
        }

        private void Dgv_Rooms_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown_Room != Rectangle.Empty && !dragBoxFromMouseDown_Room.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                   
                    DragDropEffects dropEffect = Dgv_Rooms.DoDragDrop(Dgv_Rooms.Rows[rowIndexFromMouseDown_Room], DragDropEffects.Move);
                }
            }
        }

        private void Dgv_Rooms_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            //autoScroll
            if (e.Y <= PointToScreen(new Point(Dgv_Rooms.Location.X, Dgv_Rooms.Location.Y)).Y + 50)
                if (Dgv_Rooms.FirstDisplayedScrollingRowIndex != 0)
                {
                    Dgv_Rooms.FirstDisplayedScrollingRowIndex -= 1;
                }
            if (e.Y >= PointToScreen(new Point(Dgv_Rooms.Location.X + Dgv_Rooms.Width, Dgv_Rooms.Location.Y + Dgv_Rooms.Height)).Y - 5)
                Dgv_Rooms.FirstDisplayedScrollingRowIndex += 1;
        }        

        private void Dgv_Rooms_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                // The mouse locations are relative to the screen, so they must be
                // converted to client coordinates.
                Point clientPoint = Dgv_Rooms.PointToClient(new Point(e.X, e.Y));

                // Get the row index of the item the mouse is below.
                rowIndexOfItemUnderMouseToDrop_Room = Dgv_Rooms.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

                // If the drag operation was a move then remove and insert the row.
                if (e.Effect == DragDropEffects.Move)
                {
                    if (rowIndexOfItemUnderMouseToDrop_Room != -1)
                    {
                        DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                        // find the row to move in the datasource:
                        DataRow oldrow = ((DataRowView)rowToMove.DataBoundItem).Row;
                        // clone it:
                        DataRow newrow = RoomsRecord.NewRow();
                        newrow.ItemArray = oldrow.ItemArray;

                        RoomsRecord.Rows.Remove(oldrow);
                        RoomsRecord.Rows.InsertAt(newrow, rowIndexOfItemUnderMouseToDrop_Room);

                        //if (rowToMove.Index < 0)
                        //{
                        //    return;
                        //}
                        //if (rowIndexFromMouseDown_Room < rowIndexOfItemUnderMouseToDrop_Room)
                        //{
                        //    table_roomPriority.Rows.InsertAt(newrow, rowIndexOfItemUnderMouseToDrop_Room - 1);
                        //    table_roomPriority.Rows.Remove(oldrow);
                        //}
                        //else if (rowIndexFromMouseDown_Room > rowIndexOfItemUnderMouseToDrop_Room)
                        //{
                        //    table_roomPriority.Rows.InsertAt(newrow, rowIndexOfItemUnderMouseToDrop_Room);
                        //    table_roomPriority.Rows.Remove(oldrow);
                        //}

                        //loop through dgv and set priority manually
                        int set_priority = 1;
                        foreach (DataGridViewRow row in Dgv_Rooms.Rows)
                        {
                            row.Cells["Priority"].Value = set_priority;
                            set_priority++;
                        }

                        // save to db
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            dbConnection.Open();
                            //RoomsRecord.AcceptChanges();      // do we need this???
                            SQLiteCommand command = new SQLiteCommand("Select * from Rooms", dbConnection);
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                            //adapter.AcceptChangesDuringUpdate = true;     // do we need this???
                            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                            adapter.Update(RoomsRecord);                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Drag and Drop rows event to change Room priority --- End

        // Drag and Drop rows event to change Branch priority --- Start
        private Rectangle dragBoxFromMouseDown_BranchPriority;
        private int rowIndexFromMouseDown_BranchPriority;
        private int rowIndexOfItemUnderMouseToDrop_BranchPriority= 0;
        private void Dgv_BranchPriority_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown_BranchPriority= Dgv_BranchPriority.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown_BranchPriority!= -1)
            {
                // Remember the point where the mouse down occurred.
                // The DragSize indicates the size that the mouse can move
                // before a drag event should be started.               
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown_BranchPriority= new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown_BranchPriority= Rectangle.Empty;
            }
        }

        private void Dgv_BranchPriority_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown_BranchPriority!= Rectangle.Empty && !dragBoxFromMouseDown_BranchPriority.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                   
                    DragDropEffects dropEffect = Dgv_BranchPriority.DoDragDrop(Dgv_BranchPriority.Rows[rowIndexFromMouseDown_BranchPriority], DragDropEffects.Move);
                }
            }
        }

        private void Dgv_BranchPriority_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            //autoScroll
            if (e.Y <= PointToScreen(new Point(Dgv_BranchPriority.Location.X, Dgv_BranchPriority.Location.Y)).Y + 50)
                if (Dgv_BranchPriority.FirstDisplayedScrollingRowIndex != 0)
                {
                    Dgv_BranchPriority.FirstDisplayedScrollingRowIndex -= 1;
                }
            if (e.Y >= PointToScreen(new Point(Dgv_BranchPriority.Location.X + Dgv_BranchPriority.Width, Dgv_BranchPriority.Location.Y + Dgv_BranchPriority.Height)).Y - 5)
                Dgv_BranchPriority.FirstDisplayedScrollingRowIndex += 1;
        }

        private void Dgv_BranchPriority_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                // The mouse locations are relative to the screen, so they must be
                // converted to client coordinates.
                Point clientPoint = Dgv_BranchPriority.PointToClient(new Point(e.X, e.Y));

                // Get the row index of the item the mouse is below.
                rowIndexOfItemUnderMouseToDrop_BranchPriority= Dgv_BranchPriority.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

                // If the drag operation was a move then remove and insert the row.
                if (e.Effect == DragDropEffects.Move)
                {
                    if (rowIndexOfItemUnderMouseToDrop_BranchPriority!= -1)
                    {
                        DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                        // find the row to move in the datasource:
                        DataRow oldrow = ((DataRowView)rowToMove.DataBoundItem).Row;
                        // clone it:
                        DataRow newrow = BranchRecord.NewRow();
                        newrow.ItemArray = oldrow.ItemArray;

                        BranchRecord.Rows.Remove(oldrow);
                        BranchRecord.Rows.InsertAt(newrow, rowIndexOfItemUnderMouseToDrop_BranchPriority);

                        //if (rowToMove.Index < 0)
                        //{
                        //    return;
                        //}
                        //if (rowIndexFromMouseDown_Room < rowIndexOfItemUnderMouseToDrop_Room)
                        //{
                        //    table_roomPriority.Rows.InsertAt(newrow, rowIndexOfItemUnderMouseToDrop_Room - 1);
                        //    table_roomPriority.Rows.Remove(oldrow);
                        //}
                        //else if (rowIndexFromMouseDown_Room > rowIndexOfItemUnderMouseToDrop_Room)
                        //{
                        //    table_roomPriority.Rows.InsertAt(newrow, rowIndexOfItemUnderMouseToDrop_Room);
                        //    table_roomPriority.Rows.Remove(oldrow);
                        //}

                        //loop through dgv and set priority manually
                        int set_priority = 1;
                        foreach (DataGridViewRow row in Dgv_BranchPriority.Rows)
                        {
                            row.Cells["Priority"].Value = set_priority;
                            set_priority++;
                        }

                        // save to db
                        using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                        {
                            dbConnection.Open();
                            //RoomsRecord.AcceptChanges();      // do we need this???
                            SQLiteCommand command = new SQLiteCommand("Select * from Branch_Priority", dbConnection);
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                            //adapter.AcceptChangesDuringUpdate = true;     // do we need this???
                            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                            adapter.Update(BranchRecord);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Drag and Drop rows event to change Branch priority --- End

        private void Button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if(Textbox_RoomNo.Text == "") CustomMessageBox.ShowMessageBox("Please fill the Room No ", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                else
                {
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        int recordsAffected;
                        string queryCheckRoomExist = string.Format("Select Room_No where Room_No=@Room_No");
                        SQLiteCommand command = new SQLiteCommand(queryCheckRoomExist, dbConnection);
                        command.Parameters.AddWithValue("@Room_No", Textbox_RoomNo.Text);
                        recordsAffected = command.ExecuteNonQuery();

                        if(recordsAffected == 0)
                        {
                            CustomMessageBox.ShowMessageBox("Room already exist, you may update existing or select new Room No", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            int setPriority = Dgv_Rooms.Rows.Count + 1;
                            string queryAddRoom = string.Format("Insert into Rooms(Room_No,Priority,A_Series,B_Series)Values(" + "@RoomNo,@Priority,@A_series,@B_series)");
                            SQLiteCommand commandAddRoom = new SQLiteCommand(queryAddRoom, dbConnection);
                            commandAddRoom.Parameters.AddWithValue("@Room_No", Textbox_RoomNo.Text);
                            commandAddRoom.Parameters.AddWithValue("@Priority", setPriority.ToString());
                            commandAddRoom.Parameters.AddWithValue("@A_series", Numeric_A_Series.Value.ToString());
                            commandAddRoom.Parameters.AddWithValue("@B_series", Numeric_B_Series.Value.ToString());
                            commandAddRoom.ExecuteNonQuery();                            
                        }
                    }
                    ResetForm();
                    CustomMessageBox.ShowMessageBox("New Room Added  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            if(selectedRoomNo == "" || Textbox_RoomNo.Text == "") CustomMessageBox.ShowMessageBox("Please select and fill Room No to be updated ", "Error", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
            else
            {
                string messageText = string.Format("Do you want to update Room '%{0}%' ?   ", selectedRoomNo);
                CustomMessageBox.ShowMessageBox(messageText, "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
                string result = CustomMessageBox.UserChoice;
                if(result == "Yes")
                {
                    int recordsAffected;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        string query = string.Format("Update Rooms set Room_No=@Room_No, A_Series=@A_Series, B_Series=@B_Series where Room_No=@SelectedRoomNo");
                        SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                        command.Parameters.AddWithValue("@Room_No", Textbox_RoomNo.Text);
                        command.Parameters.AddWithValue("@A_Series", Numeric_A_Series.Value.ToString());
                        command.Parameters.AddWithValue("@B_Series", Numeric_B_Series.Value.ToString());
                        command.Parameters.AddWithValue("@SelectedRoomNo", selectedRoomNo);
                        recordsAffected = command.ExecuteNonQuery();
                    }
                    if (recordsAffected == 0)
                    {
                        messageText = string.Format("Room '%{0}%' does not exist, Try again    ", selectedRoomNo);
                        CustomMessageBox.ShowMessageBox(messageText, "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                        return;
                    }
                    ResetForm();
                    CustomMessageBox.ShowMessageBox("Room Updated  ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);                    
                }
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            CustomMessageBox.ShowMessageBox("Do you really want to delete selected Rooms ?", "Confirmation", Form_Message_Box.MessageBoxButtons.YesNo, Form_Message_Box.MessageBoxIcon.Question);
            string result = CustomMessageBox.UserChoice;
            if (result == "Yes")
            {
                try
                {
                    bool deletedFlag = false;
                    using (SQLiteConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
                    {
                        dbConnection.Open();
                        // delete selected rooms
                        foreach (DataGridViewRow dr in Dgv_Rooms.Rows)
                        {
                            bool isSelected = Convert.ToBoolean(dr.Cells["CheckBoxColumn"].Value);
                            if (isSelected)
                            {
                                string query = string.Format("Delete from Rooms where Room_No=@Room_No");
                                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                                command.Parameters.AddWithValue("@Room_No", dr.Cells["Room_No"].Value.ToString());
                                command.ExecuteNonQuery();
                                deletedFlag = true;
                            }
                        }
                    }
                    if (deletedFlag)
                    {
                        ResetForm();
                        CustomMessageBox.ShowMessageBox("Selected Rooms deleted   ", "Success", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Information);
                    }
                    else
                    {
                        CustomMessageBox.ShowMessageBox("Select any Room to delete   ", "Failed", Form_Message_Box.MessageBoxButtons.OK, Form_Message_Box.MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    ResetForm();
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

// // // TESTING // // //
// * make error in ResetForm function to check if tryCatch work and exit Form Load function... use msgbox in each function
// * autofill when row double click
// * dragdrop feature have to be tested as last comment from https://social.msdn.microsoft.com/Forums/en-US/16b0a44e-35a0-4bc8-9ccd-ec2c62c95a55/select-and-drag-a-datagridview-row-with-a-single-click?forum=winforms
// * saving to DB while drag and drop priority...
// * if rowHeader doubleClick not working properly(line 171), change code as given in Form Database Mgmt(line 448)
// * Add existing room to chek whether return statement works fine
