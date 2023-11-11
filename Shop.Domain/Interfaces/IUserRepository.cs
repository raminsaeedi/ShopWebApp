using System;
using Shop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Domain.Models.Account;

namespace Shop.Domain.Interfaces
{
    public interface IUserRepository
    {
        #region account
        Task<bool> IsUserExistPhoneNumber(string phoneNumber);
        Task CreateUser(User user);
        Task <User> GetUserByPhoneNumber(string phoneNumber);
        Task SaveChanges();
        #endregion
    }
}
