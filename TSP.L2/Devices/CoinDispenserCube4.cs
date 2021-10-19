using System.IO.Ports;

namespace SOLID.OCP.Devices
{
    public class CoinDispenserCube4 : IDevice
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
            return port;     
        }
    }
}