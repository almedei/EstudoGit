using System;

namespace Empresa_X
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int cargaHoraria;
            double valorHora;
            string empresaOrigem;

            Console.WriteLine("O funcionário é terceirizado? ");
            Console.WriteLine("Digite S ou N: ");
            string condFunc = Console.ReadLine();

            if (condFunc == "S")
            {

                Console.WriteLine("Condição é terceiro: " + condFunc);

                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite carga horária: ");
                cargaHoraria = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da hora: ");
                valorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite nome da empresa: ");
                empresaOrigem = Console.ReadLine();

                Funcionario fucionario = new FuncTerceiro(nome, Convert.ToInt32(cargaHoraria), Convert.ToInt32(valorHora), empresaOrigem);
                fucionario.ImprimeDados();

                Console.ReadKey();
                
            }
            else
            {
                Console.WriteLine("Condição é funcionário: " + condFunc);

                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite carga horária: ");
                cargaHoraria = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da hora: ");
                valorHora = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite nome da empresa: ");
                empresaOrigem = Console.ReadLine();

                Funcionario fucionario = new Funcionario(nome, Convert.ToInt32(cargaHoraria), Convert.ToInt32(valorHora));
                fucionario.ImprimeDados();

                Console.ReadKey();
            }

        }
    }
}
