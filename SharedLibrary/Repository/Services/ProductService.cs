using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace SharedLibrary.Repository.Services
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvProduct product)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvProduct> GetAll()
        {
            var res = _context.Inv_Product.AsQueryable();
            return res;
        }

        public async Task<List<InvProduct>> GetAllAsync()
        {
            return await _context.Inv_Product.ToListAsync();
        }

        public async Task<InvProduct> GetByNameAsync(string name)
        {
        
            var res = await _context.Inv_Product
                .Where(x => x.ProductName == name).FirstOrDefaultAsync();

            if (res == null)
            {
                throw new Exception("Product not found");
            }

            return res;
        }

        public async Task<InvProduct> GetByCodeAsync(string code)
        {

            var res = await _context.Inv_Product
                .Where(x => x.ProductCode == code).FirstOrDefaultAsync();

            if (res == null)
            {
                throw new Exception("Product not found");
            }

            return res;
        }

        public Task UpdateAsync(InvProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
