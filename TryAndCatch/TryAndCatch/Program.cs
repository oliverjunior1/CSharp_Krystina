using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please, enter a number: ");
            string valorIngressado = Console.ReadLine();

            try
            {
                int valorComoInt = int.Parse(valorIngressado);
            }
            catch (OverflowException)
            {
                Console.WriteLine("not a number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("It's very large!");
            }

            finally
            {
                Console.WriteLine("This text showed in all the cases!");
            }
            Console.Read();
            

            try 
            {
                int division = 2/0;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division for zero isn't valid!");
            }
            Console.ReadLine();
            
            Console.WriteLine("Ponga la temperatura: ");
            string tempString = Console.ReadLine();
            int temperatura = int.Parse(tempString);

            if(temperatura<10)
            {
                Console.WriteLine("Abriga-te");
            }
            else
            {
                Console.WriteLine("Está cálido");
            }
            Console.Read();
            
            Console.WriteLine("Enter Your UserName: ");
            string name = Console.ReadLine();
            

            if(name == "Joaquim" || name == "Manuel")
                {
                Console.WriteLine("Valid User, go ahead.");
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                if (password == "0000" || password == "01234" || password == "0a1b")
                { Console.WriteLine("User " + name + " logged! Thank You!"); }
                else
                {
                    Console.WriteLine("Access Denied, go away!!!");
                }


            }
            else
            {
                Console.WriteLine("Access Denied, go away!!!");
            }



            Console.Read();
            


            Console.WriteLine("Enter the name of the player: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the score of the player: ");
            string score = Console.ReadLine();
            int newScore = int.Parse(score);
            int recordT = 1000;

             void record()
            {
                if (newScore <= recordT) 
                {
                    Console.WriteLine("The record is for the machine: " + recordT);
                }
                else
                {
                    Console.WriteLine("Congratulations, the new record is maked for:"+ name + " \nscore "+ newScore);
                    recordT = newScore;
                }
            }
            record();
            Console.Read();
            
            Console.WriteLine("Type the temperature:");
            string temp = Console.ReadLine();
            int temperatura = int.Parse(temp);


            string agua = temperatura > 99 ? "gasoso" : temperatura < 0 ? "solido" : "liquido";
                Console.WriteLine("El estado del agua es " + agua);
            Console.Read();
            */
            Console.WriteLine("Type a temperature: ");
            string temp = Console.ReadLine();

            if(temp != int )
            {
                Console.WriteLine("Not a number");
            }
        }


    }
}
