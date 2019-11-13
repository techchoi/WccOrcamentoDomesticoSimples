using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class Renda
    {
        public Renda(decimal salario, decimal bonus, decimal decimoterceiro, decimal fgts, decimal ferias)
        {
            Salario = salario;
            Bonus = bonus;
            DecimoTerceiro = decimoterceiro;
            FGTS = fgts;
            Ferias = ferias;
        }
        public decimal Salario { get; set; }
        public decimal Bonus { get; set; }
        public decimal DecimoTerceiro { get; set; }
        public decimal FGTS { get; set; }
        public decimal Ferias  { get; set; }

    }
}
