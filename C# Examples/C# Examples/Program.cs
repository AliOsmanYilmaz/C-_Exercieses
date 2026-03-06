
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;


namespace C__Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome to the C# Exercieses!
            //Just delete "/*" and "*/".
            //Then start the program and enjoy it!



            //Area of triangle 
            /*
            int length = 0,high = 0;
            double area = 0;

            Console.WriteLine("Please enter only integer number!");

            try
            {
                Console.Write("Please enter a lenght of triangle : ");
                length = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter a high of triangle : ");
                high = Convert.ToInt32(Console.ReadLine());

                area = Convert.ToDouble((length * high)) / 2;

                Console.WriteLine("Area of triangle is : " + area);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //-----------------------------------------------------------




            //Area of circle
            /*
            double circle_area = 0;
            int radius = 0;

            Console.WriteLine("Please enter only integer number!");

            try
            {
                Console.Write("Please enter a radius of circle : ");
                radius = Convert.ToInt32(Console.ReadLine());
                circle_area = Convert.ToDouble(Math.PI * Math.Pow(radius, 2));
                Console.WriteLine("Area of circle is : " + circle_area);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //-----------------------------------------------------------




            //Calculate X
            /*
            int a,b,c;
            double x;

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"X = 2a/(3b + \u221A{"c"})");
            Console.WriteLine("Please enter only integer number!");

            try
            {
                Console.Write("Enter a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter c: ");
                c = Convert.ToInt32(Console.ReadLine());
                x = Convert.ToDouble((2 * a) / (3 * b + Math.Sqrt(c)));
                Console.WriteLine("Result: " + x);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //-----------------------------------------------------------




            //Euclidean geometry
            /*
            int p,k;
            double a, b, c, h;

            try
            {
                Console.Write("Enter p: ");
                p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter k: ");
                k = Convert.ToInt32(Console.ReadLine());

                a = p + k;

                h = Math.Sqrt(p * k);
                b = Math.Sqrt(a * k);
                c = Math.Sqrt(p * a);

                Console.WriteLine("a = p + k  => " + a);
                Console.WriteLine("h^2 = p * k => " + h);
                Console.WriteLine("b^2 = a * k => " + b);
                Console.WriteLine("c^2 = p * a => " + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //-----------------------------------------------------------




            //Coffee price
            /*
            int quantity;
            double price,discount = 1, kdv = 1.18;

            Console.WriteLine("Coffee : 20TL");
            try
            {
                Console.Write("Please enter quantity of coffee: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity! Please enter a non-negative number.");
                }

                else if (quantity > 5 & quantity < 10)
                {
                    discount = 0.9;
                }

                else if (quantity >= 10)
                {
                    discount = 0.75;
                }

                price = discount * kdv * quantity * 20;
                Console.WriteLine("Total price : " + price + " TL");
                Console.WriteLine("Have a nice day!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //-----------------------------------------------------------




            //Area and perimeter for triangle,rectangle and circle.
            /*
            int length = 0, high = 0,edge = 0, radius = 0, a = -1, b;
            double area = 0, perimeter = 0;

            void programText()
            {
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Area");
                Console.WriteLine("2 - Perimeter");
                Console.Write("Your choice: ");
            }
            try
            {
                while (a != 0)
                {
                    Console.WriteLine("0 - Exit");
                    Console.WriteLine("1 - Triangle");
                    Console.WriteLine("2 - Circle");
                    Console.WriteLine("3 - Rectangle");
                    Console.Write("Your choice: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = -1;

                    switch (a)
                    {
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;

                        case 1:
                            while (b != 0)
                            {
                                programText();
                                b = Convert.ToInt32(Console.ReadLine());

                                switch (b)
                                {
                                    case 0:
                                        Console.WriteLine("Exited");
                                        break;

                                    case 1:
                                        Console.Write("Please enter a length of triangle : ");
                                        length = Convert.ToInt32(Console.ReadLine());

                                        Console.Write("Please enter a high of triangle : ");
                                        high = Convert.ToInt32(Console.ReadLine());

                                        area = Convert.ToDouble((length * high)) / 2;

                                        Console.WriteLine("Area of triangle is : " + area);
                                        break;

                                    case 2:
                                        Console.Write("Please enter a 1.edge of triangle : ");
                                        length = Convert.ToInt32(Console.ReadLine());

                                        Console.Write("Please enter a 2.edge of triangle : ");
                                        high = Convert.ToInt32(Console.ReadLine());

                                        Console.Write("Please enter a 3.edge of triangle : ");
                                        edge = Convert.ToInt32(Console.ReadLine());

                                        perimeter = Convert.ToDouble((length + edge + high));

                                        Console.WriteLine("Area of triangle is : " + perimeter);
                                        break;

                                    default:
                                        Console.WriteLine("Wrong choice");
                                        break;
                                }
                            }
                            break;

                        case 2:
                            while (b != 0)
                            {
                                programText();
                                b = Convert.ToInt32(Console.ReadLine());

                                switch (b)
                                {
                                    case 0:
                                        Console.WriteLine("Exited");
                                        break;

                                    case 1:
                                        Console.Write("Please enter a radius of circle : ");
                                        radius = Convert.ToInt32(Console.ReadLine());
                                        area = Convert.ToDouble(Math.PI * Math.Pow(radius, 2));
                                        Console.WriteLine("Area of circle is : " + area);
                                        break;

                                    case 2:
                                        Console.Write("Please enter a radius of circle : ");
                                        radius = Convert.ToInt32(Console.ReadLine());
                                        perimeter = Convert.ToDouble(Math.PI * 2 * radius);
                                        Console.WriteLine("Perimeter of circle is : " + perimeter);
                                        break;

                                    default:
                                        Console.WriteLine("Wrong choice");
                                        break;
                                }
                            }

                            break;

                        case 3:
                            while (b != 0)
                            {
                                programText();
                                b = Convert.ToInt32(Console.ReadLine());

                                switch (b)
                                {
                                    case 0:
                                        Console.WriteLine("Exited");
                                        break;

                                    case 1:
                                        Console.Write("Please enter a lenght of rectangle : ");
                                        length = Convert.ToInt32(Console.ReadLine());

                                        Console.Write("Please enter a high of rectangle : ");
                                        high = Convert.ToInt32(Console.ReadLine());

                                        area = length * high;
                                        Console.WriteLine("Area of rectangle is : " + area);
                                        break;

                                    case 2:
                                        Console.Write("Please enter a lenght of rectangle : ");
                                        length = Convert.ToInt32(Console.ReadLine());

                                        Console.Write("Please enter a high of rectangle : ");
                                        high = Convert.ToInt32(Console.ReadLine());

                                        perimeter = 2 * (length + high);
                                        Console.WriteLine("Perimeter of rectangle is : " + perimeter);
                                        break;

                                    default:
                                        Console.WriteLine("Wrong choice");
                                        break;
                                }
                            }

                            break;

                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //-----------------------------------------------------------




            //3-digit number
            /*
            double number;

            bool isThreeDigits(double number)
            {
                bool con = false;

                if(number <= 0)
                {
                    return con;
                }

                for(int i = 1; i < 5;i++)
                {
                    double a;
                    a = number / Math.Pow(10,i);

                    if(a > 0.1 & a < 1 & i == 3)
                    {
                        con = true;
                        break;
                    }
                }

                return con;
            }


            try
            {
                do
                {
                    Console.Write("Please enter a 3-digit number: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                while (!isThreeDigits(Convert.ToDouble(number)));

                if(isThreeDigits(Convert.ToDouble(number)))
                {
                    Console.WriteLine("Your 3-digit number is : " + number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine("Please restart the program!");
            }
            */




            //---------------------------------------------------------------








        }
    }
}
