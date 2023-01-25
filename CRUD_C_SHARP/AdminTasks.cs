using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_C_SHARP
{
    public partial class AdminTasks : Form
    {
        public AdminTasks()
        {
            InitializeComponent();

            List<Job> jobs = new List<Job>();
            Job j = new Job();
            jobs = j.getPendingJobs();
            dataGridView1.DataSource = jobs;

            combo_lorry.Items.Add("Lorry A");
            combo_lorry.Items.Add("Lorry B");
            combo_lorry.Items.Add("Lorry C");

            combo_container.Items.Add("0-50 kg");
            combo_container.Items.Add("50-100 kg");
            combo_container.Items.Add("100-200 kg");

            User user= new User();
            List<string> drivers=user.getDrivers();
            foreach (string driver in drivers)
            {
                Combo_driver.Items.Add(driver);
            }

            List<string> assistants = user.getAssistants();
            foreach (string assistant in assistants)
            {
                combo_assistant.Items.Add(assistant);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //approve
            String job_id = textBox1.Text;
            Job js = new Job();
            js.updateJobStatus(job_id, "Approved");

            // add job_schedule to another table
            JobSchedule js2=new JobSchedule();
            js2.add_schedule(combo_lorry.Text, combo_container.Text, Combo_driver.Text, combo_assistant.Text, job_id);

            //reset
            combo_assistant.ResetText();
            combo_container.ResetText();
            combo_lorry.ResetText();
            combo_container.ResetText();
            textBox1.ResetText();

            List<Job> jobs = new List<Job>();
            Job js1 = new Job();
            jobs = js1.getPendingJobs();
            dataGridView1.DataSource = jobs;

        }













        private void button3_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();   
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //declined
            String job_id = textBox1.Text;
            Job j = new Job();
            j.updateJobStatus(job_id, "Declined");

            //reset
            combo_assistant.ResetText();
            combo_container.ResetText();
            combo_lorry.ResetText();
            combo_container.ResetText();
            textBox1.ResetText();

            List<Job> jobs = new List<Job>();
            Job js1 = new Job();
            jobs = js1.getPendingJobs();
            dataGridView1.DataSource = jobs;
        }
    }
}
