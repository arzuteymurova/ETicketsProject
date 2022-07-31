using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public IResult Add(Movie movie)
        {
            _movieDal.Add(movie);
            return new SuccessResult();
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult();
        }

        public IDataResult<List<MovieDetailDto>> GetMovieDetails()
        {
            return new SuccessDataResult<List<MovieDetailDto>>(_movieDal.GetMovieDetails());
        }

        public IDataResult<List<MovieDetailDto>> GetMovieDetailsByActorId(int actorId)
        {
            return new SuccessDataResult<List<MovieDetailDto>>(_movieDal.GetMovieDetailsByActorId(actorId));
        }

        public IDataResult<List<MovieDetailDto>> GetMovieDetailsByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<MovieDetailDto>>(_movieDal.GetMovieDetailsByCategoryId(categoryId));
        }

        public IDataResult<List<MovieDetailDto>> GetMovieDetailsByCinemaId(int cinemaId)
        {
            return new SuccessDataResult<List<MovieDetailDto>>(_movieDal.GetMovieDetailsByCinemaId(cinemaId));
        }

        public IDataResult<MovieDetailDto> GetMovieDetailsById(int movieId)
        {
            return new SuccessDataResult<MovieDetailDto>(_movieDal.GetMovieDetailsById(movieId));
        }

        public IDataResult<List<MovieDetailDto>> GetMovieDetailsByProducerId(int producerId)
        {
            return new SuccessDataResult<List<MovieDetailDto>>(_movieDal.GetMovieDetailsByProducerId(producerId));
        }

        public IResult Update(Movie movie)
        {
            _movieDal.Update(movie);
            return new SuccessResult();
        }
    }
}
