using Interfaces2.Domain.Interfaces;

namespace Interfaces2.Domain.Models
{
    public class Device : IDevice
    {
        protected string Name { get; set; }

        public Device(string name)
        {
            Name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук пристрою");
        }

        public void Show()
        {
            Console.WriteLine($"Пристрій: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine("Опис");
        }

        public override string ToString()
        {
            return $"Пристрій: {Name}\n"; 
        }
        string IDevice.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string IDevice.ToString()
        {
            throw new NotImplementedException();
        }
    }

}
