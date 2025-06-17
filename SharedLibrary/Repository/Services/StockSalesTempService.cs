using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;


namespace SharedLibrary.Repository.Services
{
    public class StockSalesTempService : IStockSalesTempService
    {

        private readonly ApplicationDbContext _context;

        public StockSalesTempService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<InvStockSalesTemp>> GetAllAsync()
        {
            return await _context.Inv_StockSalesTemp.ToListAsync();
        }

        public IQueryable<InvStockSalesTemp> GetAll()
        {
            return _context.Inv_StockSalesTemp.AsQueryable();
        }


        public async Task AddAsync(InvStockSalesTemp stockSales)
        {
            _context.Inv_StockSalesTemp.Add(stockSales);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<InvStockSalesTemp> list)
        {
            await _context.Inv_StockSalesTemp.AddRangeAsync(list);
            await _context.SaveChangesAsync();


        }
    }
}
