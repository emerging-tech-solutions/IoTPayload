using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class MicDataSet:BaseDataSet
    {
        public int Frequency { get; set; }
        public string Base64AudioString { get; set; }
    }
}
