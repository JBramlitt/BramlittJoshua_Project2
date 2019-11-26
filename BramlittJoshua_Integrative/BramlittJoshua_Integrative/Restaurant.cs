using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Integrative
{
    class Restaurant : IComparable<Restaurant>
    {
        List<string> stars = new List<string>();
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Hours { get; set; }
        public string Price { get; set; }
        public string Location { get; set; }
        public string Cuisine { get; set; }
        public string FoodRate { get; set; }
        public string ServRate { get; set; }
        public string AmbRate { get; set; }
        public string ValRate { get; set; }
        public string OverRate { get; set; }
        public string PosRate { get; set; }
        public int Rating { get; set; }
        public string RatingS;
        

        public Restaurant(string n, int r)
        {
            Name = n;
            Rating = r;
        }

        public Restaurant(string i, string n, string a, string p, string h, string price, string l, string c, string fR, string sR, string aR, string vR, string oR, string pR)
        {
            ID = i;
            Name = n;
            Address = a;
            Phone = p;
            Hours = h;
            Price = price;
            Location = l;
            Cuisine = c;
            FoodRate = fR;
            ServRate = sR;
            AmbRate = aR;
            ValRate = vR;
            OverRate = oR;
            PosRate = pR;
        }

        public int CompareTo(Restaurant other)
        {
            return Rating.CompareTo(other.Rating);
        }

        //public void Conversion()
        //{
        //    int tempvar = (5 - Rating);    

        //    if (Rating == 1)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.Write($"{"*"}", -6);

        //        for (int j = 0; j < tempvar; j++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //            Console.Write("*");
        //        }

        //        Console.WriteLine();
        //    }
        //    else if (Rating == 2)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.Write($"{"**"}", -6);

        //        for (int j = 0; j < tempvar; j++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //            Console.Write("*");
        //        }

        //        Console.WriteLine();
        //    }
        //    else if (Rating == 3)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.Write($"{"***"}", -6);

        //        for (int j = 0; j < tempvar; j++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //            Console.Write("*");
        //        }

        //        Console.WriteLine();
        //    }
        //    else if (Rating == 4)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.Write($"{"****"}", -6);

        //        for (int j = 0; j < tempvar; j++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Gray;
        //            Console.Write("*");
        //        }

        //        Console.WriteLine();
        //    }
        //    else if (Rating == 5)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.Write($"{"*****"}", -6);

        //        Console.WriteLine();
        //    }
        //    else if (Rating == 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine("*****");
        //    }
        //}

        public override string ToString()
        {
            int tempvar = (5 - Rating);

            if (Rating == 1)
            {
                
                return $"{Name, -45}{"*", -6}";
                
            }
            else if (Rating == 2)
            {
                
                return $"{Name,-45}{"**",-6}";
            }
            else if (Rating == 3)
            {
                
                return $"{Name,-45}{"***",-6}";
            }
            else if (Rating == 4)
            {
                
                return $"{Name,-45}{"****",-6}";
            }
            else if (Rating == 5)
            {
                
                return $"{Name,-45}{"*****", -6}";
            }
            else if (Rating == 0)
            {
                return $"{Name,-45}{"0", -6}";
            }
            else
            {
                return $"{Name,-50} {Rating,-6}";
            }
        }
    }
}
