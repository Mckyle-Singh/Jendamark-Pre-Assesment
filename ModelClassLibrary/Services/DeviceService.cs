using ModelClassLibrary.IServices;
using ModelClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        //Implementing device methods from interface

        public List<Device> GetDevices()
        {
            return _devices;
        }

        public Device GetSpecificDevice(Guid id)
        {
            return _devices.SingleOrDefault(x => x.DeviceId == id);
        }

         public void UpdateDevice(Device device)
        {
            var GetOldDevice = GetSpecificDevice(device.DeviceId);
            GetOldDevice.Name= device.Name;
            GetOldDevice.DeviceType= device.DeviceType;
        }
        public void AddNewDevice(Device device)
        {
           var id= Guid.NewGuid();
           device.DeviceId= id;
           _devices.Add(device);
        }

        public void DeleteDevice(Guid id)
        {
            var device = GetSpecificDevice(id);
            _devices.Remove(device);    
        }


        //Implementing operation methods from interface
        public List<Operation> GetOperations()
        {
            return _operations;
        }

        public Operation GetSpecificOperation(Guid id)
        {
            return _operations.SingleOrDefault(x => x.OperationId == id);
        }

        public void DeleteOperation(Guid id)
        {
            var device = GetSpecificOperation(id);
            _operations.Remove(device);
        }

        public void UpdateOperation(Operation operation)
        {
            var GetOldOppeartion = GetSpecificOperation(operation.OperationId);
            GetOldOppeartion.Name = operation.Name;
            GetOldOppeartion.OrderInWhichToPerform = operation.OrderInWhichToPerform;
            //GetOldDevice.DeviceType = device.DeviceType;
        }
    }
}
