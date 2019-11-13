using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class Pessoas
    {
        public Pessoas(String nome, string datadenascimento, string parentesco, string trabalho)
        {
            Nome = nome;
            DataDeNascimento = datadenascimento;
            Parentesco = parentesco;
            Trabalho = trabalho;
        }
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public string Parentesco { get; set; }
        public string Trabalho { get; set; }
        {

        }

    }
}
