using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int item = 0; item < lista.Count; item++)
            {
                System.Console.WriteLine($"Índice {item}, Valor: {lista[item]}");
            }
        }
    }
}