using System;

namespace DixonBriones3A
{
    class Menu
    {
        static void Main(string[] args)
        {
            Boolean salida = false;
            do{
                Console.WriteLine("Seleeccione un ejercicio \n" +
                              "(1) Ejercicio 1 \n" +
                              "(2) Ejercicio 2 \n"+
                              "(3) Ejercicio 3 \n"+
                              "(4) Ejercicio 4 \n"+
                              "(5) Ejercicio 5 \n"+
                              "(6) Ejercicio 6 \n"+
                              "(7) Ejercicio 7 \n"+
                              "(8) Ejercicio 8 \n"+
                              "(9) Ejercicio 9 \n"+
                              "(10) Ejercicio 10 \n"+
                              "(11) Salir \n");
            int ejer = Convert.ToInt16(Console.ReadLine());      
                    switch (ejer) {
                        case 1:
                            Ejercicio1 eje = Ejercicio1.Eje1(null);
                            break;
                        case 2:
                            Ejercicio2 eje2 = Ejercicio2.Eje2(null);
                            break;
                        case 3:
                            Ejercicio3 eje3 = Ejercicio3.Eje3(null);
                            break;
                        case 4:
                            Ejercicio4 ej4 = Ejercicio4.Eje4(null);
                            break;
                        case 5:
                            Ejercicio5 eje5 = Ejercicio5.Eje5(null);
                            break;
                        case 6:
                            Ejercicio6 eje6 = Ejercicio6.Eje6(null);
                            break;
                        case 7:
                            Ejercicio7 eje7 = Ejercicio7.Eje7(null);
                            break;
                        case 8:
                            Ejercicio8 eje8 = Ejercicio8.Eje8(null);
                            break;
                        case 9:
                            Ejercicio9 eje9 = Ejercicio9.Eje9(null);
                            break;
                        case 10:
                            Ejercicio10 eje10 = Ejercicio10.Eje10(null);
                            break;
                        case 11:
                            salida = true;
                            break;
                        default:
                            Console.WriteLine("No existe ejercicio con numero ingresado");
                            break;
                    }
                }while(salida == false);

        }
    }
}
