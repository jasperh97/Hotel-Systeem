using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Systeem
{
    internal class Customer
    {
        public Customer(int customerNr, string surname, string lastname, string sex, int age, string address, string postalCode, string mobileNr)
        {
            CustomerNr = customerNr;
            Surname = surname;
            Lastname = lastname;
            Sex = sex;
            Age = age;
            Address = address;
            PostalCode = postalCode;
            MobileNr = mobileNr;
        }

        public int CustomerNr { get; }
        public string Surname { get; }
        public string Lastname { get; }
        public string Sex { get; }
        public int Age { get; }
        public string Address { get; }
        public string PostalCode { get; }
        public string MobileNr { get; }

        public string GetCustomerInfo(int customerNr)
        {
            return "";
        }
    }
}
