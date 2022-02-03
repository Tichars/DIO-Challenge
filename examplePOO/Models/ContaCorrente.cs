namespace examplePOO.Models
{
    public class ContaCorrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor;
        }
    }
}
