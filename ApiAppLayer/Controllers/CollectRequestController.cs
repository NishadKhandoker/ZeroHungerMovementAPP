using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollectRequestController : ControllerBase
    {
        CollectRequestService service;
        public CollectRequestController(CollectRequestService service)
        {
            this.service = service;
        }

        //create:
        [HttpPost("create")]
        public IActionResult create(CollectRequestModel r)
        {
            return Ok(service.create(r));
        }
        //assignemployee:
        [HttpPut("assignemployee")]
        public IActionResult assignEmployee(int requestId, int employeeId)
        {
            var result = service.assignEmployee(requestId, employeeId);

            if (result)
            {
                return Ok(new
                {
                    message = "Employee assigned successfully"
                });
            }

            return BadRequest(new
            {
                message = "Employee assignment failed"
            });
        }


        //get by id:
        [HttpGet("get/{id}")]
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
        public IActionResult update(CollectRequestModel f)
        {
            return Ok(service.update(f));
        }
        //delete:
        [HttpDelete("delete")]
        public IActionResult delete(CollectRequestModel f)
        {
            return Ok(service.delete(f));
        }
    }
}
