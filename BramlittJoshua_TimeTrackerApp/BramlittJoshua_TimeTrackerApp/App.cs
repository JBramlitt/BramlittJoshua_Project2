using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BramlittJoshua_TimeTrackerApp
{
    class App
    {
        private Menu _myMenu;
        private DataCon _data;
        string temp;
        int cat;
        int des;
        int dayName;
        int dayNum;
        int date;
        int time;
        bool running = true;

        public App()
        {
            Selection();
        }

        private void Selection()
        {
            // Create the menu
            _myMenu = new Menu("Enter Activity", "View Tracked Data", "Run Calculations", "Exit");

            while (running)
            {
                _myMenu.Display();

                int selection = Validation.IntVal("Enter Selection");
                switch (selection)
                {
                    case 1:
                        {
                            Console.Clear();

                            // Go through Activity
                            Activity();
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            // Go to TrackedData Method
                            TrackedData();
                            
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();

                            // Show calculations
                            Calculations();

                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Environment.Exit(0);

                            //Console.WriteLine("Are you sure you want to exit?");
                        }
                        break;
                }
            }
        }

        // Methods

        private void Activity()
        {
            Console.Clear();
            Console.WriteLine("Select an activity category using the number");
            Console.WriteLine();

            // Show the data
            _data = new DataCon("Select category_description From activity_categories", 1);
            Console.WriteLine("31. Back");

            temp = Console.ReadLine();
            cat = Validation.IntVal(temp);

            if (cat == 31)
            {
                Console.Clear();

                // Go back to main menu
                Selection();
            }
            else
            {
                Console.Clear();

                // Show What was selected to the user
                Console.Write("You selected ");
                _data = new DataCon($"Select category_description From activity_categories Where activity_category_id = {cat}", 1);
                Console.WriteLine("Press enter to chose your activity description");

                Console.ReadKey();

                // Go to the next method
                ActDescription();
            }          
        }

        private void ActDescription()
        {
            Console.Clear();
            Console.WriteLine("Select an activity description using the number");
            Console.WriteLine();

            // Show the data
            _data = new DataCon("Select activity_description From activity_descriptions", 1);
            Console.WriteLine("40. Back");

            // Save the data to a variable
            temp = Console.ReadLine();
            des = Validation.IntVal(temp);

            if (des == 40)
            {
                Console.Clear();
                // Go back to the last method
                Activity();
            }
            else
            {
                Console.Clear();

                // Show what the user selected
                Console.Write("You selected ");
                _data = new DataCon($"Select activity_description From activity_descriptions Where activity_description_id = {des}", 1);
                Console.WriteLine("Press enter to continue ");

                Console.ReadKey();

                // Go to the next method
                DayName();
            }

        }

        private void DayName()
        {
            Console.Clear();
            Console.WriteLine("Select the day using the number");
            Console.WriteLine();

            // Show the data
            _data = new DataCon("Select day_name From days_of_the_week", 1);
            Console.WriteLine("8. Back");

            // Save the data into a variable
            temp = Console.ReadLine();
            dayName = Validation.IntVal(temp);

            if (dayName == 8)
            {
                Console.Clear();

                // Go back to the last method
                ActDescription();
            }
            else
            {
                Console.Clear();

                // Show the user what they selected
                Console.Write("You selected ");
                _data = new DataCon($"Select day_name From days_of_the_week Where day_id = {dayName}", 1);
                Console.WriteLine("Press enter to continue ");

                Console.ReadKey();

                // Go to the next method
                DateChoice();
            }
        }

        private void DateChoice()
        {
            Console.Clear();
            Console.WriteLine("Select a date using the number");
            Console.WriteLine();

            // Show the data
            _data = new DataCon("Select calendar_date From tracked_calendar_dates", 2);
            Console.WriteLine("27. Back");

            // Save the data in a variable
            temp = Console.ReadLine();
            dayNum = Validation.IntVal(temp);
            date = Validation.IntVal(temp);

            if (date == 27)
            {
                Console.Clear();

                // Go back to the last method
                DayName();
            }
            else
            {
                Console.Clear();


                // Show the user what they selected
                Console.Write("You selected ");
                _data = new DataCon($"Select calendar_date From tracked_calendar_dates Where calendar_date_id = {date}" , 2);
                Console.WriteLine("Press enter to continue ");

                Console.ReadKey();

                // Go to the next method
                ActTime();
            }
        }

        private void ActTime()
        {
            Console.Clear();
            Console.WriteLine("Select a time using the number");
            Console.WriteLine();

            // Show the data
            _data = new DataCon("Select time_spent_on_activity From activity_times", 1);
            Console.WriteLine("97. Back");

            // Save the data into a variable
            temp = Console.ReadLine();
            time = Validation.IntVal(temp);

            if (time == 97)
            {
                Console.Clear();

                // Go back to the last method
                DateChoice();
            }
            else
            {
                Console.Clear();

                // Show the user what they selected
                Console.Write("You selected ");
                _data = new DataCon($"Select time_spent_on_activity From activity_times Where activity_time_id = {time}", 1);
                Console.WriteLine("Press enter to continue ");

                Console.ReadKey();
            }

            Console.Clear();

            // Save all the collected data into the database
            _data = new DataCon("Insert Into activity_log(user_id, calendar_day, calendar_date, day_name, category_description, activity_description, time_spent_on_activity)" +
                $"Values(1, {dayNum}, {date}, {dayName}, {cat}, {des}, {time})", 3);

            //_data = new DataCon("Insert Into activity_log1(user_id, calendar_day, calendar_date, day_name, category_description, activity_description, time_spent_on_activity)" +
            //   $"Values(1, 1, 1, 1, 1, 1, 1)", 3);

            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("1. Enter Another Activity\n2. Back to Main Menu");

            temp = Console.ReadLine();
            int choice = Validation.IntVal(temp);

            if (choice == 1)
            {
                Activity();
            }
        }

        // 2nd set of Methods

        private void TrackedData()
        {
            // Create the method for TrackedData
            _myMenu = new Menu("Select By Date", "Select By Category", "Select By Description", "To Main Menu");
            _myMenu.Title = "Search Menu";

            while (running)
            {
                _myMenu.Display();

                int selection = Validation.IntVal("Enter Selection");
                switch (selection)
                {
                    case 1:
                        {
                            Console.Clear();

                            // Show the data 
                            _data = new DataCon("Select calendar_date From tracked_calendar_dates", 2);

                            // Save the data into a variable
                            temp = Console.ReadLine();
                            date = Validation.IntVal(temp);

                            Console.Clear();

                            //_data = new DataCon($"Select * From activity_log Where calendar_date = {date}", 1);
                            
                            // Show the data
                            _data.MultipleReturn($"Select activity_log.category_description From activity_log Join activity_categories ON activity_log.category_description = activity_categories.activity_category_id Where calendar_date = {date}", 1);
                            //_data.MultipleReturn($"Select activity_description From activity_log Join activity_descriptions ON activity_log.activity_description = activity_descriptions.activity_description_id Where calendar_date = {date}", 1);

                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();



                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();



                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Selection();
                            //Application app = new Application();
                            
                        }
                        break;
                }

            }  

        }

        private void Calculations()
        {
            Console.Write("Total Time Coding: ");
            Console.WriteLine();

            Console.Write("Total Time Playing Games: ");
            Console.WriteLine();

            Console.Write("Total Time Working On The Custom App: ");
            Console.WriteLine();

            Console.Write("Total Time Working On The Time Tracker App");
            Console.WriteLine();

            Console.Write("Total Time Sleeping: ");
            Console.WriteLine();

            Console.Write("Percentage of Time Sleeping: ");
            Console.WriteLine();

            Console.Write("Total Time Doing Chores: ");
            Console.WriteLine();

            Console.Write("Total Time With Friends: ");
            Console.WriteLine();

            Console.Write("Total Time in School: ");
            Console.WriteLine();

            Console.Write("Total Time Watching TV: ");
            Console.WriteLine();           
        }
    }
}
