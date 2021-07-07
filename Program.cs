using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            try
            {
                Console.WriteLine("-- Exercício Tabuada --");
                Console.Write("Recepção de uma valor e exibição da tabuada desse ");
                Console.WriteLine("valor até o limite de 10 números com laços de repetição.");
                Console.WriteLine();

                Console.Write("Insira o valor a ser calculado: ");
                int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int cont = 1; cont < 11; cont++)
                {
                    int resultado = numeroTabuada * cont;

                    Console.WriteLine($"--> {numeroTabuada}x{cont} = {resultado}");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Atenção!! O valor de entrada não está no formato correto.");
                Console.ResetColor();
            }

            catch (OverflowException)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Atenção!! O valor de entrada excede o limite.");
                Console.ResetColor();
            }
        }
    }
}
