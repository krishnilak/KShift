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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            comboBox1.Items.Add("Furniture");
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Mixed");

            comboBox2.Items.Add("0-50 kg");
            comboBox2.Items.Add("50-100 kg");
            comboBox2.Items.Add("100-200 kg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.addProduct(comboBox1.Text, comboBox2.Text, textBox1.Text);
            MessageBox.Show("Product Added / Updated");
            comboBox1.ResetText();
            comboBox2.ResetText();
            textBox1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard ad= new AdminDashboard();
            ad.Show();
        }
    }
}
