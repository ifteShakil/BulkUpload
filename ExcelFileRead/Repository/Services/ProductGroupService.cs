using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class ProductGroupService : IProductGroup
    {
        private readonly ApplicationDbContext _context;

        public ProductGroupService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvProductGroup productGroup)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvProductGroup> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvProductGroup>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvProductGroup> GetByProductIdAsync(int id)
        {
            var product =  await _context.Inv_Product.Where(x => x.ProductId == id).FirstOrDefaultAsync();

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            var group = await _context.Inv_ProductGroup.Where(x => x.GroupId == product.GroupId).FirstOrDefaultAsync();
            if (group == null)
            {
                throw new Exception("Product Group not found");
            }
            return group;
        }

        public async Task<InvProductGroup> GetByNameAsync(string name)
        {
            var res = await _context.Inv_ProductGroup.Where(x => x.GroupName == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Product Group not found");
            }
            return res;
        }

        public Task UpdateAsync(InvProductGroup productGroup)
        {
            throw new NotImplementedException();
        }
    }
}
