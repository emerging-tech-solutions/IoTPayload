using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class DeviceData: BaseInfo
    {
        public DeviceData()
        {
            Payload = new List<dynamic>();
            TransmissionLog = new List<DataLog>();
        }
        public List<dynamic> Payload { get; set; } 
        public List<DataLog> TransmissionLog { get; set; }
    }
}
