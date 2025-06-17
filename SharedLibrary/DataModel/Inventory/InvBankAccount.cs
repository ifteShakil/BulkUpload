using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvBankAccount
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Bank")]
        public int BankId { get; set; }

        [MaxLength(200)]
        public string? AccountName { get; set; }

        [MaxLength(200)]
        public string? AccountNo { get; set; }

        [MaxLength(200)]
        public string? AccountType { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Create_User { get; set; }

        public DateTime? Edit_Date { get; set; }

        public Guid? Edit_User { get; set; }

        // Navigation Property
        public virtual InvBank? Bank { get; set; }
    }
}
