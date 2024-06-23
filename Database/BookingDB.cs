using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamandi_Booking_System.Business;

namespace Phumla_Kamandi_Booking_System.Data
{
    public class BookingDB : DB
    {
        #region Data Members
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";
        private RoomController roomController;
        private GuestController guestController;

        private Collection<Booking> bookings;
        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }
        #endregion

        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            roomController = new RoomController();
            guestController = new GuestController();
            FillDataSet(sqlLocal, table);
            Add2Collection();
        }
        #endregion

        #region Utility Methods

        private int FindRow(Booking aBooking)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aBooking.BookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }

                rowIndex++;
            }

            return returnValue;
        }

        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;

            while (counter < bookings.Count && !found)
            {
                found = (aBooking.BookingID == bookings[counter].BookingID);
                if (!found)
                {
                    counter++;
                }
            }

            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        private void Add2Collection()
        {
            DataRow myRow = null;
            Booking aBooking;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aBooking = new Booking();
                    aBooking.BookingID = Convert.ToString(myRow["BookingID"]);
                    aBooking.CheckInDate = Convert.ToDateTime(myRow["CheckInDate"]);
                    aBooking.CheckOutDate = Convert.ToDateTime(myRow["CheckOutDate"]);
                    aBooking.Room = roomController.GetRoomByNumber(Convert.ToInt32(myRow["RoomNumber"]));
                    aBooking.Guest = guestController.Find(Convert.ToString(myRow["GuestID"]));
                    aBooking.TotalAmount = Convert.ToDouble(myRow["TotalDue"]);
                    bookings.Add(aBooking);
                }
            }
        }

        private void FillRow(DataRow aRow, Booking aBooking, DBOperation operation)
        {
            aRow["BookingID"] = aBooking.BookingID;
            aRow["CheckInDate"] = aBooking.CheckInDate;
            aRow["CheckOutDate"] = aBooking.CheckOutDate;
            aRow["RoomNumber"] = aBooking.Room.RoomNumber;
            aRow["GuestID"] = Convert.ToString(aBooking.Guest.ID);
            aRow["TotalDue"] = Convert.ToDecimal(aBooking.TotalAmount);

        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Booking aBooking, DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aBooking, operation);
                    dsMain.Tables[table].Rows.Add(aRow); // Add to the dataset
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aBooking)];
                    FillRow(aRow, aBooking, operation);
                    break;
                
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database

        private void Build_INSERT_Parameters(Booking aBooking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 50, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.Date, 3, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date, 3, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalDue", SqlDbType.Money, 15, "TotalDue");
            daMain.InsertCommand.Parameters.Add(param);


        }

        private void Create_INSERT_Command(Booking aBooking)
        {

           
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, CheckInDate, CheckOutDate, RoomNumber, GuestID, TotalDue) VALUES (@BookingID, @CheckInDate, @CheckOutDate, @RoomNumber, @GuestID, @TotalDue)", cnMain);
            Build_INSERT_Parameters(aBooking);
        }

        public bool UpdateDataSource(Booking aBooking)
        {
            Create_INSERT_Command(aBooking);
            Create_UPDATE_Command(aBooking);
            Create_DELETE_Command(aBooking);
            return UpdateDataSource(sqlLocal, table);
        }

        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CheckInDate", SqlDbType.Date, 3, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date, 3, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 20, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalDue", SqlDbType.Int, 4, "TotalDue");
            param.SourceVersion = DataRowVersion.Current;
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private string Create_DELETE_Command(Booking aBooking)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE GuestID = @GuestID", cnMain);
                    
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }

        private void Create_UPDATE_Command(Booking aBooking)
        {          
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, RoomNumber = @RoomNumber, TotalDue = @TotalDue WHERE BookingID = @Original_BookingID",cnMain);
            Build_UPDATE_Parameters(aBooking);
        }

        #endregion
    }
}