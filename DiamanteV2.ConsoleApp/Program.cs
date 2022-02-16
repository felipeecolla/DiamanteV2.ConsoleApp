using System;

namespace DiamanteV2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alfabetosArray = alfabeto.ToCharArray();
            Console.WriteLine("Insira uma letra: ");
            string letra = Console.ReadLine();
            int linhas = alfabeto.IndexOf(letra);
            int espacos = linhas;
            int espacosMeio = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = espacos; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetosArray[i]);

                for (int j = 0; j < espacosMeio; j++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {
                    Console.Write(alfabetosArray[i]);
                }

                Console.WriteLine();

                espacos--;
                    espacosMeio += 2;


            }
            for (int i = linhas; i >= 0; i--)
            {
                for (int j = espacos; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetosArray[i]);

                for (int j = 0; j < espacosMeio; j++)
                {
                    Console.Write(" ");
                }
                if (i > 0)
                {
                    Console.Write(alfabetosArray[i]);
                }

                Console.WriteLine();

                espacos++;
                espacosMeio -= 2;


            }



        }
    }
}
