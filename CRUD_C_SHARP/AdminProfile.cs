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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
            User u = new User();
            u = u.getProfile("admin");
            label2.Text= u.userName;
            label4.Text = u.mobile;
            label6.Text = u.address;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard ad= new AdminDashboard();
            ad.Show();
        }
    }
}
