using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LoopDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            bool choice = false;
            string product = " ";
            int count = 0;
            do
            {
                Console.WriteLine("What do you want to buy? ");
                product = Console.ReadLine();
                list.Add(product);
                Console.WriteLine("Do you wanto other product(y/n)?");
                string bchoice = Console.ReadLine();
                if (bchoice == "y")
                {
                    choice = true;
                }
                else
                {
                    choice = false;
                }
                count += 1;
            }
            while (choice == true);

            Console.WriteLine("Your fruit list is: ");
            for( int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.Read();
               
   
                
            
                

              
        }
    }
}
