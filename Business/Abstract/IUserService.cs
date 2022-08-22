using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);
        IDataResult<UserDetailDto> GetUserDetailByMail(string email);
        IDataResult<User> GetByMail(string userMail);
        IDataResult<List<User>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IResult Update(User user);
        IResult UpdateUserDetails(UserDetailForUpdateDto userDetailForUpdate);
        IResult Delete(User user);
        
       
    }
}
