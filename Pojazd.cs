using zad7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    public abstract class Pojazd:IServisowalny
    {
        // Delegat do obsługi zdarzeń
        public delegate void WypadekEventHandler(string pojazdNazwa);
        public string Nazwa { get; set; }
        public Pojazd(string nazwa)
        {
            Nazwa = nazwa;
        }

        // Implementacja metody z interfejsu
        public void Serwis()
        {
            Console.WriteLine($"{Nazwa} jest serwisowany.");
        }

        public abstract void Przemieszczanie();

        // Zdarzenie informujące o wypadku
        public event WypadekEventHandler Wypadek;

        // Metoda do wywołania zdarzenia
        protected virtual void PowiadomOwypadku()
        {
            Wypadek?.Invoke(Nazwa); // Wywołanie zdarzenia
        }

        // Symulacja wypadku
        public void SymulujWypadek()
        {
            //Console.WriteLine($"{Nazwa} miał wypadek!");
            PowiadomOwypadku();
        }
    }
}
