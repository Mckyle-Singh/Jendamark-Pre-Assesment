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
        private List<Device> _devices = new List<Device>()
        {
            new Device
            {
                DeviceId = Guid.NewGuid(),
                Name="First Barcode Scanner",
                DeviceType=DeviceType.BarcodeScanner

            },

        };
        public List<Device> GetDevices()
        {
            throw new NotImplementedException();
        }
    }
}
