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
            NewCustomerListHandling.AddCustomerToList(NewCustomers, clbCurrentCustomerList, amountOfPersons, tbSurname, tbLastName, comboBoxSex, nudAge, tbAddress, tbPostalCode, tbMobileNr);
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerListHandling.DeleteCustomerFromNewList(clbCurrentCustomerList, NewCustomers);
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

            foreach (Control control in groupBoxCustomerInfo.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }

            nudAge.Value = 0;
            nudPersons.Value = 1;

            XmlFileHandling.XmlSerialization(AllCustomers);
        }
    }
}
