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
            Angle = new AxisData();
        }
        public AxisData Acceleration { get; set; }
        public AxisData AngularVelocity { get; set; }
        public AxisData Magnetic { get; set; }
        public AxisData Angle { get; set; }
        public double Temp { get; set; }
    }
}
