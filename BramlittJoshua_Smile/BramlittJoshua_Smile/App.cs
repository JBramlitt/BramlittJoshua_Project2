using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Smile
{
    class App
    {
        List<int> choice = new List<int>();

        public App()
        {
            choice.Add(1);
            choice.Add(2);
            choice.Add(3);
            choice.Add(4);

            int radius = 10;
            double ratio = (4.0 / 2.0);
            double circle = ratio * radius;
            double r = radius;

            for (int i = -radius; i <= radius; i++)
            {
                for (double ii = -circle; ii <= circle; ii++)
                {
                    double draw = (ii / circle) * (ii / circle) + (i / r) * (i / r);

                    if (draw > 0.90 && draw < 1.2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
