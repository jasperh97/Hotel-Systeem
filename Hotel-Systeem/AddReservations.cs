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
    }
}
