namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
       public delegate void DelegateCalculadora();

        //Evento
       public static event DelegateCalculadora Eventocalculadora;

        public static void Somar(int x, int y)
        {
            if(Eventocalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                Eventocalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
            
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}