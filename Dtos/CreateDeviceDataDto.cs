using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Dtos
{
    public class CreateDeviceDataDto
    {
        public string DeviceName { get; set; }
        public string DeviceId { get; set; }
        public string Location { get; set; }
    }
}
