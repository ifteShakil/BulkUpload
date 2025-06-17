using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class StockPoTypeService : IStockPoType
    {
        private readonly ApplicationDbContext _context;
        public StockPoTypeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<InvStockPoType> GetByNameAsync(string name)
        {
            var res = await _context.Inv_StockPoType.Where(x => x.PO_Type == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("PoType not found");
            }
            return res;
        }

        public IQueryable<InvStockPoType> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStockPoType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(InvStockPoType port)
        {
            throw new NotImplementedException();
        }
    }
}
