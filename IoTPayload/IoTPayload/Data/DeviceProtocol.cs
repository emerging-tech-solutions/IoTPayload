using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTPayload.Data
{
    public enum InterfaceType
    {
        Serial,
        MQTT,
        TCP,
        WebSocket,
        I2C,
        SPI
    }
    public class DeviceProtocol
    {
        public InterfaceType ComType { get; set; }
        public string Port { get; set; }
    }
}
