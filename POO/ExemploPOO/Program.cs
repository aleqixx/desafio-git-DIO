using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Dividir(10,5));

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(200);

            // c.ExibirSaldo();


            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10,10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10,10,10));
            
            // Aluno p1 = new Aluno();
            // p1.Nome = "Marcos";
            // p1.Idade = 20;
            // p1.Nota = 10;            
            // p1.Documento = "125689876";
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Gregory";
            // p2.Idade = 60;
            // p2.salario = 10000;            
            // p2.Documento = "555555555";
            // p2.Apresentar();

            // p1.Nome = "Palha Palha";
            // p1.Idade = 31;

            // p1.Apresentar();


            // //Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");

            // //Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Palha Palha";
            // p1.Idade = 31;

            // p1.Apresentar();
        }
    }
}
