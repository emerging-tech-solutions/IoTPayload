using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class BaseDataSet:BaseInfo
    {
        public BaseDataSet()
        {
            Protocol = new DeviceProtocol();
        }
        public SensorType Sensor { get; set; }
        public DateTime SensorUTCTimeStamp { get; set; }
        public DeviceProtocol Protocol { get; set; }
    }
}
