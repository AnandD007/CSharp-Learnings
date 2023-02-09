/*
// 08 feb 2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Data_Types
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data_Types and Type Casting");
            int a = 10; // integer (whole numbers) // 4 bytes
            double b = 20; // Float values  // 8 bytes
            long bb = 60; // 8 bytes
            float cc = 67; // 4 bytes
            char c = 'A'; // holds only single character  // 2 bytes
            string d = "Anand"; // String value // 2 bytes per character
            bool e = true; // hold only true/false  // 1 bit
            Console.WriteLine("Integer: {0}\nDouble: {1}\nLong: {2}\nFloat:{3}\nChar: {4}\nString: {5}\nBool: {6}",a,b,bb,cc,c,d,e);

            // TyepCasting:

            // Implicit typecasting

            int abc = 20;
            double abcd = abc;
            Console.WriteLine(abcd);

            // Explicit Type Casting:

            double ed1 = 50.5D;
            int de1 = (int)ed1;
            Console.WriteLine(de1);

            // Type Consversion Methods:

            double aa1 = 20.8D;
            Console.WriteLine(Convert.ToString(aa1));  // returns int to string
            Console.WriteLine(Convert.ToDouble(aa1));  // return int to double
            Console.WriteLine(Convert.ToInt64(aa1));  // returns int to long             Console.WriteLine(Convert.ToString(aa1));
            Console.WriteLine(Convert.ToInt32(aa1));  // returns int to ints
            Console.Write($"{aa1}");  // another way to print the variable value (String Interpulation method.)


            // Basic Builtin Methods & Properties:
            

        }
    }
}
*/