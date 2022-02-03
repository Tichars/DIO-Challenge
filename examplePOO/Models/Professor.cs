using System;


namespace examplePOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é  {Nome} e ganho {Salario} reais por mês");
        }
    }
}