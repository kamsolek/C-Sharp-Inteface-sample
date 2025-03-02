using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    public class Rower : Pojazd
    {
        public Rower(string nazwa) : base(nazwa) { }

        public override void Przemieszczanie()
        {
            Console.WriteLine($"{Nazwa} porusza się pedałując.");
        }

    }
}
