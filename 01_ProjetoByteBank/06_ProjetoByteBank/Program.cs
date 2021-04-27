using System;

namespace _06_ProjetoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.CPF = "436.904.974-32";
            cliente.Profissao = "Desenvolvedor C#";

            conta.Saldo += 10;
            conta.Titular = cliente;



            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
