using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_SHARP
{
    internal class User
    {
        public string userName { get; set; }

        public string mobile { get; set; }
        public string address { get; set; }
        public string userRole { get; set; }
        public string password { get; set; }

        public User getProfile(String username)
        {
            {
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
                    con.Open();

                    String sql = "select * from User where uname= '" + username + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    User u = new User();
                    while (reader.Read())
                    {
                        u.userName = reader["uname"].ToString();
                        u.mobile = reader["mobile"].ToString();
                        u.address = reader["address"].ToString();
                    }

                    return u;

                }

            }
        }

        public List<String> getDrivers()
        {
            {
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
                    con.Open();

                    String sql = "select * from User where user_role= '" + "driver" + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    List<String> drivers = new List<String>();
                    User u = new User();
                    while (reader.Read())
                    {
                        u.userName = reader["uname"].ToString();
                        drivers.Add(u.userName);
                    }

                    return drivers;

                }

            }
        }

        public List<String> getAssistants()
        {
            {
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");
                    con.Open();

                    String sql = "select * from User where user_role= '" + "assistant" + "' ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    List<String> assistants = new List<String>();
                    User u = new User();
                    while (reader.Read())
                    {
                        u.userName = reader["uname"].ToString();
                        assistants.Add(u.userName);
                    }

                    return assistants;

                }

            }
        }

    }
}
