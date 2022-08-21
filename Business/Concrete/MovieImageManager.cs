using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Helpers;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieImageManager : IMovieImageService
    {
        private readonly IMovieImageDal _movieImageDal;
        public MovieImageManager(IMovieImageDal movieImageDal)
        {
            _movieImageDal = movieImageDal;
        }


        [SecuredOperation("carimage.getall,moderator,admin")]
        [CacheAspect]
        public IDataResult<List<MovieImage>> GetAll()
        {
            return new SuccessDataResult<List<MovieImage>>(_movieImageDal.GetAll());
        }


        [CacheAspect]
        public IDataResult<MovieImage> GetById(int id)
        {
            var result = _movieImageDal.Get(m => m.Id == id);
            return new SuccessDataResult<MovieImage>(result);
        }


        [CacheAspect]
        public IDataResult<List<MovieImage>> GetImagesByMovieId(int movieId)
        {
            var result = _movieImageDal.GetAll(m => m.MovieId == movieId);
            IfImageOfMovieNotExistsAddDefault(result);
            return new SuccessDataResult<List<MovieImage>>(result);
        }


        //[SecuredOperation("movieimage.add,moderator,admin")]
        [CacheRemoveAspect("IMovieImageService.Get")]
        public IResult Add(IFormFile file, MovieImage movieImage)
        {
            var result = BusinessRules.Run(CheckIfImageCountOfMovieCorrect(movieImage.MovieId));
            if (result != null) return result;

            movieImage.ImagePath = FileHelperManager.Add(file, FileHelperManager.CreateNewPath(file));
            movieImage.Date = DateTime.Now;
            _movieImageDal.Add(movieImage);

            return new SuccessResult(Messages.MovieImageAdded);
        }



       // [SecuredOperation("movieimage.update,moderator,admin")]
        [CacheRemoveAspect("IMovieImageService.Get")]
        public IResult Update(IFormFile file, MovieImage movieImage)
        {
            var movieImageToUpdate = _movieImageDal.Get(c => c.Id == movieImage.Id);
            movieImage.MovieId = movieImageToUpdate.MovieId;
            movieImage.ImagePath = FileHelperManager.Update(movieImageToUpdate.ImagePath, file, FileHelperManager.CreateNewPath(file));
            movieImage.Date = DateTime.Now;
            _movieImageDal.Update(movieImage);
            return new SuccessResult(Messages.MovieImageUpdated);
        }


       // [SecuredOperation("movieimage.delete,moderator,admin")]
        [CacheRemoveAspect("IMovieImageService.Get")]
        public IResult Delete(MovieImage movieImage)
        {
            FileHelperManager.Delete(movieImage.ImagePath);
            _movieImageDal.Delete(movieImage);
            return new SuccessResult(Messages.MovieImageDeleted);
        }


        private IResult CheckIfImageCountOfMovieCorrect(int movieId)
        {
            var result = _movieImageDal.GetAll(m => m.MovieId == movieId).Count;
            if (result >= 5) return new ErrorResult(Messages.MovieImageCountOfMovieError);

            return new SuccessResult();
        }

        private void IfImageOfMovieNotExistsAddDefault(List<MovieImage> result)
        {
            if (!result.Any()) result.Add(CreateDefaultMovieImage());
        }


        private MovieImage CreateDefaultMovieImage()
        {
            var defaultMovieImage = new MovieImage
            {
                ImagePath =
                   $@"{Environment.CurrentDirectory}\wwwroot\Uploads\Images\MovieImages\default-img.png",
                Date = DateTime.Now
            };

            return defaultMovieImage;
        }
    }
}
