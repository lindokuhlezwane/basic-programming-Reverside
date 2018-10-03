using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            static void findlarge( int n1, int n2, int n3)
            {
             
                Console.WriteLine("Enter Three no:");
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = Convert.ToInt32(Console.ReadLine());
                if (n1 > n2)
                    if (n1 > n3)
                    {
                        Console.WriteLine("The Greatest Of Three numbers are:" + n1);
                    }
                    else
                    {
                        Console.WriteLine("The Greatest Of Three numbers are:" + n3);
                    }
                else
                       if (n2 > n3)
                {
                    Console.WriteLine("The Greatest Of Three numbers are:" + n2);
                }
                else
                {
                    Console.WriteLine("The Greatest Of Three numbers are:" + n3);
                }
            }

            static void findSecondLargest()
            {
                Console.WriteLine("\n\n\t\tStudytonight - Best place to learn\n\n\n");

                double a, b, c;

                Console.WriteLine("Enter 3 numbers:\n");
                Console.WriteLine("%lf%lf%lf", &a, &b, &c);  //lf is a format specifier to take double as input

                // a is the largest
                if (a >= b && a >= c)
                {
                    if (b >= c)
                    {
                        /*
                            .2lf restricts the number till 
                            2 decimal places
                        */
                        Console.WriteLine("\n\n%.2lf is the 2nd largest number\n", b);
                    }
                    else
                    {
                        Console.WriteLine("\n\n%.2lf is the 2nd largest number\n", c);
                    }
                }
                else if (b >= a && b >= c)
                {
                    if (a >= c)
                    {
                        Console.WriteLine("\n\n%.2lf is the 2nd largest number\n", a);
                    }
                    else
                    {
                        Console.WriteLine("\n\n%.2lf is the 2nd largest number\n", c);
                    }
                }

                // c is the largest number of the three
                else if (a >= b)
                {
                    Console.WriteLine("\n\n%.2lf is the 2nd largest number\n", a);
    else
    {
                        Console.WriteLine("\n\n%.2lf is the 2nd largest number\n", b);
                    }

                    Console.WriteLine("\n\n\t\t\tCoding is Fun !\n\n\n");
                    //return 0;
                }


                static void findLargest()
                {
                    int[] array = new int[10];
                    Console.WriteLine("enter the array elements to b sorted");
                    for (int i = 0; i < 10; i++)
                    {
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int smallest = array[0];
                    for (int i = 0; i < 10; i++)

                    {
                        if (array[i] < smallest)
                        {
                            smallest = array[i];

                        }
                    }
                    int largest = array[9];
                    for (int i = 0; i < 10; i++)
                    {

                        if (array[i] > largest)
                        {
                            largest = array[i];

                        }
                    }
                    Console.WriteLine("the smallest no is {0}", smallest);
                    Console.WriteLine("the largest no is {0}", largest);
                    Console.Read();


                }

                static void fizzbuzz()
                {
                    for (var i = 1; i <= 100; i++)
                    {
                        if (i % 15 === 0)
                        {
                         Console.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 === 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (i % 5 === 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i)
                      }
                    }

                    static void checkNumStatus()
                    {
                        float num;
                        Console.WriteLine("Enter a number: ");
                        num = Int32.Parse(Console.ReadLine());
                        if (num <= 0)
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("You Entered zero.");
                            }
                            else
                            {
                                Console.WriteLine(num + " is Negative.");
                            }
                        }
                        else
                        {
                            Console.WriteLine(num + " is Positive.");
                        }
                        Console.ReadKey();

                    }

                    static void CheckEven()
                    {
                        static void Main(string[] args)
                        {
                            int i;
                            Console.Write("Enter a Number : ");
                            i = int.Parse(Console.ReadLine());
                            if (i % 2 == 0)
                            {
                                Console.Write("Entered Number is an Even Number");
                                Console.Read();
                            }
                            else
                            {
                                Console.Write("Entered Number is an Odd Number");
                                Console.Read();
                            }
                        }


                        static void checkLeapYear()
                        {
                            int x = int.Parse(Console.ReadLine());

                            if ((x % 400 == 0) || (x % 100 == 0) || (x % 4 == 0))
                            {
                                Console.WriteLine(" \n\n\n The year is a leap year ...!");
                            }
                            else
                            {
                                Console.WriteLine("\n\n\n The year is not a leap year");
                            }
                        }
                        


                }

