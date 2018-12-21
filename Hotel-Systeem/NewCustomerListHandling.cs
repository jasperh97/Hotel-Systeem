using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Systeem
{
    class NewCustomerListHandling
    {
        public static Customer AddCustomerInfo(List<Customer> customers, TextBox surname, TextBox lastName, ComboBox sex, NumericUpDown age, TextBox address, TextBox postalCode, TextBox mobileNr)
        {
            int listPosition = customers.Count + 1;
            return new Customer(listPosition, surname.Text, lastName.Text, sex.GetItemText(sex.SelectedItem), Convert.ToInt32(age.Value), address.Text, postalCode.Text, mobileNr.Text);
        }

        public static void AddCustomerToList(List<Customer> newCustomers, CheckedListBox clbCurrentCustomerList, int amountOfPersons, TextBox surname, TextBox lastName, ComboBox sex, NumericUpDown age, TextBox address, TextBox postalCode, TextBox mobileNr)
        {
            if (newCustomers.Count < amountOfPersons)
            {
                newCustomers.Add(NewCustomerListHandling.AddCustomerInfo(newCustomers, surname, lastName, sex, age, address, postalCode, mobileNr));
                foreach (Customer customer in newCustomers)
                {
                    if (customer.CustomerNr == newCustomers.Count())
                    {
                        clbCurrentCustomerList.Items.Add(customer.Surname + " " + customer.Lastname);
                    }
                }
            }
            else
            {
                MessageBox.Show("Max customers reached.");
            }
        }

        public static void DeleteCustomerFromNewList(CheckedListBox clbCurrentCustomerList, List<Customer> newCustomers)
        {
            foreach (var item in clbCurrentCustomerList.CheckedItems.OfType<string>().ToList())
            {
                newCustomers.RemoveAt(clbCurrentCustomerList.Items.IndexOf(item));
                clbCurrentCustomerList.Items.Remove(item);
            }
        }
    }
}
