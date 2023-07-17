using ModelClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.IServices
{
    public interface IDeviceService
    {
        //Device Methods
        List<Device> GetDevices();
        Device GetSpecificDevice(Guid id);

        void UpdateDevice(Device device);

        void AddNewDevice(Device device);

        void DeleteDevice(Guid id);


        //Operation Methods
        List<Operation> GetOperations();   
        Operation GetSpecificOperation(Guid id);

        void DeleteOperation(Guid id);

        void UpdateOperation(Operation operation);
    }
}
