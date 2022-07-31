using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : Controller
    {
        private readonly IProducerService _producerService;
        public ProducersController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _producerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid/{producerId}")]
        public IActionResult GetById(int producerId)
        {
            var result = _producerService.GetById(producerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Producer producer)
        {
            var result = _producerService.Add(producer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(Producer producer)
        {
            var result = _producerService.Update(producer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Producer producer)
        {
            var result = _producerService.Delete(producer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
