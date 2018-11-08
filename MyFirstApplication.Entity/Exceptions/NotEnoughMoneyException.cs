using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication.Entity.Exceptions
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException(string msg = "Wyjatek!") : base(msg) { }
        public NotEnoughMoneyException() : base("Komenatrz do wyjatku") { }
        
    }
}
