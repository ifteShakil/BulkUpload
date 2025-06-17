using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class StockPortService : IStockPort
    {
        private readonly ApplicationDbContext _context;

        public StockPortService(ApplicationDbContext context)
        {
            _context = context;
        }


        public Task AddAsync(InvStockPort port)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvStockPort> GetAll()
        {
            var res = _context.Inv_StockPort.AsQueryable();
            return res;
        }

        public async Task<List<InvStockPort>> GetAllAsync()
        {
            return await _context.Inv_StockPort.ToListAsync();
        }

        public async Task<InvStockPort> GetByNameAsync(string name)
        {
            var res = await _context.Inv_StockPort.Where(x => x.PortName == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Port not found");
            }

            return res;
        }
    }
}
