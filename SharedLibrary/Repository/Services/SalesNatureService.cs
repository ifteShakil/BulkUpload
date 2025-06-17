using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace SharedLibrary.Repository.Services
{
    public class SalesNatureService : IStockVATSalesNature
    {
        private readonly ApplicationDbContext _context;

        public SalesNatureService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvStockVAT_SalesNature salesNature)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvStockVAT_SalesNature> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStockVAT_SalesNature>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvStockVAT_SalesNature> GetByNameAsync(string name)
        {
            var res = await _context.Inv_StockVAT_SalesNature.Where(x => x.VatNature == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Sales Nature not found");
            }

            return res;

        }

        public Task UpdateAsync(InvStockVAT_SalesNature salesNature)
        {
            throw new NotImplementedException();
        }
    }
}
