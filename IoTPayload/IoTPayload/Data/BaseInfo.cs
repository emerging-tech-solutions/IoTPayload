using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public class BaseInfo
    {
        public Guid Id { get; set; }
        public string Version { get; set; }
        public string Serial { get; set; }
    }
}
