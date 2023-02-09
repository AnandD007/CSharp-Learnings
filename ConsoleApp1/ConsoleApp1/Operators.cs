/*
// feb 08 2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Operators
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            // Arithmetic Operators
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine("Addition: {0}", a + b);
            Console.WriteLine("Multiplication: {0}", a * b);
            Console.WriteLine("Subtraction: {0}", a - b);
            Console.WriteLine("Division: {0}", a / b);
            Console.WriteLine("Modulus: {0}", a % b);
            a++;
            Console.WriteLine("Incrementation: {0}",a);
            b--;
            Console.WriteLine("Decrementation: {0}", b);

            // Assignment Operators:
            // =, +=, -=, /=, %=, |=, &=, ^=, *=, >>=, <<=
            
            int e = 50;
            int f = 60;
            e += f; // e = e + f
            Console.WriteLine(e);
            e -= f; // e = e - f
            Console.WriteLine(e);
            e /= 10;
            Console.WriteLine(e);
            e *= 5;
            Console.WriteLine(e);
            e |= 5;
            Console.WriteLine(e);
            e &= 10;
            Console.WriteLine(e);
            e ^= 2;
            Console.WriteLine(e);
            e >>= 2;
            Console.WriteLine(e);
            e <<= 2;
            Console.WriteLine(e);

            // Comparision or relational operators:
            Console.WriteLine("Comparision Operators:");
            // ==, <=, >=, <, >, !=
            // it returns the boolean value
            int k = 10;
            int l = 20;

            // Logical Opreators:
            Console.WriteLine("Logical Operators:");
            bool m = true;
            bool n = false;
            // 1. && - Logical AND 
            Console.WriteLine(m&&n);
            // 2. || - Logical OR
            Console.WriteLine(m||n);
            // 3. !  - Logical NOT
            Console.WriteLine(!(m && n));
             
        }
    }
}
*/