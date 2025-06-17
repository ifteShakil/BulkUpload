using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace SharedLibrary.Repository.Services
{
    public class DeliveryPointService : IDeliveryPoint
    {
        private readonly ApplicationDbContext _context;
        public DeliveryPointService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvStockVAT_DeliveryPoint deliveryPoint)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvStockVAT_DeliveryPoint> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStockVAT_DeliveryPoint>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvStockVAT_DeliveryPoint> GetByNameAsync(string name)
        {
            var res = await _context.Inv_StockVAT_DeliveryPoint.Where(x => x.Delivery_Point == name).FirstOrDefaultAsync();
            return res;
        }

        public Task UpdateAsync(InvStockVAT_DeliveryPoint deliveryPoint)
        {
            throw new NotImplementedException();
        }
    }
}
