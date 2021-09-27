using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aval_Diag_Log_Progamacao_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 10;
            int[] numeros = new int[tamanho];
            int busca;

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Mostra valor digitado");

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Valor: " + numeros[i] + " ,posição: " + i);
            }

            Console.WriteLine("Digite um número para buscar no verto: ");
            busca = int.Parse(Console.ReadLine());


            if (Array.Exists(numeros, x => x == Convert.ToInt32(busca)))
            {
                Console.WriteLine("O número " + busca + " foi encontrado com sucesso!");

                if (busca % 2 == 0)
                    Console.WriteLine("O número " + busca + " é par");

                else

                    Console.WriteLine("O número " + busca + " é impar");

            }

            else

            {
                Console.WriteLine("O número " + busca + " não foi localizado");
            }


            Console.ReadKey();
        }
    }
}

