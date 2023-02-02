using System;

namespace Aula_Classes1.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public Pessoa(string nome, int idade, char sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public void Identificar()
        {
            Console.WriteLine($" Olá, meu nome é {Nome}, tenho {Idade} ano(s). Sou do Sexo {Sexo}");
        }
    }
}
