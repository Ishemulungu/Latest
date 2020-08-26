
using DeviceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Data
{
    public interface IDeviceRepository
    {
        Task<DeviceData> SaveData(DeviceData deviceData);
        Task<IEnumerable<DeviceData>> GetDeviceData();
    }
}
