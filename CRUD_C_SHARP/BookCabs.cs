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
    public partial class BookCabs : Form
    {
        public static BookCabs instance;
        public BookCabs()
        {
            InitializeComponent();
            instance= this;
            
            comboBox1.Items.Add("Furniture");
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Mixed");

            comboBox2.Items.Add("0-50 kg");
            comboBox2.Items.Add("50-100 kg");
            comboBox2.Items.Add("100-200 kg");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String goodType = comboBox1.Text;
            String weight = comboBox2.Text;
            String senderName = textBox1.Text;
            String senderMobile = textBox2.Text;
            String senderAddress = textBox3.Text;
            String receiverName = textBox4.Text;
            String receiverMobile = textBox5.Text;
            String receiverAddress = textBox6.Text;
            String status = new String("Created");
            
            

            Job j = new Job();
            
            
            int jid=j.book_job(goodType, weight, senderName, senderMobile, senderAddress, receiverName, receiverMobile, receiverAddress, status);

            Product pr = new Product();
            Payment p = new Payment();
            String cost = pr.getCost(goodType, weight);

           p.cost = cost;
           p.job_id= jid.ToString();
           
           p.Show(this);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerDashboard cd= new CustomerDashboard();
            cd.Show();
        }
    }
}
