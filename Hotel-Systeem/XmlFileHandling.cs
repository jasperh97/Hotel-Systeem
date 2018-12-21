using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Hotel_Systeem
{
    class XmlFileHandling
    {
        public static void XmlSerialization(List<Customer> Customer)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(Customer.GetType());

            TextWriter textWriter = new StreamWriter(@"..\..\Resources\AllCustomers.xml");

            xmlSerializer.Serialize(textWriter, Customer);

            textWriter.Close();
        }

        public static List<Customer> XmlDeserialization()
        {
            XmlSerializer deSerializer = new XmlSerializer(typeof(List<Customer>));

            TextReader textReader = new StreamReader(@"..\..\Resources\AllCustomers.xml");

            List<Customer> retVal = (List<Customer>)deSerializer.Deserialize(textReader);

            textReader.Close();

            return retVal;
        }
    }
}
