using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsOfC_
{
    internal class clsMathFunction
    {
        private int num1;
        private int num2;



        public clsMathFunction()
        {
            ReadNumber();
            PrintResult();
        }

        public void ReadNumber()
        {
            Console.WriteLine("num1 ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Num2 ");
            num2 = int.Parse(Console.ReadLine());
        }

        public void PrintResult()
        { 
            Console.WriteLine("Max       " + (Math.Max(num1, num2)));
            Console.WriteLine("Min       " + (Math.Min(num2, num1)));
            Console.WriteLine("Pi        " + (Math.PI));
            Console.WriteLine("Abs       " + (Math.Abs(num1)));
            Console.WriteLine("Sqrt      " + (Math.Sqrt(num1)));
            Console.WriteLine("Ceiling   " + (Math.Ceiling(25.53)));
            Console.WriteLine("Floor     " + (Math.Floor(25.50)));
            Console.WriteLine("Round     " + (Math.Round(35.5746)));
            Console.WriteLine("Truncate  " + (Math.Truncate(23.5363)));
        

        }
    }
}
