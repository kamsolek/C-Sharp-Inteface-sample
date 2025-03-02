using zad7;

namespace zad7
{
    public class MessageService
    {
        public void OnAccident(string nazwa)
        {
            Console.WriteLine($"MessageService: pojazd {nazwa} miał wypadek.."); 
        }
    }
}
