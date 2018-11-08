using System;
using MyFirstApplication.Entity.Exceptions;

namespace MyFirstApplication.Entity
{
    public class Student : Person
    {
        public int Id { get; set; }
        public decimal Money { get; set; }

        public Student(string firstName, string lastName, decimal money, int id) : base(firstName, lastName)
        {
            Money = money;
            Id = id;
        }

        public override void Drink()
        {
            if (Money <= 50)
            {
                throw new NotEnoughMoneyException($"Nie posiadam pieniedzy aby sie napic.");
            }

            Money = Money - 20;
            Console.WriteLine("Jestem bogaty, moge sie napic!");
        }

        public override string ToString()
        {
            return $"{Id} {base.FirstName} {base.LastName} {Money}";
        }
    }
}