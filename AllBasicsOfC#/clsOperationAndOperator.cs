using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsOfC_
{
    internal class clsOperationAndOperator
    {
        private int num1;
        private int num2;


        public clsOperationAndOperator()
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

        public void PrintResult() { 
             Console.WriteLine("sumation "  +(num1+num2));
            Console.WriteLine("subtraction " + (num1 - num2));
            Console.WriteLine("multiplicaton" + (num1 * num2));
            Console.WriteLine("division" + (num1 / num2));
            Console.WriteLine("modular" + (num1 % num2));
            Console.WriteLine(" greater than >" + (num1 > num2));
            Console.WriteLine("Less than <" + (num1 < num2));
            Console.WriteLine("equal ==" + (num1 == num2));
            Console.WriteLine("not equal  !=" + (num1 != num2));
            Console.WriteLine("and &&" + (num1 > num2 && num2<num1));
            Console.WriteLine("Or ||" + (num1 > num2 || num2 < num1));
            Console.WriteLine("not  !plus &&" + (!(num1 > num2 && num2 < num1)));
            Console.WriteLine("" + (num1 + num2));

        }
    }
}
