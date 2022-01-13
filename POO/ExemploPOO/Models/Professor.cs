using System;
namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }
        
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos e meu RG é {Documento}");
        }
    }

    
}