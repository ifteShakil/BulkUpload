using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvProduct
    {
        [Key]
        public int ProductId { get; set; } // Primary Key
        public int? GroupId { get; set; }
        public int? SubId { get; set; }
        [MaxLength(50)]
        public string? ProductCode { get; set; }
        [MaxLength(50)]
        public string? HSCODE { get; set; }
        public string? ProductName { get; set; }
        [MaxLength(50)]
        public string? Brand { get; set; }
        [MaxLength(100)]
        public string? StyleAndSize { get; set; }
        public int? UnitId { get; set; }
        public int? ConvUnitId { get; set; }
        public double? ConvUnitQty { get; set; }
        public double? ReOrderQty { get; set; } = 0; // Default value from DB
        public int? ProductType { get; set; }
        public int? ProductMasterType { get; set; }
        public decimal? ActualPrice { get; set; } = 0; // Default value from DB
        public decimal? DiscountPer { get; set; }
        public decimal VATPer { get; set; } = 0; // Default value from DB
        public decimal VATAmount { get; set; } = 0; // Default value from DB
        public decimal? SupplementaryVATPer { get; set; } = 0; // Default value from DB
        public decimal? SupplementaryVATPerAmount { get; set; } = 0; // Default value from DB
        public decimal? RebatePer { get; set; } = 0; // Default value from DB
        public decimal? RebateAmt { get; set; } = 0; // Default value from DB
        public decimal? Price { get; set; } = 0; // Default value from DB
        public int? StoreUnitID { get; set; }
        public string? Location { get; set; }
        [MaxLength(50)]
        public string? OCode { get; set; }
        public Guid? Create_User { get; set; }
        public DateTime? Create_Date { get; set; }
        public Guid? Edit_User { get; set; }
        public DateTime? Edit_Date { get; set; }
        public int? ParentProductId { get; set; }

    }
}
