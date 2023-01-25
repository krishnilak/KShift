using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_C_SHARP
{
    public partial class Payment : Form
    {
       
       String paymentStatus = "Pending" ;
        public String job_id { get; set; }
        public String cost { get; set; }
        public Payment()
        {
            InitializeComponent();
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentStatus = "Done";
            button1.Text = "Payment Done";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(paymentStatus == "Done")
            {
                Job j=new Job();
                j.updateJobStatus(lbl_jid.Text, "Pending");
                CustomerCurrentBookings ccb = new CustomerCurrentBookings();
                ccb.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lbl_jid.Text = job_id;
            lbl_cost.Text = cost;
        }
    }
}
