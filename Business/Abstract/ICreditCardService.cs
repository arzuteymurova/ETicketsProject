using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IDataResult<CreditCard> GetById(int id);

        IDataResult<List<CreditCard>> GetAllByCustomerId(int customerId);

        IResult Add(CreditCard creditCard);

        IResult Delete(CreditCard creditCard);
    }
}
