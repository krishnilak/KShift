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
    public partial class CustomerCurrentBookings : Form
    {
        public CustomerCurrentBookings()
        {
            InitializeComponent();
            List<Job> jobs = new List<Job>();
            Job j=new Job();
           jobs=j.getCurrentJobs();
            dataGridView1.DataSource= jobs;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDashboard cd = new CustomerDashboard();
            cd.Show();
        }
    }
}
