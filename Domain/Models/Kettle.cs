using Interfaces2.Domain.Interfaces;

namespace Interfaces2.Domain.Models
{
    public class Kettle : Device, IKettle
    {
        string IKettle.Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Kettle(string name) : base(name)
        {
            name = "Default"; 
        }

        public override void Sound()
        {
            Console.WriteLine("Свист");
        }

        public override void Desc()
        {
            Console.WriteLine("Швидке кип'ятіння за 2 хв");
        }
    }

    
    
}
