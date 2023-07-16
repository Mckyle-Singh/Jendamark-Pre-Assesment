using ModelClassLibrary.IServices;
using ModelClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Services
{
    public class DeviceService : IDeviceService
    {
        private static List<Device> _devices = new List<Device>()
        {
            new Device
            {
                DeviceId = Guid.NewGuid(),
                Name="First Barcode Scanner",
                DeviceType=DeviceType.BarcodeScanner

            },
        };

        private List<Operation> _operations = new List<Operation>()
        {
            new Operation
            {
                OperationId=Guid.NewGuid(),
                Name = "First Opp",
                OrderInWhichToPerform = 1,
                Device=_devices[0]


            },
        };

        public List<Device> GetDevices()
        {
            return _devices;
        }

        public List<Operation> GetOperations()
        {
            return _operations;
        }
    }
}
