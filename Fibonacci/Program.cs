using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0, segundoNumero = 1, numeroUsuario,sumaDosNumerosI, count = 0;
           
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            numeroUsuario = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numeroUsuario; i++)
            {
                Console.WriteLine(primerNumero);
                sumaDosNumerosI = primerNumero+segundoNumero;
                primerNumero = segundoNumero;
                segundoNumero = sumaDosNumerosI;

             for (int j = 2; j < primerNumero; j++)
                {

                    if (primerNumero % i == 0)
                    {
                        count++;
                    }
                }
            }

            if (count == 1)
            {
                Console.WriteLine("el numero es primo");
            }
            else
            {
                Console.WriteLine("el numero no es primo");

            }
            Console.ReadKey();

            
        }
    }
}
