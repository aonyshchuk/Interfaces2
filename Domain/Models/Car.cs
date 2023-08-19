

using Interfaces2.Domain.Interfaces;

namespace Interfaces2.Domain.Models
{
    public class Car : Device, ICar 
    {
        public Car(string name) : base(name)
        {
            name = "Default";
        }

        public override void Sound()
        {
            Console.WriteLine("Вжух-вжух");
        }

        public override void Desc()
        {
            Console.WriteLine("4 колеса, автомат");
        }
        public override string ToString()
        {
            return base.ToString();
        }

        void ICar.Show<T>(T device)
        {
            throw new NotImplementedException();
        }

        string ICar.Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
