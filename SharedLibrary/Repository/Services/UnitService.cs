using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace SharedLibrary.Repository.Services
{
    public class UnitService : IUnit
    {

        private readonly ApplicationDbContext _context;
        public UnitService(ApplicationDbContext context)
        {
            _context = context;
        }


        public Task AddAsync(InvUnit unit)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvUnit> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvUnit>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvUnit> GetByProductIdAsync(int id)
        {

            var productId = await _context.Inv_Product
                .Where(x => x.ProductId == id).FirstOrDefaultAsync();

            var res = await _context.Inv_Unit.Where(x => x.UnitId == productId.UnitId).FirstOrDefaultAsync();
            return res;
        }

        public Task UpdateAsync(InvUnit unit)
        {
            throw new NotImplementedException();
        }
    }
}
