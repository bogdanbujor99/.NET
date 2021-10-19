using System;
using System.IO.Ports;

namespace SOLID.OCP.Violation
{
    public static class DeviceFinder
    {
        public static string Find(SerialPort port)
        {
            var names = SerialPort.GetPortNames();
            foreach(var name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0 )
                    return name;
            }
            return null;
        }
    }
}
