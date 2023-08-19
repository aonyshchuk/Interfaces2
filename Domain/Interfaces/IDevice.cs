using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2.Domain.Interfaces
{
    public interface IDevice
    {
       string Name { get; set; }
        
        string ToString();
    }
}
