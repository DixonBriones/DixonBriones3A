using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio10
    {
        public static Ejercicio10 Eje10(Ejercicio10 eje10)
        {
            int n;
            Boolean salida = false;
            do
            {
                Console.WriteLine("Escoja una opcion \n" +
                              "(1) Salir \n" +
                              "(2) Sumatorio \n" +
                              "(3) Factorial \n" );
                int op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        salida = true;
                        break;
                    case 2:
                        int sum = 0;
                        Console.WriteLine("Introduce un numero");
                        n = Convert.ToInt16(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            sum = sum + i;
                        }
                        Console.WriteLine("La sumatoria es " + sum);
                        break;
                    case 3:
                        int fac = 1;
                        Console.WriteLine("Introduce un numero");
                        n = Convert.ToInt16(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            fac = fac * i;
                        }
                        Console.WriteLine("El factorial es: " + fac);
                        break;
                    default:
                        Console.WriteLine("No existe la opcion ingresada");
                        break;
                }
            } while (salida == false);
            return null;
        }

    }
}