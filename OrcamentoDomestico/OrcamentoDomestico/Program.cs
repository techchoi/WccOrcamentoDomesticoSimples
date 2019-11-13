using System;

namespace OrcamentoDomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas pessoa1 = new pessoa("Nina", 25);
            Console.WriteLine("pessoa1 Nome = {0} Idade = {1} Parentesco = {Filha} Trabalho = {Administrativo}", pessoa1.Nome, pessoa1.Idade);
            Pessoas pessoa2 = pessoa1;
            pessoa2.Nome = "Maria";
            pessoa2.Idade = "50";
            pessoa2.Parentesco = "Mae";
            pessoa2.Trabalho = "Costureira";
            Pessoas pessoa3 = pessoa1;
            pessoa3.Nome = "Rodrigo";
            pessoa3.Idade = "25";
            pessoa3.Parentesco = "Agregado";
            pessoa3.Trabalho = "Engenheiro de software";



        }
    }
}
