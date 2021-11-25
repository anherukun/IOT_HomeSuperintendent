using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Models
{
    public class IOTDevice
    {
        [Key] public string IDDevice { get; set; }
        public string MacAddress { get; set; }
        public string IPAddress { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public string DataType { get; set; }
        public string MeasurementUnit { get; set; }
        public string FirmwareVersion { get; set; }
        public string DeviceStatus { get; set; }
    }
}
