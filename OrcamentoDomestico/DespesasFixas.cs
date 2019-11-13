using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class DespesasFixas
    {
        public decimal Financiamento { get; set; }
        public decimal Aluguel { get; set; }
        public decimal PlanoDeSaude { get; set; }
        public decimal PlanoOdontologico { get; set; }
        public decimal Impostos { get; set; }
        public decimal Seguro { get; set; }
        public decimal INSS { get; set; }
        public decimal Darf { get; set; }
        public decimal IR { get; set; }

        public decimal TotalDespezasFixas { get; set; }

        Console.WriteLine(TotalDespezas);
    }
}
