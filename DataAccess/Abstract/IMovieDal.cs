using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDal:IEntityRepository<Movie>
    {
        List<MovieDetailDto> GetMovieDetails();
        MovieDetailDto GetMovieDetailsById(int movieId);
        List<MovieDetailDto> GetMovieDetailsByCategoryId(int categoryId);
        List<MovieDetailDto> GetMovieDetailsByActorId(int actorId);
        List<MovieDetailDto> GetMovieDetailsByProducerId(int producerId);
        List<MovieDetailDto> GetMovieDetailsByCinemaId(int cinemaId);

    }
}
