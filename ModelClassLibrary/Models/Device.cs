using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Models
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
    }
}
