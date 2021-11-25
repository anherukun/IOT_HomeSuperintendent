using IOT_HomeSuperintendent.Models;
using IOT_HomeSuperintendent.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IOT_HomeSuperintendent.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class IOTDeviceController : ControllerBase
    {
        // GET: api/<IOTDeviceController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(RepoIOTDevice.Get());
        }

        // GET api/<IOTDeviceController>/{id}
        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            return Ok(RepoIOTDevice.GetSingle(x => x.IDDevice == id));
        }

        [HttpGet("MacAddress/{q}")]
        public IActionResult GetByMacAddress(string q)
        {
            return Ok(RepoIOTDevice.GetSingle(x => x.MacAddress == q));
        }

        [HttpGet("DeviceName/{q}")]
        public IActionResult GetByDeviceName(string q)
        {
            return Ok(RepoIOTDevice.Get(x => x.DeviceName == q));
        }

        [HttpGet("DataType/{q}")]
        public IActionResult GetByDataType(string q)
        {
            return Ok(RepoIOTDevice.Get(x => x.DataType == q));
        }

        [HttpGet("DeviceType/{q}")]
        public IActionResult GetByDeviceType(string q)
        {
            return Ok(RepoIOTDevice.Get(x => x.DeviceType == q));
        }

        // POST api/<IOTDeviceController>
        [HttpPost("Add")]
        public IActionResult Add([FromBody] IOTDevice device)
        {
            if (RepoIOTDevice.Exist(x => x.IDDevice == device.IDDevice || x.MacAddress == device.MacAddress))
                return BadRequest(new { Response = "Duplicated object", Status = "Error" });
            try
            {
                RepoIOTDevice.Add(device);
        
                return CreatedAtAction(nameof(GetByID), new { id = device.IDDevice }, device);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
            // PUT api/<IOTDeviceController>/5
            [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IOTDeviceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
