using System;
using System.Collections.Generic;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rower rower = new Rower("Rower Górski");
                Motorowka motorowka = new Motorowka("Motorówka");
                var MessageService = new MessageService();  //z zad 7


                // Subskrybowanie zdarzenia (przypisanie metody do eventu)
                //rower.Wypadek += WypadekHandler;
                //motorowka.Wypadek += WypadekHandler;

                //rower.Wypadek += MessageService.OnAccident;


                // Symulacja przemieszczania
                rower.Przemieszczanie();
                motorowka.Przemieszczanie();
                Console.WriteLine("\n");

                // Symulacja wypadków(pozniej wywołanie zdarzenia)
                //rower.SymulujWypadek();
                //motorowka.SymulujWypadek();

                rower.Serwis();
                WygenerujWyjatek(rower);

                motorowka.Serwis();

            }
            catch (PojazdException e)
            {
                Console.WriteLine($"Błąd:{e.Message}");
            }

            // Metoda obsługująca zdarzenie ( zad7)
            static void WypadekHandler(string pojazdNazwa)
            {
                Console.WriteLine($"Powiadomienie: {pojazdNazwa} miał wypadek!");
            }
        }

        // Metoda generująca wyjątek
        static void WygenerujWyjatek(Pojazd pojazd)
        {
            if (pojazd.Nazwa == "Rower Górski")
            {
                throw new PojazdException("Wystąpił błąd z rowerem górskim!");
            }
        }

    }
}
    

