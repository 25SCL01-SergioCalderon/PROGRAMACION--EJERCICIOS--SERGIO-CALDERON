using System;

namespace EjercicioDias
{
    class Program
    {
        static void Main(string[] args)
        {
            // Título
            Console.WriteLine("****************************");
            Console.WriteLine("     DIAS DE LA SEMANA      ");
            Console.WriteLine("****************************");

            // Declaración de variable
            int dia;

            // Entrada de datos
            Console.WriteLine("Ingrese un número del 1 al 7 para conocer el día correspondiente:");

            // Intentamos convertir la entrada a entero
            try
            {
                dia = Convert.ToInt32(Console.ReadLine());

                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Resultado: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Resultado: Martes");
                        break;
                    case 3:
                        Console.WriteLine("Resultado: Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Resultado: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Resultado: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Resultado: Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Resultado: Domingo");
                        break;
                    default:
                        Console.WriteLine("Error: Número inválido. Debe ser del 1 al 7.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese solo números enteros.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
