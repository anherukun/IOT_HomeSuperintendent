using IOT_HomeSuperintendent.Application;
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
    public class DataController : ControllerBase
    {
        // GET: api/<DataController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(RepoIOTDevice.Get());
        }

        // GET api/<DataController>/5
        [HttpGet("IDDevice/{q}")]
        public IActionResult Get(string q)
        {
            return Ok(RepoData.Get(x => x.IDDevice == q));
        }
        [HttpGet("{q}")]
        public IActionResult GetByID(string q)
        {
            return Ok(RepoData.Get(x => x.IDData == q));
        }

        // POST api/<DataController>
        [HttpPost("Add")]
        public IActionResult Post([FromBody] Data data)
        {
            DateTime dateTime = DateTime.Now;
            
            data.IDData = AppManager.GenerateGUID;
            data.DateTime = dateTime;
            data.TimeStamp = dateTime.Ticks;

            if (RepoData.Exist(x => x.IDData == data.IDData))
                return BadRequest(new { Response = "Duplicated object", Status = "Error" });
            try
            {
                RepoData.Add(data);

                return CreatedAtAction(nameof(GetByID), new { q = data.IDData }, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
