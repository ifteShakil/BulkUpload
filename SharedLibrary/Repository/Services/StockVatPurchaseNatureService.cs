using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace SharedLibrary.Repository.Services
{
    public class StockVatPurchaseNatureService : IStockVatPurchaseNature
    {
        private readonly ApplicationDbContext _context;

        public StockVatPurchaseNatureService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvStockVatPurchaseNature purchaseNature)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvStockVatPurchaseNature> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStockVatPurchaseNature>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvStockVatPurchaseNature> GetByNameAsync(string name)
        {
            
            var res = await _context.Inv_StockVAT_PurchaseNature.Where(x => x.VatNature == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Purchase Nature not found");
            }
            return res;
        }


        public Task UpdateAsync(InvStockVatPurchaseNature purchaseNature)
        {
            throw new NotImplementedException();
        }
    }
}
