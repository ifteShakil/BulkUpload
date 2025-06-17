using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class TransactionIDService : ITransactionID
    {
        private readonly ApplicationDbContext _context;

        public TransactionIDService(ApplicationDbContext context)
        {
            _context = context;
        }


        public IQueryable<InvTransactionID> GetAll()
        {
            return _context.Inv_TransactionID.AsQueryable();
        }

        public async Task<List<InvTransactionID>> GetAllAsync()
        {
            return await _context.Inv_TransactionID.ToListAsync();
        }


        public string GetNewPurchaseTempChallanNo(string OCode)
        {
            try
            {
                var inv = (from x in _context.Inv_TransactionID
                           where x.OCODE == OCode && x.Module == "PurchaseTemp"
                           select x).FirstOrDefault();

                var invoice = inv.Invoice;

                if (invoice == 0)
                {
                    invoice = 0 + 1;
                }
                else
                {
                    invoice = invoice + 1;
                }

                _context.SaveChanges();

                DateTime Today = DateTime.Today;
                var GYear = DateTime.Now.Year;
                var Month = DateTime.Now.Month;
                var Day = DateTime.Now.Day;
                var invoiceNo = ("RT" + "" + GYear + "" + Month + "" + Day + "" + "/" + invoice);
                return invoiceNo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public string GetNewSalesTempChallanNo(string OCode)
        {
            try
            {
                var inv = (from x in _context.Inv_TransactionID
                           where x.OCODE == OCode && x.Module == "SalesTemp"
                           select x).FirstOrDefault();

                var invoice = inv.Invoice;
                if (invoice == 0)
                {
                    invoice = 0 + 1;
                }
                else
                {
                    invoice = invoice + 1;
                }
                _context.SaveChanges();

                DateTime Today = DateTime.Today;

                var invoiceNo = (Today.Year + "" + invoice);
                
                return invoiceNo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

    }
}
