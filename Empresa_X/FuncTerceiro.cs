using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa_X
{
    class FuncTerceiro : Funcionario
    {
        public string empresaOrigem { get; set; }
        const double taxaServico = 20;
        public double SalarioCalc { get; set; }
        private double salarioCalcTaxa;
        public double SalarioCalcTaxa
        {
            get
            {
                SalarioCalc = calcSalario();
                return (((taxaServico / 100) * SalarioCalc) + SalarioCalc);
            }
            private set
            {
                salarioCalcTaxa = value;
            }
        }
        public FuncTerceiro()
            :base() {}
            public FuncTerceiro(string _nome, int _cargaHoraria, int _valorHora, string _empresaOrigem)
            :base(_nome, _cargaHoraria, _valorHora)
        
            {
                this.empresaOrigem = _empresaOrigem;
            }

        public FuncTerceiro(string _nome, int _cargaHoraria, double valorHora, int _valorHora) : base(_nome, _cargaHoraria, _valorHora)
        {
        }

        public override void ImprimeDados()
            {
            Console.WriteLine(string.Concat("Nome funcionario: ", this.nome));
            Console.WriteLine(string.Concat("Valor salario : ", this.SalarioCalcTaxa));
            Console.WriteLine(string.Concat("Nome empresa: ", this.empresaOrigem));
         }
    }
}
