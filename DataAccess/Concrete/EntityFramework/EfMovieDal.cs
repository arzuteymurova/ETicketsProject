using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMovieDal : EfEntityRepositoryBase<Movie, ETicketsContext>, IMovieDal
    {
        public List<MovieDetailDto> GetMovieDetails()
        {
            using var context = new ETicketsContext();
            var result = from movie in context.Movies
                         join category in context.Categories on movie.CategoryId equals category.Id
                         join actor in context.Actors on movie.ActorId equals actor.Id
                         join producer in context.Producers on movie.ProducerId equals producer.Id
                         join cinema in context.Cinemas on movie.CinemaId equals cinema.Id
                         select new MovieDetailDto()
                         {
                             Id = movie.Id,
                             Name = movie.Name,
                             Price = movie.Price,
                             Description = movie.Description,
                             EndDate = movie.EndDate,
                             StartDate = movie.StartDate,
                             ImageUrl = movie.ImageUrl,
                             CategoryName = category.Name,
                             CinemaName = cinema.Name,
                             ActorName = actor.FullName,
                             ProducerName = producer.FullName
                         };
            return result.ToList();

        }

        public List<MovieDetailDto> GetMovieDetailsByActorId(int actorId)
        {
            using var context = new ETicketsContext();
            var result = from movie in context.Movies
                         join category in context.Categories on movie.CategoryId equals category.Id
                         join actor in context.Actors on movie.ActorId equals actor.Id
                         join producer in context.Producers on movie.ProducerId equals producer.Id
                         join cinema in context.Cinemas on movie.CinemaId equals cinema.Id
                         where movie.ActorId == actorId
                         select new MovieDetailDto()
                         {
                             Id = movie.Id,
                             Name = movie.Name,
                             Price = movie.Price,
                             Description = movie.Description,
                             EndDate = movie.EndDate,
                             StartDate = movie.StartDate,
                             ImageUrl = movie.ImageUrl,
                             CategoryName = category.Name,
                             CinemaName = cinema.Name,
                             ActorName = actor.FullName,
                             ProducerName = producer.FullName
                         };
            return result.ToList();
        }

        public List<MovieDetailDto> GetMovieDetailsByCategoryId(int categoryId)
        {
            using var context = new ETicketsContext();
            var result = from movie in context.Movies
                         join category in context.Categories on movie.CategoryId equals category.Id
                         join actor in context.Actors on movie.ActorId equals actor.Id
                         join producer in context.Producers on movie.ProducerId equals producer.Id
                         join cinema in context.Cinemas on movie.CinemaId equals cinema.Id
                         where movie.CategoryId == categoryId
                         select new MovieDetailDto()
                         {
                             Id = movie.Id,
                             Name = movie.Name,
                             Price = movie.Price,
                             Description = movie.Description,
                             EndDate = movie.EndDate,
                             StartDate = movie.StartDate,
                             ImageUrl = movie.ImageUrl,
                             CategoryName = category.Name,
                             CinemaName = cinema.Name,
                             ActorName = actor.FullName,
                             ProducerName = producer.FullName
                         };
            return result.ToList();
        }

        public List<MovieDetailDto> GetMovieDetailsByCinemaId(int cinemaId)
        {
            using var context = new ETicketsContext();
            var result = from movie in context.Movies
                         join category in context.Categories on movie.CategoryId equals category.Id
                         join actor in context.Actors on movie.ActorId equals actor.Id
                         join producer in context.Producers on movie.ProducerId equals producer.Id
                         join cinema in context.Cinemas on movie.CinemaId equals cinema.Id
                         where movie.CinemaId == cinemaId
                         select new MovieDetailDto()
                         {
                             Id = movie.Id,
                             Name = movie.Name,
                             Price = movie.Price,
                             Description = movie.Description,
                             EndDate = movie.EndDate,
                             StartDate = movie.StartDate,
                             ImageUrl = movie.ImageUrl,
                             CategoryName = category.Name,
                             CinemaName = cinema.Name,
                             ActorName = actor.FullName,
                             ProducerName = producer.FullName
                         };
            return result.ToList();
        }

        public MovieDetailDto GetMovieDetailsById(int movieId)
        {
            using var context = new ETicketsContext();
            var result = from movie in context.Movies
                         join category in context.Categories on movie.CategoryId equals category.Id
                         join actor in context.Actors on movie.ActorId equals actor.Id
                         join producer in context.Producers on movie.ProducerId equals producer.Id
                         join cinema in context.Cinemas on movie.CinemaId equals cinema.Id
                         where movie.Id == movieId
                         select new MovieDetailDto()
                         {
                             Id = movie.Id,
                             Name = movie.Name,
                             Price = movie.Price,
                             Description = movie.Description,
                             EndDate = movie.EndDate,
                             StartDate = movie.StartDate,
                             ImageUrl = movie.ImageUrl,
                             CategoryName = category.Name,
                             CinemaName = cinema.Name,
                             ActorName = actor.FullName,
                             ProducerName = producer.FullName
                         };
            return result.ToList()[0];
        }

        public List<MovieDetailDto> GetMovieDetailsByProducerId(int producerId)
        {
            using var context = new ETicketsContext();
            var result = from movie in context.Movies
                         join category in context.Categories on movie.CategoryId equals category.Id
                         join actor in context.Actors on movie.ActorId equals actor.Id
                         join producer in context.Producers on movie.ProducerId equals producer.Id
                         join cinema in context.Cinemas on movie.CinemaId equals cinema.Id
                         where movie.ProducerId == producerId
                         select new MovieDetailDto()
                         {
                             Id = movie.Id,
                             Name = movie.Name,
                             Price = movie.Price,
                             Description = movie.Description,
                             EndDate = movie.EndDate,
                             StartDate = movie.StartDate,
                             ImageUrl = movie.ImageUrl,
                             CategoryName = category.Name,
                             CinemaName = cinema.Name,
                             ActorName = actor.FullName,
                             ProducerName = producer.FullName
                         };
            return result.ToList();
        }
    }

}
