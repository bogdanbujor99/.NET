using System.IO.Ports;
using SOLID.OCP;

namespace INET.Lab4.Devices
{
    public class CoinAccepterNri : IDevice
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
            return port;    
        }
    }
}