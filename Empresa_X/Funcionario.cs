using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa_X
{
    class Funcionario
    {
        public string nome { get; set; }
        public int cargaHoraria { get; set; }
        public float valorHora { get; set; }
    

    public Funcionario() { }

    public Funcionario(string _nome, int _cargaHoraria, int _valorHora)
    {
        this.nome = _nome;
        this.cargaHoraria = _cargaHoraria;
        this.valorHora = _valorHora;
    }

    public float calcSalario()
    {
        return (valorHora * cargaHoraria);
    }
      
    public virtual void ImprimeDados()
    {
        Console.WriteLine(string.Concat("Nome funcionario: " + this.nome));
        Console.WriteLine(string.Concat("Valor salário : " + this.calcSalario()));
        Console.ReadKey();
    }

    
    }   
}
