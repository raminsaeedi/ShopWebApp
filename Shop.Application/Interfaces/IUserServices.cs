using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain.ViewModels.Account;

namespace Shop.Application.Interfaces
{
    public interface IUserServices
    {
        #region Account
        Task<RegisterUserResult> RegisterUser(RegisterUserViewModel register);
        Task<LoginUserResult> LoginUser(LoginUserViewModel loginUser);
        #endregion
    }
}
