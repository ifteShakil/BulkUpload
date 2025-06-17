using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DataModel.Inventory.ViewModel
{
    public class SalesTempDTO
    {
        //public string Invoice { get; set; }
        public string InvoiceRef { get; set; }
        public DateTime Date { get; set; }
        public string CustomerCode { get; set; }
        public string StoreCode { get; set; }
        public string ProductCode { get; set; }
        public double Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal ItemVatPer { get; set; }
        public decimal ItemVat { get; set; }
        public decimal NetTotal { get; set; }
        public string SalesType { get; set; }
        public string NatureOfSupply { get; set; }
        //public int DeliveryPoint_Id { get; set; }
        public string Remarks { get; set; }
        //public string OCODE { get; set; }
        //public int VehicleType_Id { get; set; }
        public string VehicleNo { get; set; }
        


    }
}
