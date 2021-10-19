using System.IO.Ports;
using SOLID.OCP;

namespace INET.Lab4.Devices
{
    public class BillAccepterCashCode : IDevice
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
            return port;
        }
    }
}