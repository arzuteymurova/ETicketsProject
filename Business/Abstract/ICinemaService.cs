using Core.Utilities.Results.Abstract;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface ICinemaService
    {
        IResult Add(Cinema cinema);
        IResult Update(Cinema cinema);
        IResult Delete(Cinema cinema);
        IDataResult<List<Cinema>> GetAll();

        IDataResult<Cinema> GetById(int cinemaId);
    }
}
