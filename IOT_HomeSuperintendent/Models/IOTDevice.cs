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
        [Required] public string MacAddress { get; set; }
        [Required] public string IPAddress { get; set; }
        [Required] public string DeviceType { get; set; }
        [Required] public string DeviceName { get; set; }
        [Required] public string DataType { get; set; }
        [Required] public string MeasurementUnit { get; set; }
        [Required] public string FirmwareVersion { get; set; }
        [Required] public string DeviceStatus { get; set; }
    }
}
