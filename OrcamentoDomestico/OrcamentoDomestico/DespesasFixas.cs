using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class DespesasFixas
    {
        public DespesasFixas(decimal financiamento, decimal aluguel, decimal planodesaude, decimal planoodontologico, decimal impostos, decimal inss, decimal seguro, decimal darf, decimal ir)
        {
            Financiamento = financiamento;
            Aluguel = aluguel;
            PlanoDeSaude = planodesaude;
            PlanoOdontologico = planoodontologico;
            Impostos = impostos;
            Seguro = seguro;
            INSS = inss;
            Darf = darf;
            IR = ir;
        }
        public decimal Financiamento { get; set; }
        public decimal Aluguel { get; set; }
        public decimal PlanoDeSaude { get; set; }
        public decimal PlanoOdontologico { get; set; }
        public decimal Impostos { get; set; }
        public decimal Seguro { get; set; }
        public decimal INSS { get; set; }
        public decimal Darf { get; set; }
        public decimal IR { get; set; }

       
    }
}
