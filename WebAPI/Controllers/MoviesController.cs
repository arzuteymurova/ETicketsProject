using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetMovieDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getById/{movieId}")]
        public IActionResult GetById(int movieId)
        {
            var result = _movieService.GetMovieDetailsById(movieId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getByActor/{actorId}")]
        public IActionResult GetByActor(int actorId)
        {
            var result = _movieService.GetMovieDetailsByActorId(actorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getByCategory/{categoryId}")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _movieService.GetMovieDetailsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getByProducer/{producerId}")]
        public IActionResult GetByProducer(int producerId)
        {
            var result = _movieService.GetMovieDetailsByProducerId(producerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getByCinema/{cinemaId}")]
        public IActionResult GetByCinema(int cinemaId)
        {
            var result = _movieService.GetMovieDetailsByCinemaId(cinemaId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Movie movie)
        {
            var result = _movieService.Add(movie);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPut("update")]
        public IActionResult Update(Movie movie)
        {
            var result = _movieService.Update(movie);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Movie movie)
        {
            var result = _movieService.Delete(movie);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
