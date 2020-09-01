using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Models
{
    [Table("AppDeviceData")]
    public class DeviceData 
    {
        [Key]
        public int Id { get; set; }
        public int Index { get; set; }
        public string Dmac { get; set; }
        public int Refpower { get; set; }
        public string Uuid { get; set; }
        public int MajorID { get; set; }
        public int Rssi { get; set; }
        public int MinorID { get; set; }
        public int Type { get; set; }
        public DateTime Time { get; set; }

        public DeviceData()
        {
            Time = DateTime.Now;
        }
    }
}
