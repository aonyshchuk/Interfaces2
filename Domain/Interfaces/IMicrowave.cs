using Device = Interfaces2.Domain.Models.Device;

namespace Interfaces2.Domain.Interfaces
{
    public interface IMicrowave
    {
        public void Show<T>(T device);

        string Tostring(); 
    }
}
