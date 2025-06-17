using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvTransactionID
    {
        [Key]
        public long TransactionID { get; set; }

        [Required]
        [StringLength(50)]
        public string OCODE { get; set; } = string.Empty;

        public long? Invoice { get; set; }

        [StringLength(50)]
        public string? Module { get; set; }
    }
}
