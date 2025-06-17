namespace SharedLibrary.DataModel.Inventory
{
    public class InvStockSummary
    {
        public long Id { get; set; }

        public long? StoreId { get; set; }

        public long? ProductId { get; set; }

        public string Barcode { get; set; }

        public decimal? Price { get; set; }

        public double? ReceivedQty { get; set; }

        public double? DelivaryQty { get; set; }

        public double? StoreReturnQty { get; set; }

        public double? SupplierReturnQty { get; set; }

        public double? DamageQty { get; set; }

        public double? SoldQty { get; set; }

        public double? SalesReturnQty { get; set; }

        public double? BalanceQty { get; set; }

        public string OCODE { get; set; }


    }
}
