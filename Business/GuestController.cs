using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamandi_Booking_System.Data ; 

namespace Phumla_Kamandi_Booking_System.Business
{

    public class GuestController
    {
        #region Data Members
        private GuestDB guestDB;
        private Collection<Guest> guests;
        #endregion

        #region Properties
        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }
        #endregion

        #region Constructor
        public GuestController()
        {
            guestDB = new GuestDB(); // Instantiate the GuestDB object to communicate with the database
            guests = guestDB.AllGuests;
        }
        #endregion

        #region Database Communication

        public void DataMaintenance(Guest aGuest)
        {
                    
             guestDB.DataSetChange(aGuest); // Perform the Add operation to the dataset in memory
             guests.Add(aGuest); // Add the guest to the Collection
                        
        }

        
        public bool FinalizeChanges(Guest guest)
        {
            return guestDB.UpdateDataSource(guest); // Call the GuestDB method that will commit the changes to the database
        }
        #endregion

        #region Search Method        

        // This method receives a guest ID as a parameter, finds the guest object in the collection of guests, and then returns this object
        public Guest Find(string ID)
        {
            int index = 0;
            bool found = (guests[index].GuestID.Equals(ID)); // Check if it is the first guest
            int count = guests.Count;
            while (!(found) && (index < guests.Count - 1)) // If not "this" guest and you are not at the end of the list
            {
                index = index + 1;
                if (guests[index].GuestID == ID) {

                    return guests[index];
                } // This will be TRUE if found
            }
            return null; // This is the one!
        }

        #endregion

        

    }
}
