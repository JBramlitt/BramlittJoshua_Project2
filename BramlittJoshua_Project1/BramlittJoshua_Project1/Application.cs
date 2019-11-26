using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BramlittJoshua_Project1
{
    class Application
    {
        private Menu _myMenu = new Menu("Log In", "Create New User", "Exit");
        private DataCon _data;
        string temp;
        int result;
        string insert;


        public Application()
        {
            Selection();
        }

        private void Selection()
        {
            bool running = true;

            while (running)
            {
                _myMenu.Display();

                int selection = Validation.IntVal("Enter Selection");
                switch (selection)
                {
                    case 1:
                        {
                            Console.Clear();

                            Console.WriteLine("What is your username?");

                            // Save the username into a variable
                            temp = Console.ReadLine();
                            string username = Validation.StringVal(temp, 1);

                            Console.WriteLine("What is your password?");

                            // Save the password into a variable
                            temp = Console.ReadLine();
                            string password = Validation.StringVal(temp, 1);

                            // Insert the new user into the database
                            _data = new DataCon($"Select username From User Where password = \'{password}\'", 3);

                            Console.WriteLine("\nPress enter to continue");

                            Console.ReadKey();


                            Console.Clear();
                            NewNote();
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            NewUser();
                        }
                        break;

                    case 3:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }

        // Methods
        public void NewUser()
        {
            Console.WriteLine("What is your username?");

            // Save the username into a variable
            temp = Console.ReadLine();
            string username = Validation.StringVal(temp, 1);

            Console.WriteLine("What is your password?");

            // Save the password into a variable
            temp = Console.ReadLine();
            string password = Validation.StringVal(temp, 1);

            // Insert the new user into the database
            _data = new DataCon($"Insert Into User(username, password) Values(\'{username}\', \'{password}\')", 3);

            Console.WriteLine("\nPress enter to continue");

            // Go to see the notes
            NewNote();
        }

        public void NewNote()
        {
            // Show options for notes
            Console.WriteLine("1. Create New Note");
            Console.WriteLine("2. Create Hidden Note");
            Console.WriteLine("3. Hidden Note");
            Console.WriteLine("4. Delete Note");
            Console.WriteLine("5. Go To Log In Menu");
            Console.WriteLine();
            _data = new DataCon("Select note_name From Notes",1);

            // Read in the input and change to an int
            temp = Console.ReadLine();
            result = Validation.IntVal(temp);

            // Use the in to do something off of
            switch (result)
            {
                case 1:
                    {
                        Console.Clear();

                        // Ask for the name of the note
                        Console.WriteLine("What is the name of your note?");

                        // Save the data into a variable
                        temp = Console.ReadLine();
                        insert = Validation.StringVal(temp, 1);

                        Console.Clear();

                        Console.WriteLine($"{insert} Content:");

                        // Save the data
                        temp = Console.ReadLine();
                        string noteContent = temp;

                        // Insert the data into the database
                        //_data = new DataCon($"Insert Into Notes(note_name, note_content) Values(\'NewNote\', \"Custom\");", 3);
                        _data = new DataCon($"Insert Into Notes(note_name, note_content) Values(\'{insert}\', \"{noteContent}\");", 3);


                        Console.WriteLine("\nPress enter to continue");
                        Console.ReadKey();

                        Console.Clear();

                        //Call the menu back up
                        NewNote();
                    }
                                
                    break;

                case 2:
                    {
                        Console.Clear();
                        // Ask for the code
                        Console.WriteLine("What is the 4 digit code for your note?");

                        // Save the data
                        temp = Console.ReadLine();
                        int code = Validation.IntVal(temp, 999, 10000);


                        // Ask for the name of the note
                        Console.WriteLine("What is the name of your note?");

                        // Save the data into a variable
                        temp = Console.ReadLine();
                        insert = Validation.StringVal(temp, 1);

                        Console.Clear();

                        Console.WriteLine($"{insert} Content:");

                        // Save the data
                        temp = Console.ReadLine();
                        string noteContent = temp;

                        // Insert the data into the database
                        //_data = new DataCon($"Insert Into Notes(note_name, note_content) Values(\'NewNote\', \"Custom\");", 3);
                        _data = new DataCon($"Insert Into Notes(note_name, note_password, note_content) Values(\'{insert}\', {code} ,\"{noteContent}\");", 3);


                        Console.WriteLine("\nPress enter to continue");
                        Console.ReadKey();

                        Console.Clear();

                        //Call the menu back up
                        NewNote();
                    }
                    break;

                case 3:
                    {
                        Console.Clear();

                        // Ask to enter the code
                        Console.WriteLine("Please enter the 4 digit code to access the note.");

                        // Read in the data and change to an int
                        temp = Console.ReadLine();
                        result = Validation.IntVal(temp, 999, 10000);

                        // Check to see if the code is in the database
                        _data = new DataCon($"Select note_content From Notes Where note_password = {result}",1);

                        Console.WriteLine("\nPress enter to continue");
                        Console.ReadKey();

                        Console.Clear();

                        //Call the menu back up
                        NewNote();
                    }
                    break;

                case 4:
                    {
                        Console.Clear();

                        // Show the notes
                        _data = new DataCon("Select note_name From Notes", 1);

                        Console.WriteLine("Which note would you like to Delete?");

                        // Collect the data
                        temp = Console.ReadLine();
                        result = Validation.IntVal(temp);

                        // Delete the note
                        _data = new DataCon($"Delete From Notes Where note_id = {result - 5}",1);

                        Console.WriteLine("\nPress enter to continue");
                        Console.ReadKey();

                        Console.Clear();

                        //Call the menu back up
                        NewNote();
                    }
                    break;

                case 5:
                    {
                        
                    }
                    break;

                default:
                    {
                        Console.Clear();

                        //Show the note that was chosen
                        _data = new DataCon($"Select note_content From Notes Where note_id = {result - 5}", 1);


                        Console.WriteLine("\nPress enter to continue");
                        Console.ReadKey();

                        Console.Clear();

                        //Call the menu back up
                        NewNote();
                    }
                    break;
            }
        }
    }
}
