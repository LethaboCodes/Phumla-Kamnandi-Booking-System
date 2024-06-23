using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using Phumla_Kamandi_Booking_System.Business;


namespace Phumla_Kamandi_Booking_System.Data
{
    public class GuestDB : DB
    {
        #region Data Members

        private string table = "Guest";
        private string sqlLocal = "SELECT * FROM Guest";
        private Collection<Guest> guests;

        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }

        #endregion

        #region Property Method: Collection

        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }

        #endregion

        #region Constructor

        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
            Add2Collection();
        }

        #endregion

        #region Utility Methods

        private int FindRow(Guest aGuest)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aGuest.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]))
                    {
                        returnValue = rowIndex;
                    }
                }

                rowIndex++;
            }

            return returnValue;
        }

        public int FindIndex(Guest aGuest)
        {
            int counter = 0;
            bool found = false;

            while (counter < guests.Count && !found)
            {
                found = (aGuest.ID == guests[counter].ID);
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
            Guest aGuest;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest();
                    aGuest.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aGuest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aGuest.LastName = Convert.ToString(myRow["LastName"]).TrimEnd();
                    aGuest.ADDRESS = Convert.ToString(myRow["Address"]).TrimEnd();
                    aGuest.Telephone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    aGuest.ID = Convert.ToString(myRow["ID"]).TrimEnd();

                    guests.Add(aGuest);
                }
            }
        }

        private void FillRow(DataRow aRow, Guest aGuest)
        {
            aRow["GuestID"] = aGuest.GuestID;            
            aRow["Name"] = aGuest.Name;
            aRow["Phone"] = aGuest.Telephone;
            aRow["LastName"] = aGuest.LastName;
            aRow["Address"] = aGuest.ADDRESS;
            aRow["ID"] = aGuest.ID;

        }

        #endregion

        #region Database Operations (CRUD)

        public void DataSetChange(Guest aGuest)
        {
            DataRow aRow = null;
            aRow = dsMain.Tables[table].NewRow();
            FillRow(aRow, aGuest);
            dsMain.Tables[table].Rows.Add(aRow);

        }

        public bool UpdateDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest);
            success = UpdateDataSource(sqlLocal, table);
            return success;
           
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Guest (GuestID, Name,LastName , Phone, Address, ID) VALUES (@GuestID, @Name, @LastName, @Phone,@Address, @ID)", cnMain);
            Build_INSERT_Parameters(aGuest);
        }

        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 20, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@LastName", SqlDbType.NVarChar, 50, "LastName");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 20, "ID");
            daMain.InsertCommand.Parameters.Add(param);
        }



        #endregion
    }
}
