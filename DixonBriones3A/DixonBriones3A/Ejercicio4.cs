using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio4
    {
        public static Ejercicio4 Eje4(Ejercicio4 eje)
        {
            decimal sueldo;
            int op;
            Boolean opcion=false;
            do {
                Console.WriteLine("Introduzca la cantidad de horas trabajadas ");
                int horas = Convert.ToInt16(Console.ReadLine());
                if (horas <= 35)
                {
                    sueldo = horas * 15;
                }
                else
                {
                    int extras = horas - 35;
                    horas = horas - extras;
                    sueldo = (horas * 15) + (extras * 22);
                }
                Console.WriteLine("Sueldo total: " + sueldo);
                do
                {
                    Console.WriteLine("¿Desea calcular otro sueldo?\n" +
                                      "(1)SI \n" +
                                      "(2)NO\n");
                    op = Convert.ToInt16(Console.ReadLine());
                    if (op == 1)
                    {
                        opcion = false;
                    }
                    else if (op == 2)
                    {
                        opcion = true;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar (1) o (2)");
                    }
                } while (op != 1 && op != 2);
            } while (opcion==false);
            return null;
        }

    }
}