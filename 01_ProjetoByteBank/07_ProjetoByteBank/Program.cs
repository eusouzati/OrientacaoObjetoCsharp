using System;

namespace _07_ProjetoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(863, 8463563);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            

            ContaCorrente contaDaGaby = new ContaCorrente(863, 88376374);
            Console.WriteLine(contaDaGaby.Agencia);
            Console.WriteLine(contaDaGaby.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            

            

            Console.ReadLine();
        }
    }
}
