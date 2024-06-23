using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamandi_Booking_System.Business
{
    public class Room
    {
        #region Attributes
        public Collection<DateRange> BookedDates { get; set; }
        private int roomNumber;
        private string occupancy;

        #endregion

        #region Properties
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public string Occupancy
        {
            get { return occupancy; }
            set { occupancy = value; }
        }
        #endregion

        #region Constructors
        public Room()
        {
            roomNumber = 0;
            occupancy = "Occupied";
            this.BookedDates = new Collection<DateRange>();
        }

        public Room(int roomNumber, string occupancy, DateRange bookings)
        {
            this.roomNumber = roomNumber;
            this.occupancy = occupancy;
            this.BookedDates = new Collection<DateRange>();
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Room Number: {roomNumber}\nOccupancy: {occupancy}";
        }
        #endregion

        public class DateRange
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string occuppancy { get; set; }

            public DateRange()
            {
                StartDate = DateTime.Now;
                EndDate = DateTime.Now;
                occuppancy = "Booked";

            }

            public DateRange(DateTime startDate, DateTime endDate)
            {
                StartDate = startDate;
                EndDate = endDate;
            }
            public string ToString()
            {
                return $"CheckIn: {StartDate.ToString().Trim()}\tCheckOut: {EndDate.ToString().Trim()}\tStatus : {occuppancy}";
            }
        }        
    }   
}
