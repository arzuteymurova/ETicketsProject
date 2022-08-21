using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService _actorService;
        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _actorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int actorId)
        {
            var result = _actorService.GetById(actorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Actor actor)
        {
            var result = _actorService.Add(actor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       
        [HttpPut("update")]
        public IActionResult Update(Actor actor)
        {
            var result = _actorService.Update(actor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Actor actor)
        {
            var result = _actorService.Delete(actor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
