using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Systeem
{
    static class CustomerNr
    {
        static int CustomerID = Convert.ToInt32(System.IO.File.ReadAllText(Application.StartupPath + @"\CustomerID.txt"));
        public static int getCustomerNr()
        {
            CustomerID++;
            System.IO.File.WriteAllText(Application.StartupPath + @"\CustomerID.txt", CustomerID.ToString());
            return CustomerID;
        }
    }
}
