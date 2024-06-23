using System;
using System.Collections.ObjectModel;
using Phumla_Kamandi_Booking_System.Business;
using Phumla_Kamandi_Booking_System.Data;
using static Phumla_Kamandi_Booking_System.Business.Room;

namespace Phumla_Kamandi_Booking_System.Business
{
    public class RoomController
    {
        private RoomDB roomDB;
        private Collection<Room> rooms;

        public RoomController()
        {
            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;
        }

        public Collection<Room> GetAllRooms()
        {
            return rooms;
        }

        public Room GetRoomByNumber(int roomNumber)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomNumber == roomNumber)
                {
                    return room;
                }
            }

            return null; 
        }


        
       
        public Room IsRoomAvailable(DateTime bookingStartDate, DateTime bookingEndDate)
        {
            foreach (Room room in rooms)
            {
                bool isAvailable = true;

                // Check if the room is available for the entire booking date range
                foreach (DateRange bookedDateRange in room.BookedDates)
                {
                    if (bookingStartDate <= bookedDateRange.EndDate && bookingEndDate >= bookedDateRange.StartDate)
                    {
                        // Room is booked during the specified date range
                        isAvailable = false;
                        break; // No need to check further, exit the inner loop
                    }
                }

                if (isAvailable)
                {
                    // Room is available for the entire booking date range
                    return room; // Return the first available room found
                }
            }

            return null; // Return null if no available rooms are found
        }

        public static double GetRoomPrice(DateTime date)
        {
            if (date >= new DateTime(DateTime.Now.Year, 12, 1) && date <= new DateTime(2023, 12, 7))
            {
                return 550.0; // Low Season
            }
            else if (date >= new DateTime(DateTime.Now.Year, 12, 8) && date <= new DateTime(DateTime.Now.Year, 12, 15))
            {
                return 750.0; // Mid Season
            }
            else if (date >= new DateTime(DateTime.Now.Year, 12, 16) && date <= new DateTime(DateTime.Now.Year, 12, 31))
            {
                return 995.0; // High Season
            }
            else
            {
                return 550.0; // Default to Low Season for other dates
            }
        }


    }
}
