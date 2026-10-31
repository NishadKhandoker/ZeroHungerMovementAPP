using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAppLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        RestaurantService service;
        public RestaurantController(RestaurantService service)
        {
            this.service = service;
        }

        //create:
        [HttpPost("create")]
        public IActionResult create(RestaurantModel r) 
        {
            return Ok(service.create(r));
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
        public IActionResult update(RestaurantModel f)
        {
            return Ok(service.update(f));
        }
        //delete:
        [HttpDelete("delete")]
        public IActionResult delete(RestaurantModel f)
        {
            return Ok(service.delete(f));
        }
    }
}
