using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamandi_Booking_System.Business;


namespace Phumla_Kamandi_Booking_System.Data
{
    public class RoomDB : DB
    {
        #region Data Members

        private string table = "Room";
        private string sqlLocal = "SELECT * FROM Room";
        private Collection<Room> rooms;

        #endregion

        #region Property Method: Collection

        public Collection<Room> AllRooms
        {
            get { return rooms; }
        }

        #endregion

        #region Constructor

        public RoomDB() : base()
        {
            rooms = new Collection<Room>();
            FillDataSet(sqlLocal, table);
            Add2Collection();
        }

        #endregion

        #region Utility Methods

        private int FindRow(Room aRoom)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                
                    if (aRoom.RoomNumber == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["RoomNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                

                rowIndex++;
            }

            return returnValue;
        }

        private void Add2Collection()
        {
            DataRow myRow = null;
            Room aRoom;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aRoom = new Room();
                    aRoom.RoomNumber = Convert.ToInt32(myRow["RoomNumber"]);                                       
                    rooms.Add(aRoom);
                }
            }
        }

        private void FillRow(DataRow aRow, Room aRoom)
        {
            aRow["RoomNumber"] = aRoom.RoomNumber;          
           
        }

        #endregion

        #region Database Operations (CRUD)

     /*   public void DataSetChange(Room aRoom)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aRoom, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aRoom)];
                    FillRow(aRow, aRoom, operation);
                    break;
                case DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aRoom)];
                    if (aRow != null)
                    {
                        aRow.Delete();
                    }
                    break;
            }
        }

        public bool UpdateDataSource(Room aRoom)
        {
            bool success = true;
            Create_INSERT_Command(aRoom);
           
            success = UpdateDataSource(sqlLocal, table);
                    

            return success;
        }

        private void Create_INSERT_Command(Room aRoom)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Room (RoomNumber, RoomType, Occupancy) VALUES (@RoomNumber, @Occupancy)", cnMain);
            Build_INSERT_Parameters(aRoom);
        }

        private void Build_INSERT_Parameters(Room aRoom)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

           

            param = new SqlParameter("@Occupancy", SqlDbType.Int, 4, "Occupancy");
            daMain.InsertCommand.Parameters.Add(param);
        }
     */
        #endregion
    }
}
