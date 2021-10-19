using System.Collections.Generic;
using INET.Lab4.Devices;
using SOLID.OCP.Devices;
using SOLID.OCP.Violation;

namespace SOLID.OCP
{
    public class DeviceFactory
    {
        private Dictionary<DeviceModel, IDevice> _devices = new();

        public DeviceFactory()
        {
            _devices.Add(DeviceModel.BillAccepterCashCode, new BillAccepterCashCode());
            _devices.Add(DeviceModel.BillDispenserEcdm, new BillDispenserEcdm());
            _devices.Add(DeviceModel.CoinAccepterNri, new CoinAccepterNri());
            _devices.Add(DeviceModel.CoinDispenserCube4, new CoinDispenserCube4());
            _devices.Add(DeviceModel.CoinDispsenerSch2, new CoinDispenserSch2());
        }

        public IDevice GetDevice(DeviceModel device)
        {
           return _devices[device];
        }
    }
}