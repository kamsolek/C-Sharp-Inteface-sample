using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    public class Motorowka: Pojazd
    {
        public Motorowka(string nazwa) : base(nazwa) { }

        public override void Przemieszczanie()
        {
            Console.WriteLine($"{Nazwa} porusza się po wodzie.");
        }
    }
}
