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
        
        public DbSet<InvStockPort> Inv_StockPort { get; set; } //Inv_StockPort

        public DbSet<InvStockPoType> Inv_StockPoType { get; set; } // Inv_StockPoType

        public DbSet<InvProduct> Inv_Product { get; set; } // Inv_Product

        public DbSet<InvProductGroup> Inv_ProductGroup { get; set; } // Inv_ProductGroup

        public DbSet<InvSupplier> Inv_Supplier { get; set; } // Inv_Supplier

        public DbSet<InvStockVATHSCode> Inv_StockVAT_HSCODE { get; set; } // Inv_StockVAT_HSCODE

        public DbSet<InvStore> Inv_Store { get; set; } // Inv_Store

        public DbSet<InvUnit> Inv_Unit { get; set; } // Inv_Unit

        public DbSet<InvCustomer> INV_Customer { get; set; } // INV_Customer

        public DbSet<InvStockVatPurchaseNature> Inv_StockVAT_PurchaseNature { get; set; } // Inv_StockVAT_PurchaseNature

        public DbSet<InvStockVAT_SalesNature> Inv_StockVAT_SalesNature { get; set; } // Inv_StockVAT_SalesNature

        public DbSet<InvStockVAT_DeliveryPoint> Inv_StockVAT_DeliveryPoint { get; set; } // Inv_StockVAT_DeliveryPoint

        public DbSet<InvTransactionID> Inv_TransactionID { get; set; } // Inv_TransactionID

        public DbSet<VehVehicleType> Veh_VehicleType { get; set; } // Veh_VehicleType

        public DbSet<InvStockSummary> Inv_StockSummary { get; set; } // Inv_StockSummary


    }
}
