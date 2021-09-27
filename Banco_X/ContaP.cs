using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_X
{
    class ContaP : ContaC
    {

    
        public double taxaSaque { get; set; }
       

        public ContaP(string _nome, int _conta, int _agencia, double _saldo)
        {
            this.nome = _nome;
            this.conta = _conta;
            this.agencia = _agencia;
            this.saldo = _saldo;
            
        }

        public ContaP()
        {
        }

        public void SaqueTaxaCalculada(double valor)
        {
            this.saldo -= (valor + taxaSaque);
        }
        public override void ImprimeDados()
        {
            Console.WriteLine(string.Concat("Nome do correntista: ", this.nome));
            Console.WriteLine(string.Concat("Número da agência: " + this.agencia));
            Console.WriteLine(string.Concat("Número da conta corrente: " + this.conta));

        }

        public override void ImprimeSaldo()
        {
         
        Console.WriteLine(string.Concat("Saldo após saque : ", this.saldo));
 
        }
    
    }
    
}

    

