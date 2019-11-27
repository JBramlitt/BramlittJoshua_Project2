using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Smile
{
    class Validation
    {
        public static string StringVal(string s)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine("Please do not leave this empty");
                response = Console.ReadLine();
            }
            return response;
        }

        //public static int IntVal(string s)
        //{
        //    Console.WriteLine(s);
        //    string response = Console.ReadLine();
        //    int i;
        //    while (!int.TryParse(response, out i))
        //    {
        //        Console.WriteLine("Please enter an integer");
        //        response = Console.ReadLine();
        //    }
        //    return i;
        //}

        public static int IntVal(string s, int min, int max)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            int i;

            while (!int.TryParse(response, out i) || i < min || i > max)
            {
                Console.WriteLine("Please enter a valid integer within specified range");
                response = Console.ReadLine();
            }
            return i;
        }

        public static int IntVal(string s)
        {
            int i;

            while (!int.TryParse(s, out i))
            {
                Console.WriteLine("Please enter a valid integer within specified range");
                s = Console.ReadLine();
            }
            return i;
        }

        public static decimal DecimalVal(string s)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            decimal d;
            while (!decimal.TryParse(response, out d))
            {
                Console.WriteLine("Please enter a decimal number");
                response = Console.ReadLine();
            }
            return d;
        }

        public static double DoubleVal(string s)
        {
            Console.WriteLine();
            string response = Console.ReadLine();
            double d;
            while (!double.TryParse(response, out d))
            {
                Console.WriteLine("Please enter a valid number");
                response = Console.ReadLine();
            }
            return d;
        }

        public static float FloatVal(string s)
        {
            Console.WriteLine(s);
            string response = Console.ReadLine();
            float f;
            while (!float.TryParse(response, out f))
            {
                Console.WriteLine("Please enter a valid number");
                response = Console.ReadLine();
            }
            return f;
        }

        
    }
}
