using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio2
    {
        public static Ejercicio2 Eje2(Ejercicio2 eje2)
        {
            Console.WriteLine("Ingrese el tamaño del cuadrado");
            int numero = Convert.ToInt16(Console.ReadLine());
          
            for (int i = 0; i < numero; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

  
            for (int i = 0; i < numero - 2; i++)
            {
                Console.Write("*"); ;
                for (int j = 0; j < numero - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine(" ");
            }

 
            for (int i = 0; i < numero; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            return null;
        }

    }
}