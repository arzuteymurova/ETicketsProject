using Core.Utilities.Results.Abstract;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IActorService
    {
        IResult Add(Actor actor);
        IResult Update(Actor actor);
        IResult Delete(Actor actor);
        IDataResult<List<Actor>> GetAll();
        IDataResult<Actor> GetById(int id);
    }
}
