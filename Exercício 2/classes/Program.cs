using System;
using System.Globalization;
using System.Linq;

namespace exercise2
{
    class Employee
    {
        public string? name;
        public double salary;
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            Console.WriteLine("Digite o nome do funcionário: ");
            emp1.name = Console.ReadLine();

            if (string.IsNullOrEmpty(emp1.name) || !emp1.name.All(Char.IsLetter))
            {
                Console.WriteLine("Nome do funcionário Inválido: ");
                return;
            }

            Console.WriteLine("Digite o sálario do funcionário: ");
            if (!double.TryParse(Console.ReadLine(), out emp1.salary))
            {
                Console.WriteLine("Valor de Sálario Inválido: ");
                return;
            }

            Console.WriteLine("Digite o nome do funcionário: ");
            emp2.name = Console.ReadLine();

            if (string.IsNullOrEmpty(emp2.name) || !emp1.name.All(Char.IsLetter))
            {
                Console.WriteLine("Nome do funcionário Inválido: ");
                return;
            }

            Console.WriteLine("Digite o sálario do funcionário: ");

            if (!double.TryParse(Console.ReadLine(), out emp2.salary))
            {
                Console.WriteLine("Valor de Sálario Inválido:");
                return;
            }

            double media = (emp1.salary + emp2.salary) / 2.0;

            Console.WriteLine($"A média salarial dos funcionários é: {media.ToString("C", CultureInfo.CurrentCulture)}");
        }
    }
}
