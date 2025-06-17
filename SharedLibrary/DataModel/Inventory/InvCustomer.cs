using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvCustomer
    {
        [Key]
        public long Customer_Id { get; set; }

        [MaxLength(50)]
        public string? CustomerType { get; set; }

        [MaxLength(50)]
        public string? CustomerCode { get; set; }

        [MaxLength(50)]
        public string? Mr_Mrs { get; set; }

        [MaxLength(100)]
        public string? CustomerName { get; set; }

        public DateTime? DOB { get; set; }

        [MaxLength(50)]
        public string? M_Date { get; set; }

        [MaxLength(50)]
        public string? Organization { get; set; }

        [MaxLength(50)]
        public string? LedgerCode { get; set; }

        [MaxLength(20)]
        public string? CustomerAC_No { get; set; }

        [MaxLength(50)]
        public string? CustomerAC_NameAndBranch { get; set; }

        [MaxLength(25)]
        public string? City { get; set; }

        public int? AreaId { get; set; }

        [MaxLength(150)]
        public string? Address1 { get; set; }

        [MaxLength(50)]
        public string? Address2 { get; set; }

        public int? Country { get; set; }

        [MaxLength(50)]
        public string? ContactPerson { get; set; }

        [MaxLength(20)]
        public string? ContactNo { get; set; }

        [MaxLength(20)]
        public string? PhoneNo { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? VatRegNo { get; set; }

        [MaxLength(50)]
        public string? TIN { get; set; }

        [MaxLength(50)]
        public string? NID { get; set; }

        [MaxLength(50)]
        public string? VatStatus { get; set; }

        public bool? Status { get; set; }

        public string? Remarks { get; set; } // nvarchar(max) হওয়ার কারণে কোনো MaxLength নেই

        [MaxLength(50)]
        public string? CustomerBINNumber { get; set; }

        public decimal? TotalSaleAmount { get; set; }

        public decimal? TotalCollectionAmount { get; set; }

        public decimal? TotalDueAmount { get; set; }

        public decimal? OpeningBalance { get; set; }

        [MaxLength(10)]
        public string? OpeningNature { get; set; }

        public decimal? TotalCreditLimit { get; set; }

        public Guid? Create_User { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Edit_User { get; set; }

        public DateTime? Edit_Date { get; set; }

        [MaxLength(50)]
        public string? OCode { get; set; }

        public int? RouteId { get; set; }

        [ForeignKey("Division")]
        public int? DivisionId { get; set; }

        // Navigation Property
        //public virtual InvDivision? Division { get; set; }
    }
}
