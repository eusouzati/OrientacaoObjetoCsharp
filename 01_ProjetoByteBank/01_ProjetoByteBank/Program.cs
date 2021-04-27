using System;

namespace _01_ProjetoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863232;
            contaDaGabriela.saldo = 100.20;

            Console.WriteLine("Dados bancários");
            Console.WriteLine("Nome do titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Conta Corrente: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo Anterior: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200.30;
            Console.WriteLine("Saldo Atual: " + contaDaGabriela.saldo);

            Console.ReadLine();


        }
    }
}
