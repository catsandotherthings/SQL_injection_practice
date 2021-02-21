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

                cmd.Connection = conn;
                conn.Open();             

                while (true)
                {
                    Console.Write("Name [or 'exit']: ");
                    string thename = Console.ReadLine();
                    if (thename.Equals("exit")) break;

                    try {

                        cmd.CommandText = "SELECT * FROM  People WHERE CONVERT(VARCHAR, Name) = '" + thename + "' ;";
                        Console.WriteLine(cmd.CommandText);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // while there is another record present
                            while (reader.Read())
                            {
                                // write the data on to the screen
                                Console.WriteLine(String.Format("{0} \t\t\t |\t\t {1}", reader[0], reader[1]));
                            }
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message); 
                    }

                    
                }

                conn.Close();
            }

            Console.WriteLine("Goodbye."); 
        }
    }
}
