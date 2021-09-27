using System;

namespace Aval_Diag_Log_Programacao_v5
{
    class Program
    {
        static void Main(string[] args)
        int tamanho = 2;
        double[] numeros = new double[tamanho];
        int i;
        double b;
            
            for (i = 0; i<tamanho; i++)
            {
                Console.WriteLine("Digite um número: " );
                numeros[i] = double.Parse(Console.ReadLine());
            }

    Console.WriteLine("Digite um número para buscar no verto: ");
                b = double.Parse(Console.ReadLine());

            for (i = 0; i<tamanho; i++)
            {
                if (b == i)
                {
                    Console.WriteLine("O número " + b + " foi encontrado com sucesso!");
                }
                else
{
    Console.WriteLine("O número " + b + " não foi localizado");
}
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
