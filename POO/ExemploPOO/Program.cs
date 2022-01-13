using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\OneDrive - Personal\\OneDrive\\T. I\\Developer\\Bootcamp .NET Localiza\\Git\\desafio-git-DIO\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");            
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta teste 2", "arquivo-teste-stream.txt");

            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);

            // System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);

            // helper.CriarArquivoTexto(caminhoArquivo, "Hello world!" + "\n" +  "Teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            // helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(10,5));

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
