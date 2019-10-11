using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio8
    {
        public static Ejercicio8 Eje8(Ejercicio8 eje)
        {
            int n1 = 0, n2 = 0, n3 = 0;
            int num;
            do
            {
                Console.WriteLine("Introduzca un numero entero positivo");
                num = Convert.ToInt16(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("El numero debe ser un entero positivo ");
                }
            } while (num < 0);

            for (int i = 1; i <= num; i++)
            {
                n1 = n1 + 1;
                n2 = n2 + 2;
                n3 = n3 + 3;
                if(n1<=num){
                    Console.Write("*   "+n1+"   *"  );
                }
                if (n2 <= num)
                {
                    Console.Write("*   " + n2 + "   *");
                }
                if (n3 <= num)
                {
                    Console.Write("*   " + n3 + "   *");
                }
                Console.WriteLine("");
            }

            return null;
        }

    }
}