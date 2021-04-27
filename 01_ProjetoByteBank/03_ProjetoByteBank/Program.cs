using System;

namespace _03_ProjetoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();            
            contaDaGabriela.titular = "Gabriela Silva";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela Costa";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            //Igualdade de tipo de referência
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);

            //Igualdade de tipo de valor
            Console.WriteLine(contaDaGabrielaCosta.numero == contaDaGabriela.numero);

            Console.ReadLine();
        }
    }
}
