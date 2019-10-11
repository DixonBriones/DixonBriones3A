using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio5
    {
        public static Ejercicio5 Eje5(Ejercicio5 eje)
        {
            Console.WriteLine("Ingrese un numero entero");
            int nivel = Convert.ToInt16(Console.ReadLine());
                int aste;
                int espacios;
                for (int i = 1; i <= nivel; i++)
                {
                 espacios = nivel - i;
                 aste = i + (i - 1);
                    for (int i1 = 0; i1 < espacios; i1++) { 
                    Console.Write(" ");
                    }
                    for (int i2 = 0; i2 < aste; i2++) {
                    Console.Write("*");
                    }
                Console.WriteLine("");

                }
            
            return null;
        }

    }
}