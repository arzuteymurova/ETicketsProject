using Core.Utilities.Results.Abstract;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IProducerService
    {
        IResult Add(Producer producer); 
        IResult Update(Producer producer); 
        IResult Delete(Producer producer); 
        IDataResult<List<Producer>> GetAll();
        IDataResult<Producer> GetById(int producerId);
    }
}
