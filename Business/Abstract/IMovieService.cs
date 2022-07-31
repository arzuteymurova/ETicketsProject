using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IMovieService
    {
        IResult Add(Movie movie); 
        IResult Update(Movie movie); 
        IResult Delete(Movie movie); 
        IDataResult<List<MovieDetailDto>> GetMovieDetails();
        IDataResult<MovieDetailDto> GetMovieDetailsById(int movieId);
        IDataResult<List<MovieDetailDto>> GetMovieDetailsByActorId(int actorId);
        IDataResult<List<MovieDetailDto>> GetMovieDetailsByCategoryId(int categoryId);
        IDataResult<List<MovieDetailDto>> GetMovieDetailsByProducerId(int producerId);
        IDataResult<List<MovieDetailDto>> GetMovieDetailsByCinemaId(int cinemaId);
    }
}
