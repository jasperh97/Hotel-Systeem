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
        int amountOfPersons = 0;
        List<Customer> customers = new List<Customer>();

        public AddReservations()
        {
            InitializeComponent();

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {

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
            if (customers.Count < amountOfPersons)
            {
                customers.Add(ReservationHandling.AddCustomerInfo(customers, tbSurname, tbLastName, comboBoxSex, nudAge, tbAddress, tbPostalCode, tbMobileNr));
                foreach (Customer customer in customers)
                {
                    if (customer.CustomerNr == customers.Count())
                    {
                        clbCurrentCustomerList.Items.Add(customers.IndexOf(customer) + " " + customer.Surname + " " + customer.Lastname);
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
                clbCurrentCustomerList.Items.Remove(item);
                
            }

            foreach (var checkedItem in clbCurrentCustomerList.CheckedItems)
            {

            }
            
        }

        private void nudPersons_ValueChanged_1(object sender, EventArgs e)
        {
            if (nudPersons == this.ActiveControl)
            {
                amountOfPersons = Convert.ToInt32(nudPersons.Value);
            }
        }
    }
}
