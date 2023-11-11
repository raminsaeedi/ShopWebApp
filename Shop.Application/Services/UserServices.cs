using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Application.Interfaces;
using Shop.Domain.Interfaces;
using Shop.Domain.Models.Account;
using Shop.Domain.ViewModels.Account;

namespace Shop.Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHelper _passwordHelper;
        public UserServices(IUserRepository userRepository, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _passwordHelper = passwordHelper;
        }

        

        public async Task<RegisterUserResult> RegisterUser(RegisterUserViewModel register)
        {
            if (!await _userRepository.IsUserExistPhoneNumber(register.PhoneNumber))
            {
                User user = new User
                {
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    CreateDate = DateTime.Now,
                    UserGender= UserGender.Unknown,
                    PhoneNumber = register.PhoneNumber,
                    Avatar ="",
                    IsMobileActived = false,
                    MobileActiveCode = new Random().Next(10000,99999).ToString(),
                    IsBlocked = false,
                    IsDelete = false,
                    UserName="",
                    Password=_passwordHelper.EncodePasswordMd5(register.Password)
                };
                await _userRepository.CreateUser(user);
                await _userRepository.SaveChanges();

                return RegisterUserResult.Success;
            }

            return RegisterUserResult.MobileExists;
        }

        public async Task<LoginUserResult> LoginUser(LoginUserViewModel loginUser)
        {
            User user = await _userRepository.GetUserByPhoneNumber(loginUser.PhoneNumber);

            if (user == null) { return LoginUserResult.NotFound; }
            if (user.IsBlocked) { return LoginUserResult.IsBlocked; }
            if (!user.IsMobileActived) { return LoginUserResult.NotActived; }
            if (user.Password != _passwordHelper.EncodePasswordMd5(loginUser.Password)) { return LoginUserResult.NotFound; }

            return LoginUserResult.Success;
        }
    }
}
