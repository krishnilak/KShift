using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_C_SHARP
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerProfile cp= new CustomerProfile();
            cp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookCabs bc = new BookCabs();   
            bc.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerCurrentBookings ccb= new CustomerCurrentBookings();
            ccb.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerPastBookings cpb = new CustomerPastBookings();  
            cpb.Show(); 
        }
    }
}
