using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class DespesasVariaveis
    {
        public decimal Combustivel { get; set; }
        public decimal Internet { get; set; }
        public decimal Mercado { get; set; }
        public decimal Agua { get; set; }
        public decimal Luz { get; set; }
        public decimal Gas { get; set; }
        public decimal RefeicoesFora { get; set; }
        public decimal Compras { get; set; }
        public decimal Telefone { get; set; }
        public decimal Poupanca { get; set; }
        public decimal Investimento { get; set; }
        public decimal Medicamentos { get; set; }
        public decimal Doacao { get; set; }

        Console.WriteLine(TotalDespesasVariaveis);
    }
}
