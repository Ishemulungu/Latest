using DeviceAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceAPI.Data
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly DataContext _context;

        public DeviceRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<DeviceData> SaveData(DeviceData deviceData)
        {
            await _context.DeviceData.AddAsync(deviceData);
            await _context.SaveChangesAsync();

            return deviceData;
        }
        public async Task<IEnumerable<DeviceData>> GetDeviceData()
        {
            return await _context.DeviceData.ToListAsync();
        }

    }
}
