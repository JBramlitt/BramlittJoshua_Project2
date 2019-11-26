using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BramlittJoshua_TimeTrackerApp
{
    class DataCon
    {
        public static string cs = @"server=10.63.30.111;username=dbsFinal;password=root;database=JoshuaBramlitt_MDV229_Database;port=8889";
        public MySqlConnection conn = new MySqlConnection(cs);

        public DataCon(string s, int r)
        {

            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connectio

            List<string> dataResults = new List<string>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = s;

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (r == 1)
                {
                    while (rdr.Read())
                    {
                        dataResults.Add(rdr[0].ToString());
                    }
                    
                }
                else if (r == 2)
                {
                    while (rdr.Read())
                    {
                        string myString = rdr[0].ToString();
                        DateTime myDate = Convert.ToDateTime(myString);

                        dataResults.Add(myDate.ToString("yyyy-MM-dd"));
                    }
                }
                else if (r == 3)
                {
                    Console.WriteLine("Activity Entered");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            if (dataResults.Count == 1)
            {
                Console.WriteLine(dataResults[0]);
            }
            else if (dataResults.Count > 1)
            {
                for (int i = 0; i < dataResults.Count; i++)
                {
                    Console.WriteLine((i + 1) + "." + dataResults[i]);
                }
            }
        }

        public void MultipleReturn(string s, int r)
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connectio

            List<string> dataResults = new List<string>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = s;

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (r == 1)
                {
                    while (rdr.Read())
                    {
                        dataResults.Add(rdr[0].ToString());
                    }

                }
                else if (r == 2)
                {
                    // Set the dates to the correct display
                    while (rdr.Read())
                    {
                        string myString = rdr[0].ToString();
                        DateTime myDate = Convert.ToDateTime(myString);

                        dataResults.Add(myDate.ToString("yyyy-MM-dd"));
                    }
                }
                else if (r == 3)
                {
                    Console.WriteLine("Activity Entered");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            if (dataResults.Count == 1)
            {
                Console.WriteLine(dataResults[0]);
            }
            else if (dataResults.Count > 1)
            {
                for (int i = 0; i < dataResults.Count; i++)
                {
                    Console.Write(dataResults[i] + " ");
                }
            }

            Console.WriteLine();
        }

    }
}
