using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CinemaManager : ICinemaService
    {
        private readonly ICinemaDal _cinemaDal;
        public CinemaManager(ICinemaDal cinemaDal)
        {
            _cinemaDal = cinemaDal;
        }

        public IResult Add(Cinema cinema)
        {
            _cinemaDal.Add(cinema);
            return new SuccessResult();
        }

        public IResult Delete(Cinema cinema)
        {
            _cinemaDal.Delete(cinema);
            return new SuccessResult();
        }

        public IDataResult<List<Cinema>> GetAll()
        {
            return new SuccessDataResult<List<Cinema>>(_cinemaDal.GetAll());
        }

        public IDataResult<Cinema> GetById(int cinemaId)
        {
            return new SuccessDataResult<Cinema>(_cinemaDal.Get(c => c.Id == cinemaId));
        }

        public IResult Update(Cinema cinema)
        {
            _cinemaDal.Update(cinema);
            return new SuccessResult();
        }


    }
}
