using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, StockTrackingProjectContext>, IUserDal
    {
        public List<UserDto> GetUserDetails(Expression<Func<UserDto, bool>> filter = null)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from u in context.Users
                             select new UserDto
                             {
                                 UserId = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 PhoneNumber = u.PhoneNumber,
                                 Address = u.Address
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }



        public UserDto GetUserDetail(int userId)
        {
            using (StockTrackingProjectContext context = new StockTrackingProjectContext())
            {
                var result = from user in context.Users.Where(u => u.Id == userId)
                             select new UserDto
                             {
                                 UserId = user.Id,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 PhoneNumber = user.PhoneNumber,
                                 Address = user.Address
                             };
                return result.SingleOrDefault();
            }
        }


        public List<OperationClaim> GetClaims(User user)
        {
            throw new NotImplementedException();
        }


    }
}
