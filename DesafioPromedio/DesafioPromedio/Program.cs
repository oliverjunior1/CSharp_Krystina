using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type how much grades do you want to type:");
            string amountU = Console.ReadLine();
            int amount = Convert.ToInt32(amountU);
            string gradeU = "";
            int sum = 0;

            for(int i = 0; i < amount; i++)
            {
                if ()
                Console.WriteLine("Enter the " + (i + 1) + "º grade.");
                gradeU = Console.ReadLine();
                int grade = Convert.ToInt32(gradeU);
                sum += grade;
                
                
            }
            int average = sum / amount;

            Console.WriteLine("The average of the notes is: " + average);
            Console.Read();
        }
        
    }
}
