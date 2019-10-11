using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio3
    {
        public static Ejercicio3 Eje3(Ejercicio3 eje)
        {
            int cant;
            double pre = 0, sub, iva, tot = 0;
            do
            {
                do
                {
                    Console.WriteLine("Introduzca la cantidad de productos ");
                    cant = Convert.ToInt32(Console.ReadLine());
                    if (cant < 0)
                    {
                        Console.WriteLine("El numero debe ser un entero positivo ");
                    }
                } while (cant < 0);

                if (cant > 0)
                {
                    do
                    {
                        Console.WriteLine("Introduzca el precio");
                        pre = Convert.ToDouble(Console.ReadLine());
                        if (pre <= 0)
                        {
                            Console.WriteLine("El numero debe un decimal positivo ");
                        }
                    } while (pre <= 0);
                }
                sub = cant * pre;
                iva = sub * 0.12;
                tot = tot + sub + iva;
            } while (cant != 0);
            Console.WriteLine("El total a pagar es: " + tot +"\n");
            return null;
        }

    }
}