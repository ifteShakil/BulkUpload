using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.DataModel.Inventory.ViewModel;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace BulkUpload.Repository.Services
{
    public class StockSummaryService : IStockSummary
    {
        private readonly ApplicationDbContext _context;
        public StockSummaryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<InvStockSummary> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStockSummary>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ReceiveSummaryViewModel> GetReceiveSummery(long pid, long sid, string OCODE)
        {
            var res = await _context.Inv_StockSummary
             .Where(x => x.ProductId == pid && x.StoreId == sid && x.OCODE == OCODE)
             .Select(x => new ReceiveSummaryViewModel
             {
                 SId = x.Id,
                 ReceivedQty = x.ReceivedQty ?? 0,
                 BalanceQty = x.BalanceQty ?? 0,
                 Price = x.Price ?? 0
             })
             .FirstOrDefaultAsync();

            return res;
        }


    }
}
