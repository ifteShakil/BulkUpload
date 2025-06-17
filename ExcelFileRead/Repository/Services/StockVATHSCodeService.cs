using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class StockVATHSCodeService : IStockVATHSCode
    {
        private readonly ApplicationDbContext _context;

        public StockVATHSCodeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvStockVATHSCode stockVATHSCode)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvStockVATHSCode> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStockVATHSCode>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvStockVATHSCode> GetByNameAsync(string name)
        {
            var res = await _context.Inv_StockVAT_HSCODE.Where(x => x.HSCODE == name).FirstOrDefaultAsync();

            if (res == null)
            {
                throw new Exception("StockVATHSCode not found");
            }
            return res;
        }

        public Task UpdateAsync(InvStockVATHSCode stockVATHSCode)
        {
            throw new NotImplementedException();
        }
    }
}
