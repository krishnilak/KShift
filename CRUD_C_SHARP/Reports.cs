using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUD_C_SHARP
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            List<Job> jb = new List<Job>();
            Job j = new Job();
            jb = j.getAllJobs();
            MessageBox.Show("reports.cs");
            dataGridView2.DataSource = jb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                    }
                
               

            

        private void button2_Click(object sender, EventArgs e)
        {
            AdminDashboard ad= new AdminDashboard();
            ad.Show();
        }
    }
}
