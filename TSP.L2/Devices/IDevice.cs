using System.IO.Ports;

namespace SOLID.OCP
{
    public interface IDevice
    {
        public SerialPort FindPort();
    }
}