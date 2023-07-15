using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLibrary.Models
{
    public class Operation
    {
        public Guid OperationId { get; set; }
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }

        public Device Device { get; set; }
    }
}
