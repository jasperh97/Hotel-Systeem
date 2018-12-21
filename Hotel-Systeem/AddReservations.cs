using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Systeem
{
    public partial class AddReservations : Form
    {
        int amountOfPersons = 1;
        List<Customer> NewCustomers = new List<Customer>();
        List<Customer> AllCustomers = XmlFileHandling.XmlDeserialization();

        public AddReservations()
        {
            InitializeComponent();
        }

        private void CalendarStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSelectedStartDate.Text = CalendarStartDate.SelectionRange.Start.ToShortDateString();
        }

        private void CalendarEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSelectedEndDate.Text = CalendarEndDate.SelectionRange.Start.ToShortDateString();
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (NewCustomers.Count < amountOfPersons)
            {
                NewCustomers.Add(ReservationHandling.AddCustomerInfo(NewCustomers, tbSurname, tbLastName, comboBoxSex, nudAge, tbAddress, tbPostalCode, tbMobileNr));
                foreach (Customer customer in NewCustomers)
                {
                    if (customer.CustomerNr == NewCustomers.Count())
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

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            foreach (var item in clbCurrentCustomerList.CheckedItems.OfType<string>().ToList())
            {
                NewCustomers.RemoveAt(clbCurrentCustomerList.Items.IndexOf(item));
                clbCurrentCustomerList.Items.Remove(item);
            }
            
        }

        private void nudPersons_ValueChanged_1(object sender, EventArgs e)
        {
            if (nudPersons == this.ActiveControl)
            {
                amountOfPersons = Convert.ToInt32(nudPersons.Value);
            }
        }

        private void btnAddReservation_Click_1(object sender, EventArgs e)
        {
            foreach (Customer customer in NewCustomers)
            {
                customer.CustomerNr = CustomerNr.getCustomerNr();
            }

            AllCustomers.AddRange(NewCustomers);
            NewCustomers.Clear();
            clbCurrentCustomerList.Items.Clear();

            XmlFileHandling.XmlSerialization(AllCustomers);
        }
    }
}
