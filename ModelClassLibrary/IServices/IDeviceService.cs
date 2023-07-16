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
        List<Device> GetDevices(); 
        List<Operation> GetOperations();    

   
    }
}
