using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication.Entity
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string brand)
        {
            Brand = brand;
        }

        private int _year;
        public string Brand { get; set; }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value <= 1750)
                {
                    throw new InvalidOperationException("Wtedy nie bylo samochodow!");
                }

                _year = value;
            }
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Year: {Year}";
        }
    }
}
