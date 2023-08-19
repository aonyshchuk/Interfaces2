using Interfaces2.Domain.Interfaces;
using Interfaces2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Domain.NewFolder
{
    public class BoilingWater : IBoilingWater
    {


        public static void ShowBoiliningDevice(Device device)

        {
            Console.WriteLine(device.ToString());
        }

        void IBoilingWater.ShowBoiliningDevice(Device device)
        {
            throw new NotImplementedException();
        }

        string IBoilingWater.Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
