using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProducerManager : IProducerService
    {
        private readonly IProducerDal _producerDal;
        public ProducerManager(IProducerDal producerDal)
        {
            _producerDal = producerDal;
        }

        public IResult Add(Producer producer)
        {
            _producerDal.Add(producer);
            return new SuccessResult();
            
        }

        public IResult Delete(Producer producer)
        {
            _producerDal.Delete(producer);
            return new SuccessResult();
        }

        public IDataResult<List<Producer>> GetAll()
        {
           return new SuccessDataResult<List<Producer>>(_producerDal.GetAll());
        }

        public IDataResult<Producer> GetById(int producerId)
        {
            return new SuccessDataResult<Producer>(_producerDal.Get(p => p.Id == producerId));
        }

        public IResult Update(Producer producer)
        {
            _producerDal.Update(producer);
            return new SuccessResult();
        }
    }
}
