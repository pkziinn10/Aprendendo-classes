using System;
using System.Globalization;
using System.Linq;

namespace Exercise
{
    class Person
    {
        public string? name;
        public int age;
    }

    class Program
    {

        public static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("Digite o nome da primeira Pessoa: ");
            p1.name = Console.ReadLine();

            if (string.IsNullOrEmpty(p1.name) || !p1.name.All(Char.IsLetter))
            {
                Console.WriteLine("Nome Inválido");
                return;
            }

            Console.WriteLine("Digite a idade:");
            p1.age = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o nome da segunda pessoa:");
            p2.name = Console.ReadLine();

            if (string.IsNullOrEmpty(p2.name) || !p2.name.All(Char.IsLetter))
            {
                Console.WriteLine("Nome Inválido");
                return;
            }

            Console.WriteLine("Digite a idade: ");
            p2.age = int.Parse(Console.ReadLine() ?? "0");

            if (p1.age > p2.age)
            {
                Console.WriteLine($"{p1.name} É mais velho que {p2.name} ");
            }
            else
            {
                Console.WriteLine($"{p2.name} é mais velho que {p1.name} ");
            }
        }
    }
}
