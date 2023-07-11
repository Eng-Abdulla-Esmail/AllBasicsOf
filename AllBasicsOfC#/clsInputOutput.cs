using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsOfC_
{
    internal class clsInputOutput
    {
        private int id;
        private string name;

        public void ReadInfo()
        {
            Console.WriteLine("Enter the id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
        }

        public clsInputOutput()
        {
            ReadInfo();
            WriteInfo();
        }
        public void WriteInfo() {

            if(name ==null)
            {
                Console.WriteLine("There is no data, please check that you import the readInfo Function");
              
            }
            Console.WriteLine("ID :" + this.id);
            Console.WriteLine("Name :" + this.name);
                
                
                }

    }
}
