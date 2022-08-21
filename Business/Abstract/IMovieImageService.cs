using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieImageService
    {
        IDataResult<MovieImage> GetById(int id);
        IDataResult<List<MovieImage>> GetImagesByMovieId(int movieId);
        IDataResult<List<MovieImage>> GetAll();
        IResult Add(IFormFile file, MovieImage movieImage);
        IResult Update(IFormFile file, MovieImage movieImage);
        IResult Delete(MovieImage movieImage);
       
    }
}
