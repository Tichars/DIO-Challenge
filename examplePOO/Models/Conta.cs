using System;

namespace examplePOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: R$" + saldo);
        }
    }
}
