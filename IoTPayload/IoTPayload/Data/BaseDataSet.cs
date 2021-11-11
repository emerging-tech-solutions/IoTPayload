using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class BaseDataSet
    {
        public Guid SensorId { get; set; }
        public SensorType Sensor { get; set; }
        public string SensorVersion { get; set; }
        public string SensorSerial { get; set; }
        public DateTime SensorUTCTimeStamp { get; set; }
        public DeviceProtocol Protocol { get; set; }
    }
}
