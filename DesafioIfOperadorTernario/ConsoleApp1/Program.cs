﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperaturaIngresada = 0;
            string mensajeTemperatura = string.Empty;
            string valorIngressado = string.Empty;

            Console.WriteLine("Ingrese la temperatura actual: ");
            valorIngressado = Console.ReadLine(); 

            bool integerValido = int.TryParse(valorIngressado, out temperaturaIngresada);

            if(integerValido)
            {
                mensajeTemperatura = temperaturaIngresada <= 15 ?
                    //si es verdadero
                    "Hace mucho frio" :
                    //si es falso
                    (temperaturaIngresada >= 16 && temperaturaIngresada <= 28) ?
                    //si çes verdadero
                    "Hace un clima agradable!" :
                    //si es falso
                    temperaturaIngresada > 28 ?
                    //si es verdadero
                    "Hace mucho calor" :
                    //si es falso
                    "";

                Console.WriteLine(mensajeTemperatura);
            }
            else
            {
                Console.WriteLine("Esa no es una temperatura válida");
            }
            Console.ReadKey();

        }
    }
}
