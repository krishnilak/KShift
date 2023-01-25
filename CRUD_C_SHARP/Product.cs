using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_C_SHARP
{
    internal class Product
    {
        public String goodType { get; set; }
        public String weight { get; set; }
        public String price { get; set; }
        
        public void addProduct(String gType, String wght, String price)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");

            String sql = "insert into Product(good_type, weight, price) values ('" + gType + "', '" + wght + "', '" + price + "')";
            con.Open();
                    
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string getCost(String gType, String wght)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=kshift;uid=root;password=root;");

            String sql = "select price from Product where good_type = '" + gType + "' AND weight = '" + wght + "'";
            con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<String> assistants = new List<String>();

            String cost = "";
            while (reader.Read())
            {
                cost = reader["price"].ToString();
            }
            con.Close();

            return cost;
            
        }

    }
}
