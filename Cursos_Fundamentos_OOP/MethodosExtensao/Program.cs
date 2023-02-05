using System;
using MethodosExtensao.Utils;


namespace MethodosExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "exemplo";

            //Método de extensão

            texto1 = texto1.CaixaAltaDaPrimeiraLetra();
            texto2 = texto2.CaixaAltaDaPrimeiraLetra();

            Console.WriteLine(texto1);
            Console.WriteLine(texto2);

            Console.ReadLine();
        }
    }
}
