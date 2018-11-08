using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstApplication.Entity;
using MyFirstApplication.Entity.Exceptions;

namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roznica pomiedzy typami referencyjnymi, a typami wartosciowymi:");
            Console.WriteLine();
            ValueTypesVsReferenceTypes();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Wykorzystanie listy oraz petli foreach:");
            Console.WriteLine();
            IEnumerableOperations();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Obsluga wyjatkow:");
            Console.WriteLine();
            ErrorHandling();

            Console.ReadKey();
        }

        static void IEnumerableOperations()
        {
            Console.WriteLine("Wszyscy studenci:");
            List<Student> students = new List<Student>
            {
                new Student("Jan", "Kowalski", 320.99m, 23000),
                new Student("Wojciech", "Szczesny", 200, 23001),
                new Student("Marcin", "Wozny", 450, 23002)
            };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Studenci posiadajacy wiecej niz 300 zlotych");

            var filteredStudents = students.Where(x => x.Money >= 300);
            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student);
            }
        }

        static void ErrorHandling()
        {
            Student student = new Student("Jan", "Malysz", 40, 230001);
            Console.WriteLine(student);
            try
            {
                student.Drink();
            }
            catch (NotEnoughMoneyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ValueTypesVsReferenceTypes()
        {

            int value = 15;
            Console.WriteLine($"Typ wartosciowy przed wykonaniem metody {nameof(ChangeValueType)}: {value}");
            ChangeValueType(value);
            Console.WriteLine($"Typ wartosciowy po wykonaniu metody {nameof(ChangeValueType)}: {value}");


            Car car = new Car { Brand = "BMW", Year = 2010 };
            Console.WriteLine($"Typ referencyjny przed wykonaniem metody {nameof(ChangeReferenceType)}: {car}");
            ChangeReferenceType(car);
            Console.WriteLine($"Typ referencyjny po wykonaniu metody {nameof(ChangeReferenceType)}: {car}");
        }

        static void ChangeValueType(int number)
        {
            number = 12;
        }

        static void ChangeReferenceType(Car car)
        {
            car.Brand = "Fiat";
            car.Year = 1990;
        }
    }
}
