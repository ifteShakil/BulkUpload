using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvStockVatPurchaseNature
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string? VatNature { get; set; }

        [Column(TypeName = "numeric(18, 2)")]
        public decimal? VATPer { get; set; }

        [MaxLength(10)]
        public string? Type { get; set; }

        public Guid? Create_User { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Edit_User { get; set; }

        public DateTime? Edit_Date { get; set; }

        [MaxLength(50)]
        public string? OCode { get; set; }
    }
}
