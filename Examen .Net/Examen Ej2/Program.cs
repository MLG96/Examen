using System;

namespace Examen_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumIngresado;

            Console.WriteLine("Ingrese la cantidad de tablas:");

            if (Int32.TryParse(Console.ReadLine(), out NumIngresado) != true)
            {
                Console.WriteLine("No es un tipo de dato valido.");
            }
            else
            {
                Tablas(NumIngresado);
            }
            Console.ReadKey();
        }

        public static void Tablas(int numIngresado)
        {
            for (int i = 0; i < numIngresado; i++)
            {

                int Resultado = 0;
                Console.WriteLine("Pulse una tecla:");
                Console.ReadKey();

                for (int j = 0; j < 10; j++)
                {
                    int Multiplicador = j + 1;
                    Resultado = (i + 1) * Multiplicador;
                    Console.WriteLine($"{i + 1}*{Multiplicador} = {Resultado}");
                }
            }
        }
    }
}
