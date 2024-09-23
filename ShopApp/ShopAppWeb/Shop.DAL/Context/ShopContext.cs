

using Microsoft.EntityFrameworkCore;
using Shop.DAL.Entities;

namespace Shop.DAL.Context
{
    public class ShopContext : DbContext
    {
        #region"Constructor"
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        #endregion
        #region"DbSets"
        public DbSet<Customers> Customers{ get; set; }
        public DbSet<Categories> Categories{ get; set; }
        public DbSet<Products> Products{ get; set; }
        public DbSet<Suppliers> Suppliers{ get; set; }
        #endregion
    }
}
