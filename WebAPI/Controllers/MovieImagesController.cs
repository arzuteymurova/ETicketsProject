using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MovieImagesController : ControllerBase
    {
        private IMovieImageService _movieImageService;

        public MovieImagesController(IMovieImageService movieImageService)
        {
            _movieImageService = movieImageService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _movieImageService.GetAll();

            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getByMovieId")]
        public IActionResult GetByMovieId(int movieId)
        {
            var result = _movieImageService.GetImagesByMovieId(movieId);

            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int movieImageId)
        {
            var result = _movieImageService.GetById(movieImageId);

            if (result.Success) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet("getFileById")]
        public IActionResult GetFileById(int movieImageId)
        {
            var result = _movieImageService.GetById(movieImageId);

            if (result.Success)
            {
                var b = System.IO.File.ReadAllBytes(result.Data.ImagePath);
                return File(b, "image/jpeg");
            }


            return BadRequest(result.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(IFormFile file, [FromForm] MovieImage movieImage)
        {
            // file = HttpContext.Request.Form.Files[0];
            var result = _movieImageService.Add(file, movieImage);

            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public IActionResult Update(IFormFile file, [FromForm] MovieImage movieImage)
        {
            var result = _movieImageService.Update(file, movieImage);

            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(MovieImage movieImage)
        {
            var result = _movieImageService.Delete(movieImage);

            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }


    }
}
