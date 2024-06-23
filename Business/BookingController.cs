using Phumla_Kamandi_Booking_System.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Phumla_Kamandi_Booking_System.Data;

namespace Phumla_Kamandi_Booking_System
{
    public class BookingController
    {
        #region Data Members
        private BookingDB bookingDB;
        protected Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            // Instantiate the BookingDB object to communicate with the database
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }
        #endregion

        #region Database Communication

        public void DataMaintenance(Booking aBooking, BookingDB.DBOperation operation)
        {
            int index = 0;

            switch (operation)
            {
                case BookingDB.DBOperation.Add:
                    // Perform the Add operation to the dataset in memory
                    bookingDB.DataSetChange(aBooking, operation);
                    // Add the booking to the Collection
                    bookings.Add(aBooking);
                    break;
                case BookingDB.DBOperation.Edit:
                    // Find the index of the booking
                    index = bookingDB.FindIndex(aBooking);
                    if (index != -1)
                    {
                        // Perform the Edit operation to the dataset in memory
                        bookingDB.DataSetChange(aBooking, BookingDB.DBOperation.Edit);
                        // Replace the booking at this index with the updated booking (aBooking)
                        bookings[index] = aBooking;
                    }
                    else
                    {
                        // Handle the case where the booking was not found
                        throw new ArgumentException("Booking not found for editing.");
                    }
                    break;
                case BookingDB.DBOperation.Delete:
                    // Find the index of the booking
                    index = bookingDB.FindIndex(aBooking);
                    if (index != -1)
                    {
                        // Perform the Delete operation to the dataset in memory
                        bookingDB.DataSetChange(aBooking, BookingDB.DBOperation.Delete);
                        // Remove the booking from the collection
                        bookings.RemoveAt(index);
                    }
                    else
                    {
                        // Handle the case where the booking was not found
                        throw new ArgumentException("Booking not found for deletion.");
                    }
                    break;
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }

        // Commit the changes to the database
        public bool FinalizeChanges(Booking booking)
        {
            // Call the BookingDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Search Method
        
        // This method receives a booking reference number as a parameter; finds the booking object in the collection of bookings and then returns this object
        public Booking Find(string refID)
        {
            int index = 0;
            bool found = (bookings[index].BookingID == refID);  // Check if it is the first booking
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))  // If not "this" booking and you are not at the end of the list 
            {
                index = index + 1;
                found = (bookings[index].BookingID == refID);   // This will be TRUE if found
            }
            return bookings[index];  // This is the one!  
        }
        #endregion
    }
}