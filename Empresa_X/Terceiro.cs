using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa_X
{
    class Salario
    {
        public double valorHora =20;
        public int cargaHoraria = 22;
        public double adicional = 10;

        public double clt()
        {
            return (valorHora * cargaHoraria);
        }
        public double terceiro()
        {
            return ((valorHora * cargaHoraria) +adicional);
        }
    }
}
