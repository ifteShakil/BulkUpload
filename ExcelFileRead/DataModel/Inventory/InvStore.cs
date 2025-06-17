using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvStore
    {

        [Key]
        public int Store_Id { get; set; } // Primary Key
        public string? StoreName { get; set; }
        public string? StoreCode { get; set; }
        public string? Address { get; set; }
        public int? AreaId { get; set; }
        public int? StoreTypeId { get; set; }
        public bool? Status { get; set; } // Active/Inactive status
        public Guid? Create_User { get; set; }
        public DateTime? Create_Date { get; set; }
        public string? Edit_User { get; set; } // Kept as string since it's nvarchar(50)
        public DateTime? Edit_Date { get; set; }
        public string? OCODE { get; set; }
    }
}
