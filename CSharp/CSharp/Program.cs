namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa4 = (Pessoas)0;

            Pessoa person = new Pessoa();

            person.Nome = "Alex";
            person.Idade = 27;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Lorena";
            person2.Idade = 31;
            person2.Estado = "SP";

            Animal animal = new Animal();

            animal.Nome = "Scooby";
            animal.NomeDono = "Cris";
            animal.Especie = "Cachorro";

        }
    }
}
