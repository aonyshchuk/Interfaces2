using Interfaces2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Domain.Interfaces
{
    public interface IBoilingWater 
    {
        void ShowBoiliningDevice(Device device);
        string Tostring();
    }
}
