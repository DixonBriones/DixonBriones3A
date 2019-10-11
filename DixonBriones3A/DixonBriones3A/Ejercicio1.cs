using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio1
    {
        public static Ejercicio1 Eje1(Ejercicio1 eje)
        {
            Console.WriteLine("Ingrese la cantidad de numeros a leer");
              int numero = Convert.ToInt16(Console.ReadLine());
              int[] n= new int[numero];
              int aux = n[0];
                  for (int i = 0; i < numero; i++)
                  {
                  Console.WriteLine("Ingrese un numero");
                  n[i] = Convert.ToInt16(Console.ReadLine());

                  }
                  for (int i = 0; i < numero; i++)
                  {
                      if (n[i] > aux)
                      {
                      aux = n[i];
                      }
                  }
              Console.WriteLine("El numero mayor es: " + aux + "\n");
            
            return null;
        }

    }
}