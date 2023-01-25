using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.IO;
using Org.BouncyCastle.Utilities.Net;

namespace CRUD_C_SHARP
{
    class Job
    {
        public string jobId { get; set; }
        public String goodType { get; set; }
        public String weight { get; set; }
        public String senderName { get; set; }
        public String senderMobile { get; set; }
        public String senderAddress { get; set; }
        public String receiverName { get; set; }
        public String receiverMobile { get; set; }
        public String receiverAddress { get; set; }
        public String status { get; set; }

        public int book_job(String gType, String wght, String sName, String sMobile, String sAddress, String rName, String rMobile, String rAddress, String status)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
           
            String sql = "insert into Job(good_type, weight, sender_name, sender_mobile, sender_address, receiver_name, receiver_mobile, receiver_address, status) values ('"+gType+"','"+wght+"','"+sName+"', '"+sMobile+"', '"+sAddress+"', '"+rName+"', '"+rMobile+"', '"+rAddress+"', '"+status+"')";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            int id=(int)cmd.LastInsertedId;
            con.Close();
            return id;
        }

        // 
        public List<Job> getAllJobs() { 
            List<Job> jobs = new List<Job>();
            MySqlConnection con1 = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
            con1.Open();
            String sql1 = "select * from Job";
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
          //  MySqlDataAdapter da=new MySqlDataAdapter(cmd1);


            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
            
                Job job = new Job();

                job.jobId = reader["job_id"].ToString();
                job.goodType = reader["good_type"].ToString();
                job.weight = reader["weight"].ToString();
                job.senderName = reader["sender_name"].ToString();
                job.senderMobile = reader["sender_mobile"].ToString();
                job.senderAddress = reader["sender_address"].ToString();
                job.receiverName = reader["receiver_name"].ToString();
                job.receiverMobile = reader["receiver_mobile"].ToString();
                job.receiverAddress = reader["receiver_address"].ToString();
                job.status = reader["status"].ToString();

                
                jobs.Add(job);
            }

            con1.Close();
            return jobs;
        }

        public List<Job> getCurrentJobs()
        {
            List<Job> jobs = new List<Job>();
            MySqlConnection con1 = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
            con1.Open();

            String sql1 = "select * from Job where status='" + "Pending" + "' OR status= '" + "Accepted" + "'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            //  MySqlDataAdapter da=new MySqlDataAdapter(cmd1);


            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {

                Job job = new Job();

                job.jobId = reader["job_id"].ToString();
                job.goodType = reader["good_type"].ToString();
                job.weight = reader["weight"].ToString();
                job.senderName = reader["sender_name"].ToString();
                job.senderMobile = reader["sender_mobile"].ToString();
                job.senderAddress = reader["sender_address"].ToString();
                job.receiverName = reader["receiver_name"].ToString();
                job.receiverMobile = reader["receiver_mobile"].ToString();
                job.receiverAddress = reader["receiver_address"].ToString();
                job.status = reader["status"].ToString();

                jobs.Add(job);
            }

            con1.Close();
            return jobs;
        }

        public List<Job> getPastJobs()
        {

            List<Job> jobs = new List<Job>();
            MySqlConnection con1 = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
            con1.Open();

            String sql1 = "select * from Job where status='" + "Declined" + "' OR status= '" + "Finished" + "'";
           
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            //  MySqlDataAdapter da=new MySqlDataAdapter(cmd1);


            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {

                Job job = new Job();

                job.jobId = reader["job_id"].ToString();
                job.goodType = reader["good_type"].ToString();
                job.weight = reader["weight"].ToString();
                job.senderName = reader["sender_name"].ToString();
                job.senderMobile = reader["sender_mobile"].ToString();
                job.senderAddress = reader["sender_address"].ToString();
                job.receiverName = reader["receiver_name"].ToString();
                job.receiverMobile = reader["receiver_mobile"].ToString();
                job.receiverAddress = reader["receiver_address"].ToString();
                job.status = reader["status"].ToString();

                jobs.Add(job);
            }

            con1.Close();
            return jobs;
        }

        public List<Job> getPendingJobs()
        {
            List<Job> jobs = new List<Job>();
            MySqlConnection con1 = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
            con1.Open();

            String sql1 = "select * from Job where status='" + "Pending" + "'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
            //  MySqlDataAdapter da=new MySqlDataAdapter(cmd1);


            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {

                Job job = new Job();

                job.jobId = reader["job_id"].ToString();
                job.goodType = reader["good_type"].ToString();
                job.weight = reader["weight"].ToString();
                job.senderName = reader["sender_name"].ToString();
                job.senderMobile = reader["sender_mobile"].ToString();
                job.senderAddress = reader["sender_address"].ToString();
                job.receiverName = reader["receiver_name"].ToString();
                job.receiverMobile = reader["receiver_mobile"].ToString();
                job.receiverAddress = reader["receiver_address"].ToString();
                job.status = reader["status"].ToString();

                jobs.Add(job);
            }

            con1.Close();
            return jobs;
        }

        public void updateJobStatus(String jid, String s)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");

            String sql = "update job set status = '"+s+"' where job_id= '"+jid+"';";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
