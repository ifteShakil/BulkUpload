using BulkUpload.DataModel.Authentication;
using BulkUpload.DataModel.Inventory;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.DataModel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //public DbSet<SystemUser> tbl_System_User { get; set; }

        public DbSet<User> tbl_User { get; set; }

        public DbSet<UserPassword> tbl_UserPassword { get; set; }

        public DbSet<UserRole> tbl_UserRole { get; set; }

        public DbSet<InvStockReceiveTemp> Inv_StockReceive_Temp { get; set; }

        public DbSet<InvStockSalesTemp> Inv_StockSalesTemp { get; set; }


    }
}
