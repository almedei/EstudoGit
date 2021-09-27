using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_X
{
    class ContaC
    {
        public string nome;
        public int conta { get; set; }
        public int agencia { get; set; }
        public double saldo { get; set; }


        public ContaC() { }

        public ContaC(string _nome, int _conta, int _agencia, double _saldo)
        {
            this.nome = _nome;
            this.conta = _conta;
            this.agencia = _agencia;
            this.saldo = _saldo;
        }
       
        public void Deposito(double valor)
        {
            this.saldo += valor;
        }

        public virtual void ImprimeDados()
        {
            Console.WriteLine(string.Concat("Nome do correntista: " + this.nome));
            Console.WriteLine(string.Concat("Número da agência: " + this.agencia));
            Console.WriteLine(string.Concat("Número da conta corrente: " + this.conta));
        }
        public virtual void ImprimeSaldo()
        { 
            Console.WriteLine(string.Concat("Saldo após depósito: " + this.saldo));
            
        }
    }


}


