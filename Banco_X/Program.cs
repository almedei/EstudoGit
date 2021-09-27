using System;

namespace Banco_X
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ContaC Cconta;

            Cconta = new ContaC();

            Cconta.nome = "Eliane";
            Cconta.conta = 444444;
            Cconta.agencia = 2222;

            Cconta.ImprimeDados();

            Cconta.saldo = 100;
            Cconta.Deposito(10);

            Cconta.ImprimeSaldo();

          

            Console.WriteLine("_________________________________________________________________");

        ContaP pconta;

        pconta = new ContaP();
      

            pconta.nome = "Alexandre";
            pconta.conta = 123456;
            pconta.agencia = 1000;

            pconta.ImprimeDados();

            pconta.saldo = 200;
            pconta.SaqueTaxaCalculada(2.80);

            pconta.ImprimeSaldo();

            Console.ReadKey();
        }
    }
}
