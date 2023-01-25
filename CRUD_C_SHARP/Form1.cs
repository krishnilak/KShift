namespace CRUD_C_SHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = textBox1.Text;
            String pwd = textBox2.Text;

            if (uname == "admin")
            {
                if(pwd == "admin")
                {
                    AdminDashboard ad = new AdminDashboard();
                    ad.Show();
                }
            }
            else if (uname == "customer")
            {
                if (pwd == "customer")
                {
                    CustomerDashboard cd = new CustomerDashboard();
                    cd.Show();
                }
            }
            else
            {
                textBox1.ResetText();
                textBox2.ResetText();
                label4.Text = "Invalid Login";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}