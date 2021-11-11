using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class DataLog
    {
        public Guid TransmittedBy { get; set; }
        public DateTime Transmit { get; set; }
        public Guid ReceivedBy { get; set; }
        public DateTime Receive { get; set; }
    }
}
