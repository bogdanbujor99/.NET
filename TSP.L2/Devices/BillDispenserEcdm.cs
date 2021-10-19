using System.IO.Ports;
using SOLID.OCP;

namespace INET.Lab4.Devices
{
    public class BillDispenserEcdm : IDevice
    {
        public SerialPort FindPort()
        {
            var port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
            return port;  
        }
    }
}