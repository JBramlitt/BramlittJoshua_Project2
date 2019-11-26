using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace BramlittJoshua_Integrative
{
    class DataCon
    {
        public static string cs = @"server=192.168.1.11;username=dbsFinal;password=root;database=Restaurant;port=8889";
        public MySqlConnection conn = new MySqlConnection(cs);

        public DataCon(string s, int r)
        {

            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connectio

            List<string> dataResults = new List<string>();
            List<string> dataResults2 = new List<string>();
            List<int> tempList = new List<int>();

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
                        dataResults2.Add(rdr[1].ToString());
                    }

                    for (int i = 0; i < dataResults2.Count; i++)
                    {
                        if (dataResults2[i] != null)
                        {
                            float temp = 0;

                            if (float.TryParse(dataResults2[i], out temp))
                            {
                                Math.Round(temp);

                                int conv = Convert.ToInt32(temp);

                                tempList.Add(conv);
                            }
                            else
                            {
                                tempList.Add(0);
                            }
                        }


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
                    Console.Write((i + 1) + "." + dataResults[i] + "\t\t");
                    //Console.WriteLine((i + 1) + "." + dataResults[i + 1]);
                }
            }
        }

        public DataCon()
        {

        }

        public void ToJson()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select * From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();


                // Loop to send strings to restaurant class
                while (rdr.Read())
                {
                    Restaurant rest = new Restaurant(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), rdr[7].ToString(), rdr[8].ToString(), rdr[9].ToString(), rdr[10].ToString(), rdr[11].ToString(), rdr[12].ToString(), rdr[13].ToString());
                    restList.Add(rest);
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

            // Create directory and file
            string _dir = @"..\..\output\";
            string _file = @"restaurant.json";

            Directory.CreateDirectory(_dir);
            
            if (File.Exists(_dir + _file))
            {

            }
            else
            {
                File.Create(_dir + _file);
            }

            if (!File.Exists(_dir + _file))
            {
                File.Create(_dir + _file).Dispose();
            }

            // Create the Json file
            using (StreamWriter  sw = new StreamWriter(_dir + _file))
            {
                sw.WriteLine("{");
                sw.WriteLine("\"RestaurantProfiles\" : [");

                for (int i = 0; i < restList.Count; i++)
                {
                    if (i != restList.Count - 1)
                    {                        
                        sw.WriteLine("{");
                        sw.WriteLine($"\"id\": \"{restList[i].ID}\",");
                        sw.WriteLine($"\"Restaurant Name\": \"{restList[i].Name}\",");
                        sw.WriteLine($"\"Address\": \"{restList[i].Address}\",");
                        sw.WriteLine($"\"Phone Number\": \"{restList[i].Phone}\",");
                        sw.WriteLine($"\"Hours of Operation\": \"{restList[i].Hours}\",");
                        sw.WriteLine($"\"Price\": \"{restList[i].Price}\",");
                        sw.WriteLine($"\"City Location\": \"{restList[i].Location}\",");
                        sw.WriteLine($"\"Cuisine\": \"{restList[i].Cuisine}\",");
                        sw.WriteLine($"\"Food Rating\": \"{restList[i].FoodRate}\",");
                        sw.WriteLine($"\"Service Rating\": \"{restList[i].ServRate}\",");
                        sw.WriteLine($"\"Ambience Rating\": \"{restList[i].AmbRate}\",");
                        sw.WriteLine($"\"Value Rating\": \"{restList[i].ValRate}\",");
                        sw.WriteLine($"\"Overall Rating\": \"{restList[i].OverRate}\",");
                        sw.WriteLine($"\"Total Possible Rating\": \"{restList[i].PosRate}\"");
                        sw.WriteLine("},");

                    }
                    else
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"id\": \"{restList[i].ID}\",");
                        sw.WriteLine($"\"Restaurant Name\": \"{restList[i].Name}\",");
                        sw.WriteLine($"\"Address\": \"{restList[i].Address}\",");
                        sw.WriteLine($"\"Phone Number\": \"{restList[i].Phone}\",");
                        sw.WriteLine($"\"Hours of Operation\": \"{restList[i].Hours}\",");
                        sw.WriteLine($"\"Price\": \"{restList[i].Price}\",");
                        sw.WriteLine($"\"City Location\": \"{restList[i].Location}\",");
                        sw.WriteLine($"\"Cuisine\": \"{restList[i].Cuisine}\",");
                        sw.WriteLine($"\"Food Rating\": \"{restList[i].FoodRate}\",");
                        sw.WriteLine($"\"Service Rating\": \"{restList[i].ServRate}\",");
                        sw.WriteLine($"\"Ambience Rating\": \"{restList[i].AmbRate}\",");
                        sw.WriteLine($"\"Value Rating\": \"{restList[i].ValRate}\",");
                        sw.WriteLine($"\"Overall Rating\": \"{restList[i].OverRate}\",");
                        sw.WriteLine($"\"Total Possible Rating\": \"{restList[i].PosRate}\"");
                        sw.WriteLine("}");
                        sw.WriteLine("]");
                        sw.WriteLine("}");
                    }
                }
            }

            Console.WriteLine("Task Finished");

            Console.WriteLine();

            Console.WriteLine("Press enter to return to the menu");
        }

        public void Alphabet()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connectio

            List<string> dataResults = new List<string>();
            List<string> dataResults2 = new List<string>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dataResults.Add(rdr[0].ToString());
                    dataResults2.Add(rdr[1].ToString());
                }

                for (int i = 0; i < dataResults2.Count; i++)
                {
                    if (dataResults2[i] != null)
                    {
                        float temp = 0;

                        if (float.TryParse(dataResults2[i], out temp))
                        {
                            Math.Round(temp);

                            int conv = Convert.ToInt32(temp);

                            tempList.Add(conv);
                        }
                        else
                        {
                            tempList.Add(0);
                        }
                    }
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

            for (int i = 0; i < dataResults.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write($"{(i + 1) + "." + dataResults[i],-45}");
                //Console.WriteLine((i + 1) + "." + dataResults[i + 1]);

                int tempvar = (5 - tempList[i]);

                switch (tempList[i])
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{"*"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{"**"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{"***"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{"****"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{"*****"}", -6);

                            Console.WriteLine();
                        }
                        break;

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("*****");
                        }
                        break;
                }
            }

        }

        public void ReverseAlphabet()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<string> dataResults = new List<string>();
            List<string> dataResults2 = new List<string>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dataResults.Add(rdr[0].ToString());
                    dataResults2.Add(rdr[1].ToString());
                }

                for (int i = 0; i < dataResults2.Count; i++)
                {
                    if (dataResults2[i] != null)
                    {
                        float temp = 0;

                        if (float.TryParse(dataResults2[i], out temp))
                        {
                            Math.Round(temp);

                            int conv = Convert.ToInt32(temp);

                            tempList.Add(conv);
                        }
                        else
                        {
                            tempList.Add(0);
                        }
                    }
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

            int count = 0;
            for (int i = dataResults.Count - 1; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write($"{(count + 1) + "." + dataResults[i],-45}");
                //Console.WriteLine((i + 1) + "." + dataResults[i + 1]);

                int tempvar = (5 - tempList[i]);

                switch (tempList[i])
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{"*"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{"**"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{"***"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{"****"}", -6);

                            for (int j = 0; j < tempvar; j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("*");
                            }

                            Console.WriteLine();
                        }
                        break;

                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{"*****"}", -6);

                            Console.WriteLine();
                        }
                        break;

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("*****");
                        }
                        break;
                }
                count++;
            }

        }

        public void BestToWorst()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            for (int i = 0; i < restList.Count; i++)
            {

            }

            restList.Sort();

            restList.Reverse();

            foreach (Restaurant r in restList)
            {
                Console.WriteLine(r);
            }
        }

        public void WorstToBest()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();            

            foreach (Restaurant r in restList)
            {
                Console.WriteLine(r);
            }
        }

        public void FiveStars()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();
            int num = 0;

            foreach (Restaurant r in restList)
            {
                if (restList[num].Rating == 5)
                {
                    Console.WriteLine(r);
                }

                num++;
            }

        }

        public void FourAndUp()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();
            int num = 0;

            foreach (Restaurant r in restList)
            {
                if (restList[num].Rating >= 4)
                {
                    Console.WriteLine(r);
                }

                num++;
            }

        }

        public void ThreeAndUp()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();
            int num = 0;

            foreach (Restaurant r in restList)
            {
                if (restList[num].Rating >= 3)
                {
                    Console.WriteLine(r);
                }

                num++;
            }

        }

        public void OneStar()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();
            int num = 0;

            foreach (Restaurant r in restList)
            {
                if (restList[num].Rating == 1)
                {
                    Console.WriteLine(r);
                }

                num++;
            }

        }

        public void Unrated()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, OverallRating From RestaurantProfiles";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();
            int num = 0;

            foreach (Restaurant r in restList)
            {
                if (restList[num].Rating == 0)
                {
                    Console.WriteLine(r);
                }

                num++;
            }

        }

        public void Graph()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, ReviewScore From RestaurantReviews Join RestaurantProfiles On RestaurantId = RestaurantProfiles.Id";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                int count = 0;
                int conv = 0;

                while (rdr.Read())
                {
                    if (rdr[1].ToString() != null)
                    {
                        float temp = 0;

                        if (float.TryParse(rdr[1].ToString(), out temp))
                        {
                            Math.Round(temp);

                            conv = Convert.ToInt32(temp);
                        }
                        else
                        {
                            //restList[count].Rating = 0;
                        }

                        Restaurant rest = new Restaurant(rdr[0].ToString(), conv);
                        restList.Add(rest);
                    }
                    else
                    {
                        Restaurant rest = new Restaurant(rdr[0].ToString(), 0);
                        restList.Add(rest);
                    }

                    count++;
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

            restList.Sort();
            int num = 0;

            foreach (Restaurant r in restList)
            {
                if (restList[num].Rating == 0)
                {
                    Console.WriteLine(r);
                }

                num++;
            }

        }

        public void BarGraph()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();
            List<string> dataResults = new List<string>();
            List<string> dataResults2 = new List<string>();


            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, ReviewScore From RestaurantReviews Join RestaurantProfiles On RestaurantId = RestaurantProfiles.Id";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dataResults.Add(rdr[0].ToString());
                    dataResults2.Add(rdr[1].ToString());
                }

                for (int i = 0; i < dataResults2.Count; i++)
                {
                    if (dataResults2[i] != null)
                    {
                        float temp = 0;

                        if (float.TryParse(dataResults2[i], out temp))
                        {
                            Math.Round(temp);

                            int conv = Convert.ToInt32(temp);

                            tempList.Add(conv);
                        }
                        else
                        {
                            tempList.Add(0);
                        }
                    }
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

            List<int> average = new List<int>();

            int c = 0;
            for (int i = 1; i < 101; i++)
            {
                c += tempList[i];
            }

            average.Add(c / 99);

            int d = 0;
            for (int i = 101; i < 201; i++)
            {
                d += tempList[i];
            }

            average.Add(d / 99);

            int e = 0;
            for (int i = 201; i < 301; i++)
            {
                e += tempList[i];
            }

            average.Add(e / 99);

            int f = 0;
            for (int i = 301; i < 401; i++)
            {
                f += tempList[i];
            }

            average.Add(f / 99);

            int g = 0;
            for (int i = 401; i < 501; i++)
            {
                g += tempList[i];
            }

            average.Add(g / 99);

            int h = 0;
            for (int i = 501; i < 601; i++)
            {
                h += tempList[i];
            }

            average.Add(h / 99);

            int j = 0;
            for (int i = 601; i < 701; i++)
            {
                j += tempList[i];
            }

            average.Add(j / 99);

            int k = 0;
            for (int i = 701; i < 801; i++)
            {
                k += tempList[i];
            }

            average.Add(k / 99);

            int l = 0;
            for (int i = 801; i < 901; i++)
            {
                l += tempList[i];
            }

            average.Add(l / 99);

            int m = 0;
            for (int i = 901; i < 1000; i++)
            {
                m += tempList[i];
            }

            Console.WriteLine(m / 98);



            int count = 0;
            int barGraphSize = 10;

            for (int i = 0; i < 9; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{(i + 1) + "." + dataResults[i],-30}");

                int tempVar1 = average[i] / 10;

                for (int ii = 0; ii < tempVar1; ii++)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    Console.Write(" ");
                }

                double tempVar = barGraphSize - Math.Round(average[i] / 10.0);

                for (int iii = 0; iii < tempVar; iii++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;

                    Console.Write(" ");
                }

                Console.WriteLine("\n\n");

                Console.BackgroundColor = ConsoleColor.Black;
            }

        }

        public void BarGraphRand()
        {
            // Connection code
            // MySQL Database Connection String

            // Declare a MySQL Connection

            List<Restaurant> restList = new List<Restaurant>();
            List<int> tempList = new List<int>();
            List<string> dataResults = new List<string>();
            List<string> dataResults2 = new List<string>();


            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName, ReviewScore From RestaurantReviews Join RestaurantProfiles On RestaurantId = RestaurantProfiles.Id";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dataResults.Add(rdr[0].ToString());
                    dataResults2.Add(rdr[1].ToString());
                }

                for (int i = 0; i < dataResults2.Count; i++)
                {
                    if (dataResults2[i] != null)
                    {
                        float temp = 0;

                        if (float.TryParse(dataResults2[i], out temp))
                        {
                            Math.Round(temp);

                            int conv = Convert.ToInt32(temp);

                            tempList.Add(conv);
                        }
                        else
                        {
                            tempList.Add(0);
                        }
                    }
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

            List<int> average = new List<int>();

            int c = 0;
            for (int i = 1; i < 101; i++)
            {
                c += tempList[i];
            }

            average.Add(c / 99);

            int d = 0;
            for (int i = 101; i < 201; i++)
            {
                d += tempList[i];
            }

            average.Add(d / 99);

            int e = 0;
            for (int i = 201; i < 301; i++)
            {
                e += tempList[i];
            }

            average.Add(e / 99);

            int f = 0;
            for (int i = 301; i < 401; i++)
            {
                f += tempList[i];
            }

            average.Add(f / 99);

            int g = 0;
            for (int i = 401; i < 501; i++)
            {
                g += tempList[i];
            }

            average.Add(g / 99);

            int h = 0;
            for (int i = 501; i < 601; i++)
            {
                h += tempList[i];
            }

            average.Add(h / 99);

            int j = 0;
            for (int i = 601; i < 701; i++)
            {
                j += tempList[i];
            }

            average.Add(j / 99);

            int k = 0;
            for (int i = 701; i < 801; i++)
            {
                k += tempList[i];
            }

            average.Add(k / 99);

            int l = 0;
            for (int i = 801; i < 901; i++)
            {
                l += tempList[i];
            }

            average.Add(l / 99);

            int m = 0;
            for (int i = 901; i < 1000; i++)
            {
                m += tempList[i];
            }

            Console.WriteLine(m / 98);

            int barGraphSize = 10;
            Random rnd = new Random();
            int rand = rnd.Next(1, 1000);

            Console.Write($"{dataResults[rand]}  ");

            Console.ForegroundColor = ConsoleColor.White;

            int graph = rand / 1000;

            int tempVar1 = average[graph] / 10;

            for (int ii = 0; ii < tempVar1; ii++)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;

                Console.Write(" ");
            }

            double tempVar = barGraphSize - Math.Round(average[graph] / 10.0);

            for (int iii = 0; iii < tempVar; iii++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;

                Console.Write(" ");
            }

            Console.BackgroundColor = ConsoleColor.Black;

        }

        Deck deck = new Deck();

        public void Cardgame()
        {
            // Create the cards
            deck.CreateCards();

            // Shuffle the cards
            deck.Shuffle();

            // Create Lists to hold the first and last names
            List<string> dataResults = new List<string>();
            List<string> dataResults2 = new List<string>();


            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);

                conn.Open();

                // Form SQL Statement
                string stm = "Select First, Last From RestaurantReviewers Limit 4";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                // Execute SQL statement and place the returned data into rdr
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    dataResults.Add(rdr[0].ToString());
                    dataResults2.Add(rdr[1].ToString());
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

            List<Card> num = new List<Card>();
            List<Card> num1 = new List<Card>();
            List<Card> num2 = new List<Card>();
            List<Card> num3 = new List<Card>();
            int n = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            Console.Write($"{dataResults[0]} {dataResults2[0]}: ");
            for (int i = 0; i < 13; i++)
            {
                // give this person thier card
                num.Add(deck.Deal());

                // Show the card
                Console.Write(num[i]);

                // Save the value of the card so that it can be added
                n += num[i].Value;
            }

            // write their total
            Console.WriteLine($"= {n}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"{dataResults[1]} {dataResults2[1]}: ");
            for (int i = 0; i < 13; i++)
            {
                // give this person thier card
                num1.Add(deck.Deal());

                // Show the card
                Console.Write(num1[i]);

                // Save the value of the card so that it can be added
                n1 += num1[i].Value;
            }
            Console.WriteLine($"= {n1}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"{dataResults[2]} {dataResults2[2]}: ");
            for (int i = 0; i < 13; i++)
            {
                // give this person thier card
                num2.Add(deck.Deal());

                // Show the card
                Console.Write(num2[i]);

                // Save the value of the card so that it can be added
                n2 += num2[i].Value;
            }
            Console.WriteLine($"= {n2}");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"{dataResults[3]} {dataResults2[3]}: ");
            for (int i = 0; i < 13; i++)
            {
                // give this person thier card
                num3.Add(deck.Deal());

                // Show the card
                Console.Write(num3[i]);

                // Save the value of the card so that it can be added
                n3 += num3[i].Value;
            }
            Console.WriteLine($"= {n3}");

            Console.WriteLine();
            Console.WriteLine();

            // Create directory and file
            string _dir = @"..\..\output\";
            string _file = @"player.json";

            Directory.CreateDirectory(_dir);

            if (File.Exists(_dir + _file))
            {

            }
            else
            {
                File.Create(_dir + _file);
            }

            if (!File.Exists(_dir + _file))
            {
                File.Create(_dir + _file).Dispose();
            }

            // Create the Json file
            using (StreamWriter sw = new StreamWriter(_dir + _file))
            {
                sw.WriteLine("{");
                sw.WriteLine("\"Players\" : [");

                for (int i = 0; i < 4; i++)
                {
                    if (i != 4 - 1)
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"id\": \"{dataResults[i]} {dataResults2[i]}\",");
                        sw.WriteLine("},");

                    }
                    else
                    {
                        sw.WriteLine("{");
                        sw.WriteLine($"\"id\": \"{dataResults[i]} {dataResults2[i]}\",");
                        sw.WriteLine("}");
                        sw.WriteLine("]");
                        sw.WriteLine("}");
                    }
                }
            }

            Console.WriteLine("Task Finished");

            Console.WriteLine();

            Console.WriteLine("Press enter to return to the menu");
        }


    }
}
