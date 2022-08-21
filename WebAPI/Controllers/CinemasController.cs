using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly ICinemaService _cinemaService;
        public CinemasController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _cinemaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int cinemaId)
        {
            var result = _cinemaService.GetById(cinemaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Cinema cinema)
        {
            var result = _cinemaService.Add(cinema);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(Cinema cinema)
        {
            var result = _cinemaService.Update(cinema);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Cinema cinema)
        {
            var result = _cinemaService.Delete(cinema);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
