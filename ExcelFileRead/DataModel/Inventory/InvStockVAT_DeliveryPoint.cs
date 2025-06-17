using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvStockVAT_DeliveryPoint
    {
        [Key]
        public long DeliveryPoint_Id { get; set; }

        public long? Customer_Id { get; set; } // Foreign Key to INV_Customer

        [Required]
        [MaxLength(300)]
        public string Delivery_Point { get; set; } = string.Empty;

        public string? Attention { get; set; } // nvarchar(max), nullable

        [MaxLength(50)]
        public string? OCode { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Create_User { get; set; }

        public Guid? Edit_User { get; set; }

        public DateTime? Edit_Date { get; set; }

       
    }
}
