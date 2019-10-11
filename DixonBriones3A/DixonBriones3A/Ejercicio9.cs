using System;
using System.Collections.Generic;
using System.Text;

namespace DixonBriones3A
{
    class Ejercicio9
    {
        public static Ejercicio9 Eje9(Ejercicio9 eje)
        {
            Console.WriteLine("Ingrese un numero para la tabla de multiplicar");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("TABLA DE MULTIPLICAR DEL " + numero);
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine(numero +" x "+i+" = "+(numero*i)  );

                }
          
            return null;
        }

    }
}