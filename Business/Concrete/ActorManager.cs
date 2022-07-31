

using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ActorManager : IActorService
    {
        private readonly IActorDal _actorDal;
        public ActorManager(IActorDal actorDal)
        {
            _actorDal = actorDal;
        }

        [SecuredOperation("admin,add")]
        [ValidationAspect(typeof(ActorValidator))]
        [CacheRemoveAspect("IActorService.Get")]
        public IResult Add(Actor actor)
        {
            //SecuredOperation.OnBefore(_actorDal.Add(actor));
            _actorDal.Add(actor);
            return new SuccessResult();
        }

        public IResult Delete(Actor actor)
        {
            _actorDal.Delete(actor);
            return new SuccessResult();
        }

        [CacheAspect(10)]       
        public IDataResult<List<Actor>> GetAll()
        {
            return new SuccessDataResult<List<Actor>>(_actorDal.GetAll());
        }

        [PerformanceAspect(5)]
        public IDataResult<Actor> GetById(int id)
        {
            return new SuccessDataResult<Actor>(_actorDal.Get(a => a.Id == id));
        }

        public IResult Update(Actor actor)
        {
            _actorDal.Update(actor);
            return new SuccessResult();
        }
    }
}
