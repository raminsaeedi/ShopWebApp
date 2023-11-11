using Microsoft.EntityFrameworkCore;
using Shop.Domain.Interfaces;
using Shop.Domain.Models.Account;
using Shop.Infra.Data.Context;

namespace Shop.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        #region Contractors
        private readonly ShopDbContext _context;
        public UserRepository(ShopDbContext context)
        {
            _context = context;
        }


        #endregion
        public async Task<bool> IsUserExistPhoneNumber(string phoneNumber)
        {
            return await _context.Users.AsQueryable().AnyAsync(c => c.PhoneNumber == phoneNumber);
        }
        public async Task CreateUser(User user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<User> GetUserByPhoneNumber(string phoneNumber)
        {
            return await _context.Users.AsQueryable().SingleOrDefaultAsync(c => c.PhoneNumber == phoneNumber);
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

    }
}
