namespace BulkUpload.DataModel.Inventory
{
    public class InvStockVATHSCode
    {
        public long Id { get; set; } // Primary Key
        public string? HSCODE { get; set; }
        public string? Description { get; set; }
        public decimal? CD { get; set; } // Custom Duty
        public decimal? SD { get; set; } // Supplementary Duty
        public decimal? VAT { get; set; }
        public decimal? AIT { get; set; } // Advance Income Tax
        public decimal? RD { get; set; } // Regulatory Duty
        public decimal? ATV { get; set; } // Additional Tax VAT
        public decimal? TTI { get; set; } // Total Tax Incidence
        public decimal? EXD { get; set; } // Excise Duty
        public bool? Status { get; set; } // Active/Inactive status
        public DateTime? Create_Date { get; set; }
        public Guid? Create_User { get; set; }
        public Guid? Edit_User { get; set; }
        public DateTime? Edit_Date { get; set; }
        public string? OCode { get; set; }
        public decimal? AT { get; set; } // Additional Tax
    }
}
