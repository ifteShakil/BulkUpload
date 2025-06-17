using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvStockVAT_SalesNature
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150)]
        public string? VatNature { get; set; }

        public decimal? VATPer { get; set; }

        [Required]
        public decimal FixedVATRate { get; set; } = 0; // Default Value (0)

        public Guid? Create_User { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Edit_User { get; set; }

        public DateTime? Edit_Date { get; set; }

        [MaxLength(50)]
        public string? OCode { get; set; }
    }
}
