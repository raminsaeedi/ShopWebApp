using Microsoft.EntityFrameworkCore;
using Shop.Domain.Models.Account;

namespace Shop.Infra.Data.Context
{
    public class ShopDbContext : DbContext
    {
        
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }

        #region user
        public DbSet<User> Users { get; set; }
        #endregion
    }
}
