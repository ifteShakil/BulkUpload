using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvStockPoType
    {
        [Key]
        public long Id { get; set; } // Primary Key
        public string? PO_Type { get; set; }
        public bool? Status { get; set; }
        public Guid? Create_User { get; set; }
        public DateTime? Create_Date { get; set; }
        public Guid? Edit_User { get; set; }
        public DateTime? Edit_Date { get; set; }
        public string? OCode { get; set; }
    }
}
