using System;

namespace _05_ProjetoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora Csharp";
            gabriela.cpf = "000.000.000-00";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;          
            conta.agencia = 563;
            conta.numero = 5674753;
            conta.saldo += 500;

            // As duas forma de acessar o nome do cliente o mesmo objeto. Exemplo: "Gabriela"
            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.saldo);


            // Segunda maneira de informar um objeto Cliente
            conta.titular = new Cliente();
            conta.titular.nome = "João";
            conta.titular.cpf = "654.787.098-56";
            conta.titular.profissao = "Desenvolvedor C#";
            conta.saldo += 1000;
            conta.agencia = 563;
            conta.numero = 53322332;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.saldo);

            Console.ReadLine();

        }
    }
}
