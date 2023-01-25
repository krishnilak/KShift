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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminProfile profile = new AdminProfile();
            profile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports r= new Reports();
            r.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminTasks at = new AdminTasks();
            at.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProduct p = new AddProduct();
            p.Show();   
        }
    }
}
