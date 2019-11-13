using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class DespesasVariaveis
    {
        public DespesasVariaveis(decimal combustivel, decimal internet, decimal mercado, decimal agua, decimal luz, decimal gas, decimal refeicaofora, decimal compras, decimal telefone, decimal poupanca, decimal investimentos, decimal medicamentos, decimal doacao)
        {
            Combustivel = combustivel;
            Internet = internet;
            Mercado = mercado;
            Agua = agua;
            Luz = luz;
            Gas = gas;
            RefeicaoFora = refeicaofora;
            Compras = compras;
            Telefone = telefone;
            Poupanca = poupanca;
            Investimento = investimentos;
            Medicamentos = medicamentos;
            Doacao = doacao;

        }
        public decimal Combustivel { get; set; }
        public decimal Internet { get; set; }
        public decimal Mercado { get; set; }
        public decimal Agua { get; set; }
        public decimal Luz { get; set; }
        public decimal Gas { get; set; }
        public decimal RefeicaoFora { get; set; }
        public decimal Compras { get; set; }
        public decimal Telefone { get; set; }
        public decimal Poupanca { get; set; }
        public decimal Investimento { get; set; }
        public decimal Medicamentos { get; set; }
        public decimal Doacao { get; set; }

        
    }
}
