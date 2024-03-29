﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BramlittJoshua_Smile
{
    class App
    {
        // create a list for the choices
        List<int> choice = new List<int>();

        public App()
        {
            // Add the numbers
            choice.Add(1);
            choice.Add(2);
            choice.Add(3);
            choice.Add(4);


            // Chose which color and symbol
            Console.WriteLine("Which color do you want?");
            Console.WriteLine("1. Gray \n2. Yellow \n3. Black \n4.Red");

            string temp = Console.ReadLine();
            int chosen = Validation.IntVal(temp);

            Console.WriteLine("Which Symbol do you want it drawn in?");
            Console.WriteLine("1. $ \n2. @ \n3. * \n4.&");

            string t = Console.ReadLine();
            int c = Validation.IntVal(t);

            switch (chosen)
            {
                case 1:
                    {
                        Console.Clear();

                        // Set the color
                        Console.ForegroundColor = ConsoleColor.Gray;

                        switch (c)
                        {
                            case 1:
                                {
                                    // Create the main circle
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
                                                Console.Write("$");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("$$$$$");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("$$$$$");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("$$$$$$$$$$$");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("$$$");


                                    Console.ReadKey();
                                }
                                break;

                            case 2:
                                {
                                    // Create the main circle
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
                                                Console.Write("@");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("@@@@@");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("@@@@@");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("@@@@@@@@@@@");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("@@@");


                                    Console.ReadKey();
                                }
                                break;

                            case 3:
                                {
                                    // Create the main circle
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

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("*****");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("*****");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("***********");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("***");


                                    Console.ReadKey();
                                    Console.ReadKey();
                                }
                                break;

                            case 4:
                                {
                                    // Create the main circle
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
                                                Console.Write("&");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("&&&&&");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("&&&&&");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("&&&&&&&&&&&");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("&&&");


                                    Console.ReadKey();
                                }
                                break;

                            default:
                                {

                                }
                                break;
                        }
                        
                    }
                    break;

                case 2:
                    {
                        Console.Clear();

                        // Set the color
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        switch (c)
                        {
                            case 1:
                                {
                                    // Create the main circle
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
                                                Console.Write("$");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("$$$$$");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("$$$$$");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("$$$$$$$$$$$");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("$$$");


                                    Console.ReadKey();
                                }
                                break;

                            case 2:
                                {
                                    // Create the main circle
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
                                                Console.Write("@");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("@@@@@");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("@@@@@");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("@@@@@@@@@@@");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("@@@");


                                    Console.ReadKey();
                                }
                                break;

                            case 3:
                                {
                                    // Create the main circle
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

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("*****");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("*****");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("***********");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("***");


                                    Console.ReadKey();
                                }
                                break;

                            case 4:
                                {
                                    // Create the main circle
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
                                                Console.Write("&");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("&&&&&");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("&&&&&");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("&&&&&&&&&&&");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("&&&");


                                    Console.ReadKey();
                                }
                                break;

                            default:
                                {

                                }
                                break;
                        }
                    }
                    break;

                case 3:
                    {
                        Console.Clear();

                        // Set the color
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.BackgroundColor = ConsoleColor.White;

                        switch (c)
                        {
                            case 1:
                                {
                                    // Create the main circle
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
                                                Console.Write("$");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("$$$$$");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("$$$$$");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("$$$$$$$$$$$");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("$$$");


                                    Console.ReadKey();
                                }
                                break;

                            case 2:
                                {
                                    // Create the main circle
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
                                                Console.Write("@");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("@@@@@");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("@@@@@");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("@@@@@@@@@@@");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("@@@");


                                    Console.ReadKey();
                                }
                                break;

                            case 3:
                                {
                                    // Create the main circle
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

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("*****");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("*****");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("***********");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("***");


                                    Console.ReadKey();
                                }
                                break;

                            case 4:
                                {
                                    // Create the main circle
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
                                                Console.Write("&");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("&&&&&");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("&&&&&");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("&&&&&&&&&&&");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("&&&");


                                    Console.ReadKey();
                                }
                                break;

                            default:
                                {

                                }
                                break;
                        }

                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    break;

                case 4:
                    {
                        Console.Clear();

                        // Set the color
                        Console.ForegroundColor = ConsoleColor.Red;

                        switch (c)
                        {
                            case 1:
                                {
                                    // Create the main circle
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
                                                Console.Write("$");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("$$$$$");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("$$$$$");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("$$ $$");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("$$$$$");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("$$$$$$$$$$$");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("$$$");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("$$$");


                                    Console.ReadKey();
                                }
                                break;

                            case 2:
                                {
                                    // Create the main circle
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
                                                Console.Write("@");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("@@@@@");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("@@@@@");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("@@ @@");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("@@@@@");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("@@@@@@@@@@@");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("@@@");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("@@@");


                                    Console.ReadKey();
                                }
                                break;

                            case 3:
                                {
                                    // Create the main circle
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

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("*****");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("*****");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("** **");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("*****");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("***********");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("***");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("***");


                                    Console.ReadKey();
                                }
                                break;

                            case 4:
                                {
                                    // Create the main circle
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
                                                Console.Write("&");
                                            }
                                            else
                                            {
                                                Console.Write(" ");
                                            }
                                        }
                                        Console.WriteLine();
                                    }

                                    // Move the cursor position for the left eye
                                    Console.SetCursorPosition(10, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(10, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(10, 7);
                                    Console.WriteLine("&&&&&");

                                    // Move the cursor psition for the right eye
                                    Console.SetCursorPosition(25, 5);
                                    Console.WriteLine("&&&&&");
                                    Console.SetCursorPosition(25, 6);
                                    Console.WriteLine("&& &&");
                                    Console.SetCursorPosition(25, 7);
                                    Console.WriteLine("&&&&&");


                                    // Move the cursor for the mouth
                                    Console.SetCursorPosition(11, 12);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(13, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(15, 14);
                                    Console.WriteLine("&&&&&&&&&&&");
                                    Console.SetCursorPosition(25, 13);
                                    Console.WriteLine("&&&");
                                    Console.SetCursorPosition(27, 12);
                                    Console.WriteLine("&&&");


                                    Console.ReadKey();
                                }
                                break;

                            default:
                                {

                                }
                                break;
                        }
                    }
                    break;

                default:
                    {

                    }
                    break;

            }

            
        }
    }
}
