using System;

namespace ModeloDominio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClienteRico cliente = new ClienteRico(10,"",null);

            Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Endereco}");

            Console.ReadLine();
        }

        private static void ClienteAnemicoTeste()
        {
            ClienteAnemico cliente = new ClienteAnemico();
            cliente.Id = -1;
            cliente.Nome = "";
            cliente.Endereco = null;

            
        }
    }
}
