using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeviceAPI.Data;
using DeviceAPI.Models;
using AutoMapper;
using DeviceAPI.Dtos;
using System.IO;
using Newtonsoft.Json;

namespace DeviceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceDataController : ControllerBase
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IMapper _mapper;

        public DeviceDataController(IDeviceRepository deviceRepository, IMapper mapper)
        {
            _deviceRepository = deviceRepository;
            _mapper = mapper;
        }

        // GET: api/DeviceData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceData>>> GetDeviceData()
        {
            var deviceData = await _deviceRepository.GetDeviceData();
            return Ok(deviceData);
        }

        // GET: api/DeviceDatas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeviceData>> GetDeviceData(long id)
        {
            var deviceData = new DeviceData(); //TODO

            if (deviceData == null)
            {
                return NotFound();
            }

            return deviceData;
        }

        // PUT: api/DeviceDatas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeviceData(long id, DeviceData deviceData)
        {
            if (id != deviceData.Id)
            {
                return BadRequest();
            }

            //TODO
            return NoContent();
        }

        [HttpPost("save")]
        public async Task<IActionResult> SaveDeviceData(CreateDeviceDataDto deviceData)
        {
            var newDeviceData = _mapper.Map<DeviceData>(deviceData);
            var savedDeviceData = await _deviceRepository.SaveData(newDeviceData);
            return Ok(new { savedDeviceData });
        }

        [HttpPost("saveFile")]
        public async Task<IActionResult> SaveDeviceFiledData(IFormFile jsonFile)
        {
            if (jsonFile != null)
            {
                string content = string.Empty;
                using (StreamReader reader = new StreamReader(jsonFile.OpenReadStream()))
                {
                    content = reader.ReadToEnd();
                }
                var deviceData = JsonConvert.DeserializeObject<DeviceData>(content);
                var savedDeviceData = await _deviceRepository.SaveData(deviceData);
                return Ok(new { savedDeviceData });
            }
            return BadRequest();
        }

        // DELETE: api/DeviceDatas/5
        [HttpDelete("{id}")]
        public Task<ActionResult<DeviceData>> DeleteDeviceData(long id)
        {
            return null; //TODO
        }

        private bool DeviceDataExists(long id)
        {
            return false; //TODO
        }
    }
}
