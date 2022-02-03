using examplePOO.Interfaces;
using examplePOO.Models;
using System;

namespace examplePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            Console.WriteLine(calc.Dividir(28, 2));
            Console.WriteLine(calc.Multiplicar(23, 4));
            Console.WriteLine(calc.Dividir(124, 12));



            //Computador comp = new Computador();
            //Console.WriteLine(comp.ToString()); 


            //ContaCorrente c = new ContaCorrente();
            //c.Creditar(250);
            //c.ExibirSaldo();


            //Calculadora calc = new Calculadora();
            //Console.WriteLine("Resultado 1: " + calc.Somar(25, 597));
            //Console.WriteLine("Resultado2: " + calc.Somar(526, 342, 1267));


            //Aluno a1 = new Aluno();
            //a1.Nome = "Thiago";
            //a1.Nota = 10;
            //a1.Apresentar();
            //Professor t1 = new Professor();
            //t1.Nome = "Carlos";
            //t1.Salario = 3200;
            //t1.Apresentar();


            //Retangulo r = new Retangulo();
            //r.DefinirMedidas(40, 30);
            //Console.WriteLine($"Área: {r.ObterArea()}");
            //Console.WriteLine(" ");
            //Retangulo r1 = new Retangulo();
            //r1.DefinirMedidas(-40, 0);
            //Console.WriteLine($"Área: {r1.ObterArea()}");


            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Ticha";
            //p1.Idade = 42;
            //p1.Apresentar();

        }
    }
}
