// Feb 09 2023

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class conditional_cases_and_loop_statements
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            // if conditional statements
            Console.WriteLine("Conditional statements(if, else, else if):");
            if (a == b)
            {
                Console.WriteLine(a);
            }
            if (a > b)
            {
                Console.WriteLine("{0} greater than {1}", a, b);
            }
            // using if else statements:
            if (b > a)
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            else
            {
                Console.WriteLine("{0} is smaller than {1}", a, b);
            }
            // using if,else if, else statements:
            if ("Anand" != "anand")
            {
                Console.WriteLine("Anand is not equal to anand");
            }
            else if ("Anand" == "anand")
            {
                Console.WriteLine("Anand is equal to anand");
            }
            else
            {
                Console.WriteLine("Invalid condition");
            }

            // Looping statements:
            int i = 0;
            Console.WriteLine("\nLooping Statements:\n");
            Console.WriteLine("While Loop:");
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            int j = 0;
            Console.WriteLine("Do While Loop:");
            do
            {
                Console.WriteLine("Anand");
                j++;
            } while (j < 10);
            Console.WriteLine("For Loop:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int[] s1 = {10, 20, 30, 40, 50};
            Console.WriteLine("Foreach Loop using break & Continue statement:");
            foreach (int z in s1)
            {
                Console.WriteLine(z);
                if(z == 30)
                {
                    Console.WriteLine("Loop Ended because break statement is called..!");
                    break; // exits from the loop if condition is statisfied
                }
                else if(z == 50)
                {
                    Console.WriteLine("This loop is skipped because of continue statement is called..!");
                    continue;
                }

            }
            // Switch case statements:
            Console.WriteLine("\nSwitch Case Statements:\n");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Invalid Value");
                    break;
            }

        }
    }
}