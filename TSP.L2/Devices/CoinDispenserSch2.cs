using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    public class CoinDispenserSch2 : IDevice
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            return port;
        }
    }
}