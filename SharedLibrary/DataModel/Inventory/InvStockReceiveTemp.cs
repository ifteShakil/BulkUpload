using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.DataModel.Inventory
{
    [Table("Inv_StockReceive_Temp")]
    public class InvStockReceiveTemp
    {
        [Key]
        public long Id { get; set; }
        public string? ChallanNo { get; set; }
        public string? BOMNo { get; set; }
        public DateTime? ChallanDate { get; set; }
        public string? ChallanRef { get; set; }
        
        public int? PortId { get; set; }
     
        //public InvStockPort? Port { get; set; }


        public string? PoType { get; set; }
        public string? PoRefNo { get; set; }
        public string? JobNo { get; set; }
        public int? ProductGroup { get; set; }
        public int? ProductId { get; set; }
        public int? UnitId { get; set; }
        public double? Qty { get; set; }
        public string? Currency { get; set; }
        public double? Rate { get; set; }
        public double? Total { get; set; }
        public double? ConvRate { get; set; }
        public double? TotalConvAmount { get; set; }
        public double? CDPer { get; set; }
        public double? CDValue { get; set; }
        public double? RDPer { get; set; }
        public double? RDValue { get; set; }
        public double? AITPer { get; set; }
        public double? AITValue { get; set; }
        public double ATPer { get; set; }
        public double? ATValue { get; set; }
        public double? SD_Rate { get; set; }
        public double? SD { get; set; }
        public double? VAT_Rate { get; set; }
        public double? VAT { get; set; }
        public double? RebatePer { get; set; }
        public double? Rebate { get; set; }
        public double? TotalPriceIncVAT { get; set; }
        public double? StockOpiningBalance { get; set; }
        public double? StockOpiningBalValue { get; set; }
        public double? StockClosinigBalance { get; set; }
        public double? StockClosinigBalValue { get; set; }
        public string? Barcode { get; set; }
        public int? SupplierId { get; set; }
        public string? SupplierLedgerCode { get; set; }
        public string? PurchaseLedgerCode { get; set; }
        public int? StoreId { get; set; }
        public bool? VDS_Applicable { get; set; }
        public string? VAT_AccountCode { get; set; }
        public Guid? Create_User { get; set; }
        public DateTime? Create_Date { get; set; }
        public Guid? Edit_User { get; set; }
        public DateTime? Edit_Date { get; set; }
        public string? OCode { get; set; }
        public string? BatchNo { get; set; }
        public string? HSCODE { get; set; }
        public DateTime? BillofEntryDate { get; set; }
        public bool VATStatus { get; set; }
        public string? Remarks { get; set; }
        public double? ActualQty { get; set; }
        public double? FreeQty { get; set; }
        public double? ATVPer { get; set; }
        public double? ATVValue { get; set; }
        public int? BankId { get; set; }
        public string? PurchaseType { get; set; }
        public int? BankAccountsId { get; set; }
    }
}
