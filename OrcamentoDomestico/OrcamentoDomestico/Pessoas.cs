using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class Pessoas
    {
        public Pessoas(string nome, string idade, string parentesco, string trabalho)
        {
            Nome = nome;
            Idade = idade;
            Parentesco = parentesco;
            Trabalho = trabalho;
        }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Parentesco { get; set; }
        public string Trabalho { get; set; }
        {

        }

    }
}
