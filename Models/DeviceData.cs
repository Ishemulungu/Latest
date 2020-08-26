using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Models
{
    public class DeviceData 
    {
        public long Id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceId { get; set; }
        public DateTime CurrentTime { get; set; }
        public string Location { get; set; }

        public DeviceData()
        {
            CurrentTime = DateTime.Now;
        }
    }
}
