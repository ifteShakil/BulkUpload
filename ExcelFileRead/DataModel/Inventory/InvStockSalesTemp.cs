using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BulkUpload.DataModel.Inventory
{
    public class InvStockSalesTemp
    {
        [Key]
        public long SalesTempId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Invoice { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(50)]
        public string? BINNo { get; set; }

        public long? CustomerID { get; set; }

        [MaxLength(50)]
        public string? LadgerCode { get; set; }

        public int? StoreId { get; set; }

        [Required]
        public long ItemId { get; set; }

        [Required]
        public double Qty { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 4)")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 4)")]
        public decimal Total { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 9)")]
        public decimal ItemDiscountAmt { get; set; }

        [Required]
        [Column(TypeName = "numeric(18, 2)")]
        public decimal SDPercentage { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 9)")]
        public decimal SDAmount { get; set; }

        [Required]
        [Column(TypeName = "numeric(18, 2)")]
        public decimal ItemVatPer { get; set; }

        [Required]
        [Column(TypeName = "numeric(18, 2)")]
        public decimal FixedVATRate { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 9)")]
        public decimal ItemVat { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 9)")]
        public decimal NetTotal { get; set; }

        [Required]
        [Column(TypeName = "numeric(22, 9)")]
        public decimal InvoiceAmount { get; set; }

        [MaxLength(50)]
        public string? SalesType { get; set; }

        [MaxLength(70)]
        public string? NatureOfSupply { get; set; }

        public long? DeliveryPoint_Id { get; set; }

        [MaxLength(250)]
        public string? Remarks { get; set; }

        [MaxLength(10)]
        public string? OCODE { get; set; }

        public Guid? Create_User { get; set; }

        public DateTime? Create_Date { get; set; }

        public Guid? Edit_User { get; set; }

        public DateTime? Edit_Date { get; set; }

        public int? VehicleType_Id { get; set; }

        [MaxLength(100)]
        public string? VehicleNo { get; set; }

        [Required]
        public double DiscountPercent { get; set; }

        [Required]
        public double ItemRateDiscPercent { get; set; }

        [MaxLength(50)]
        public string? PO_RefNo { get; set; }
    }
}
