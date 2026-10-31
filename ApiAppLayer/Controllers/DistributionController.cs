using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionController : ControllerBase
    {
        DistributionService service;
        public DistributionController(DistributionService service)
        {
            this.service = service;
        }
        //create:
        [HttpPost("create")]
        public IActionResult create(DistributionModel d)
        {
            var data = service.create(d);
            return Ok(data);
        }


        //get by id:
        [HttpPost("get/{id}")]
        public IActionResult getbyid(int id)
        {
            var data = service.getbyid(id);
            return Ok(data);
        }
        //getall:
        [HttpGet("get")]
        public IActionResult getall()
        {
            var data = service.getall();
            return Ok(data);
        }
        //update:
        [HttpPut("update")]
        public IActionResult update(DistributionModel f)
        {
            return Ok(service.update(f));
        }
        //delete:
        [HttpDelete("delete")]
        public IActionResult delete(DistributionModel f)
        {
            return Ok(service.delete(f));
        }

    }
}
