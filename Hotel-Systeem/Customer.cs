using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hotel_Systeem
{
    public class Customer
    {
        public Customer()
        {

        }
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

        [XmlAttribute("CustomerNr")]
        public int CustomerNr { get; set; }
        [XmlElement("Surname")]
        public string Surname { get; set; }
        [XmlElement("Lastname")]
        public string Lastname { get; set; }
        [XmlElement("Sex")]
        public string Sex { get; set; }
        [XmlElement("Age")]
        public int Age { get; set; }
        [XmlElement("Address")]
        public string Address { get; set; }
        [XmlElement("PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement("MobileNr")]
        public string MobileNr { get; set; }

        public string GetCustomerInfo(int customerNr)
        {
            return "";
        }
    }
}
