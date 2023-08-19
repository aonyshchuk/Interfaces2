using Interfaces2.Domain.Interfaces;
using Interfaces2.Domain.Models;

namespace Interfaces2.Domain.UseCases
{
    public class Trip : ITrip
    {
        public static void ShowTrip(object device)

        {
            Console.WriteLine(device.ToString());
        }

        void ITrip.ShowTrip(Device device)
        {
            Console.WriteLine(device.ToString());
        }

        string ITrip.Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
