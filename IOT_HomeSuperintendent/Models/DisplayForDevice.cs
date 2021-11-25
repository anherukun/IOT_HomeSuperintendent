using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Models
{
    public class DisplayForDevice
    {
        public string IDDisplay { get; set; }
        public string IDDevice { get; set; }
    }

    public class DisplaySettingsForDevice
    {
        [Key] public string IDDisplay { get; set; }
        [Required] public string IDDevice { get; set; }
        [Required] public int Width { get; set; }

    }
}
