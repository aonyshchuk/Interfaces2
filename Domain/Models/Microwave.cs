using Interfaces2.Domain.Interfaces;

namespace Interfaces2.Domain.Models
{
    public class Microwave : Device, IMicrowave
    {
       
            public Microwave(string name) : base(name)
            {
                name = "Default"; 
            }

            public override void Sound()
            {
                Console.WriteLine("Бриньк-бриньк");
            }

            public override void Desc()
            {
                Console.WriteLine("Швидке приготування або швидкий підігрів харчових продуктів");
            }
            public override string ToString()
            {
                return base.ToString();
            }

        void IMicrowave.Show<T>(T device)
        {
            throw new NotImplementedException();
        }

        string IMicrowave.Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
