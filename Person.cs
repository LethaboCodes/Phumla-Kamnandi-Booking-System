using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamandi_Booking_System
{
    public class Person
    {
       
        #region data members
        private string Id, name,lastName, Phone, Address;
        #endregion

        #region Properties
        public string ADDRESS
        {
            get { return Address; }
            set { Address = value; }
        }
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Telephone
        {
            get { return Phone; }
            set { Phone = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            Id = "";
            name = "";
            lastName = "";
            Phone = "";
            Address = "";
        }

        public Person(string pID, string pName,string lastname, string pPhone,string address)
        {
            Id = pID;
            name = pName;
            Phone = pPhone;
            lastName = lastname;
            Address= address;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Phone;
        }

        #endregion
    }

}
