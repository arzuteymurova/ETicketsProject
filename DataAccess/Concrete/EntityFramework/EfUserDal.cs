using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ETicketsContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using var context = new ETicketsContext();
            var result = from operationClaim in context.OperationClaims
                         join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();
        }

        public UserDetailDto GetUserDetail(string userMail)
        {
            using var context = new ETicketsContext();
            var result = (from user in context.Users
                          join customer in context.Customers
                          on user.Id equals customer.UserId
                          where user.Email == userMail
                          select new UserDetailDto
                          {
                              Id = user.Id,
                              CustomerId = customer.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              Email = user.Email,
                              CompanyName = customer.CompanyName
                          }).First();
            return result;

        }
    }
}
