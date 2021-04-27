using System;

namespace _04_ProjetoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Meu saldo é: R$ " + contaDoBruno.saldo + ",00");
            contaDoBruno.Sacar(49.00);
            Console.WriteLine("Gostaria de sacar: R$ 49,00");
            Console.WriteLine("Meu Saldo atual é: R$ " + contaDoBruno.saldo + ",00");

            contaDoBruno.Depositar(500);
            Console.WriteLine("Meu Saldo atual é: R$ " + contaDoBruno.saldo + ",00");

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaDaGabriela.saldo);

            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: R$ " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaDaGabriela.saldo);


            Console.ReadLine();

        }
    }
}
