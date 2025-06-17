using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvBank
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string BankName { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? AccountNo { get; set; }

        [MaxLength(200)]
        public string? RouteNo { get; set; }

        [MaxLength(200)]
        public string? Address { get; set; }

        [MaxLength(200)]
        public string? BranchName { get; set; }

        [MaxLength(200)]
        public string? Remarks { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Create_User { get; set; }

        public DateTime? Edit_Date { get; set; }

        public Guid? Edit_User { get; set; }
    }
}
