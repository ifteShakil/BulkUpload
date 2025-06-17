using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DataModel.Inventory
{
    public class InvSupplier
    {
        [Key]
        public int Id { get; set; } // Primary Key
        public string? SupplierType { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierCode { get; set; }
        public string? LedgerCode { get; set; }
        public string? Address { get; set; }
        public int? DistrictId { get; set; }
        public string? Phone { get; set; }
        public string? Supplier_Mobile { get; set; }
        public string? Supplier_Fax { get; set; }
        public string? EmailAddress { get; set; }
        public string? Supplier_Remarks { get; set; }
        public string? CreditDays { get; set; }
        public string? Fired { get; set; }
        public string? Performance { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? Enlisted { get; set; }
        public string? Trade_License_No { get; set; }
        public string? Certificate_Incorp { get; set; }
        public string? Tin_No { get; set; }
        public string? NID { get; set; }
        public string? VATRegistrationNo { get; set; }
        public string? VATStatus { get; set; }
        public string? BINNo { get; set; }
        public string? Validity { get; set; }
        public DateTime? Incorp_Date { get; set; }
        public string? Business_Capital { get; set; }
        public string? Bank_Name { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPerson_Designation { get; set; }
        public string? ContactPerson_Phone { get; set; }
        public string? ContactPerson_Mobile { get; set; }
        public string? ContactPerson_Fax { get; set; }
        public string? ContactPerson_Email { get; set; }
        public decimal? OpeningBalance { get; set; }
        public string? OpeningNature { get; set; }
        public bool? Status { get; set; }
        public DateTime? EditDate { get; set; }
        public Guid? EditUser { get; set; }
        public string? OCode { get; set; }
        public string? BusinessType { get; set; }
        public int? ItemCategoryId { get; set; }
    }
}
