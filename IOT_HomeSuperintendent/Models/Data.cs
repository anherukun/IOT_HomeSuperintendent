using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Models
{
    public class Data
    {
        [Key] public string IDData { get; set; }
        [Required] public string IDDevice { get; set; }
        [Required] public string value { get; set; }
        [Required] public string DataType { get; set; }
        public long TimeStamp { get; set; }
        public DateTime DateTime { get; set; }
    }
}
