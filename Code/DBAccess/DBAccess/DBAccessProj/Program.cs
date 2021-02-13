using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace DBAccessProj
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SqlConnection conn = new SqlConnection())
            {

                string str = "Data Source = thermaltakepc; Initial Catalog = Rosie; Integrated Security = True";
                conn.ConnectionString = str; 
                SqlCommand cmd = new SqlCommand();
                SqlDataReader r;

                Console.Write("Name: ");
                string thename = Console.ReadLine();

                cmd.CommandText = "SELECT * FROM  People WHERE CONVERT(VARCHAR, Name) = '" + thename + "' ;"; 
                

                cmd.Connection = conn;

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // while there is another record present
                    while (reader.Read())
                    {
                        // write the data on to the screen
                        Console.WriteLine(String.Format("{0} \t | {1} \t",
                        // call the objects from their index
                        reader[0], reader[1]));
                    }
                }



                conn.Close();
            }

            Console.ReadLine(); 
        }
    }
}
