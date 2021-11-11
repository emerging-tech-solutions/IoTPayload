using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class GyroDataSet:BaseDataSet
    {
        public GyroDataSet()
        {
            Acceleration = new AxisData();
            AngularVelocity = new AxisData();
            Magnetic = new AxisData();
            X = new LowHighData();
            Y = new LowHighData();
            Z = new LowHighData();
            Temp = new LowHighData();
        }
        public AxisData Acceleration { get; set; }
        public AxisData AngularVelocity { get; set; }
        public AxisData Magnetic { get; set; }
        public LowHighData X { get; set; }
        public LowHighData Y { get; set; }
        public LowHighData Z { get; set; }
        public LowHighData Temp { get; set; }
    }
}
