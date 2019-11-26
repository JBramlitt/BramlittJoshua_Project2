using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BramlittJoshua_Integrative
{
    class Application
    {
        private Menu _myMenu;
        private DataCon _data;
        Deck deck = new Deck();
        Dictionary<string, List<Card>> playerHands = new Dictionary<string, List<Card>>();


        public Application()
        {
            Selection();
        }

        private void Selection()
        {
            _myMenu = new Menu("Convert Reviews From SQL to JSON", "Showcase our 5 Star Rating System", "Showcase our Animated Bar Graph Review System", "Play a Card Game", "Exit");
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

                            _data = new DataCon();
                            _data.ToJson();

                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            FiveStarRating();
                            
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();

                            BarGraphSystem();

                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.Cardgame();

                            Console.ReadKey();
                        }
                        break;

                    case 5:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }

        //Methods

        private void FiveStarRating()
        {
            _myMenu = new Menu("List Restaurants Alphebetically", "List Restaurants Reverse Aplphebetical", "Sort Restaurants From Best to Worst", "Sort Restaurants From Worst to Best", "Show Only X and Up", "Exit");
            _myMenu.Title = "Rating Menu";

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

                            _data = new DataCon();
                            _data.Alphabet();

                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.ReverseAlphabet();

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.BestToWorst();

                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.WorstToBest();

                            Console.ReadKey();

                        }
                        break;

                    case 5:
                        {
                            Console.Clear();

                            XAndUp();
                        }
                        break;

                    case 6:
                        {
                            Selection();
                        }
                        break;
                }
            }
        }

        private void XAndUp()
        {
            _myMenu = new Menu("Show the Best", "4 and Up", "3 and Up", "Show One Star", "Unrated", "Exit");
            _myMenu.Title = "X and Up Menu";

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

                            _data = new DataCon();
                            _data.FiveStars();

                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.FourAndUp();

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.ThreeAndUp();

                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.OneStar();

                            Console.ReadKey();
                        }
                        break;

                    case 5:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.Unrated();

                            Console.ReadKey();
                        }
                        break;

                    case 6:
                        {
                            Selection();
                        }
                        break;
                }
            }
        }

        private void BarGraphSystem()
        {
            _myMenu = new Menu("Show Average of Reviews for Restaurants", "Dinner Spinner", "Top 10 Restaurants", "Back to Main Menu");
            _myMenu.Title = "Bar Graph Menu";

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

                            _data = new DataCon();
                            _data.BarGraph();

                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.BarGraphRand();

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.Clear();

                            _data = new DataCon();
                            _data.BarGraph();

                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            Selection();
                        }
                        break;

                }
            }
        }

    }
}
