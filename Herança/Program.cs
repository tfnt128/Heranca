using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica conta = new ContaJuridica(8010, "LaraCroft", 100.0, 500.0);

            Console.WriteLine(conta.Saldo);

        }
    }
}
