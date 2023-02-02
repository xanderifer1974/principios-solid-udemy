using Aula_Classes1.Classes;
using System;

namespace Aula_Classes1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Alexandre",48,'M');
            Pessoa pessoa2 = new Pessoa("Luciana", 46, 'F');

            

            pessoa1.Identificar();
            pessoa2.Identificar();
        }
    }
}
