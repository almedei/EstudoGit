using System;

namespace Aval_Diag_Log_Progamacao
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] numeros = new int[3] { 1, 2, 3 };
            int b;
            int i;


            for (i = 0; i < numeros.Length; i++)
            {

                Console.WriteLine("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            {
                Console.WriteLine("Digite um número para buscar no verto: ");
                b = int.Parse(Console.ReadLine());
            }

            if (b == i)
            {

                Console.WriteLine("O número " + b + " foi encontrado com sucesso!");
            }
            else
            {
                Console.WriteLine("O número " + b + " não foi localizado");

            }

            if (b % 2 == 0)
            {
                Console.WriteLine("O número " + b + " é par");
            }
            else
            {
                Console.WriteLine("O número " + b + " é impar");
            }


        }
    }
}
