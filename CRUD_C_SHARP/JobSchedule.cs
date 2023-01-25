using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_SHARP
{
    internal class JobSchedule
    {
        public string jobScheduleId { get; set; }
        public string jobId { get; set; }
        public String lorry { get; set; }
        public String container { get; set; }
        public String driver { get; set; }
        public String assistant { get; set; }
        public void add_schedule(String lorry, String container, String driver, String assistant, string jobId)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");

            String sql = "insert into job_schedule(lorry, container, driver, assistant, job_id) values ('" + lorry + "','" + container + "','" + driver + "', '" + assistant + "', '" + jobId + "')";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
