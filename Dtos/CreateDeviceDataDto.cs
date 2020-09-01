using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Dtos
{
    public class CreateDeviceDataDto
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string Dmac { get; set; }
        public int Refpower { get; set; }
        public string Uuid { get; set; }
        public int MajorID { get; set; }
        public int Rssi { get; set; }
        public int MinorID { get; set; }
        public int Type { get; set; }
    }
}
