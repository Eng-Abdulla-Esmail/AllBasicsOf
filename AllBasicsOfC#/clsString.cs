using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsOfC_
{
    internal class clsString
    {
        private string firstname;
        private string lastname;


        public clsString()
        {
            ReadName();
            Print();
        }
        public void ReadName()
        {
            Console.WriteLine("First name:");
            firstname = Console.ReadLine();
            Console.WriteLine("Last name:");
            lastname = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("Lenth of FirstName " + firstname.Length);
            Console.WriteLine("Lenth of lastname " + lastname.Length);
            Console.WriteLine("firstname as uppercase " + firstname.ToUpper());
            Console.WriteLine("lowercase of FirstName " + firstname.ToLower());
            Console.WriteLine("Full name using concat: "+ string.Concat(firstname +" ",lastname));
            Console.WriteLine("using string interpolation:");
            Console.WriteLine($"Full Name: {firstname},{lastname}");
            Console.WriteLine("substring"+ firstname.Substring(0,3));
            Console.WriteLine("index of A" + firstname.IndexOf("A"));
            Console.WriteLine("contains function"+ lastname.Contains("Abd"));
        }
    }
}
