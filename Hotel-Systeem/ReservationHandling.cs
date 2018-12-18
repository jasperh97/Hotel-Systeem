using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Systeem
{
    class ReservationHandling
    {
        public static Customer AddCustomerInfo(List<Customer> customers, TextBox surname, TextBox lastName, ComboBox sex, NumericUpDown age, TextBox address, TextBox postalCode, TextBox mobileNr)
        {
            int listPosition = customers.Count + 1;
            return new Customer(listPosition, surname.Text, lastName.Text, sex.GetItemText(sex.SelectedItem), Convert.ToInt32(age.Value), address.Text, postalCode.Text, mobileNr.Text);
        }
    }
}
