using Interfaces2.Domain.Interfaces;

namespace Interfaces2.Domain.Models
{
   public class Steamship : Device, ISteamship 
    { 
        public Steamship(string name) : base(name)
    {
            name = "Default";
        }

    public override void Sound()
    {
        Console.WriteLine("Чух-чух");
    }

    public override void Desc()
    {
        Console.WriteLine("Пароплав \"Богемія\" високошвидкісний");
    }

        void ISteamship.Show<T>(T device)
        {
            throw new NotImplementedException();
        }

        string ISteamship.Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
