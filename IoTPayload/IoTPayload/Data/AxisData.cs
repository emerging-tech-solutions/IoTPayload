using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class AxisData
    {
        public AxisData()
        {
            XOffSet = new LowHighData();
            YOffSet = new LowHighData();
            ZOffSet = new LowHighData();
            X = new LowHighData();
            Y = new LowHighData();
            Z = new LowHighData();
        }
        public LowHighData XOffSet { get; set; }
        public LowHighData YOffSet { get; set; }
        public LowHighData ZOffSet { get; set; }
        public LowHighData X { get; set; }
        public LowHighData Y { get; set; }
        public LowHighData Z { get; set; }
    }
}
