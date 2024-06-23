using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamandi_Booking_System.Business
{
    public class Guest:Person
    {
        #region Data Members
        private string guestID;
        #endregion

        #region Properties

        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        #endregion

        #region Constructors
        public Guest()
        {
            guestID = "";
        }


        public Guest(string pID, string pName,string lastName, string pPhone, string pGuestID,string address)
            : base(pID, pName, lastName, pPhone,address)
        {
            guestID = pGuestID;
        }
        #endregion

        public static string GenerateGuestID(string firstName, string lastName)
        {
            // Take the first two characters from the first name
            string firstNamePart = firstName.Length >= 2 ? firstName.Substring(0, 2) : firstName;

            // Take the first two characters from the last name
            string lastNamePart = lastName.Length >= 2 ? lastName.Substring(0, 2) : lastName;

            
            Random random = new Random();
            int randomNumber = random.Next(1,9);

            // Concatenate the parts and random number
            string guestID = $"{firstNamePart.ToUpper()}{lastNamePart.ToUpper()}{randomNumber:D2}";

            return guestID;
        }
    }
}
