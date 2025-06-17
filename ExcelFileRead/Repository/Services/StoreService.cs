using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class StoreService : IStore
    {
        private readonly ApplicationDbContext _context;

        public StoreService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvStore store)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvStore> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvStore>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvStore> GetByNameAsync(string name)
        {
            var res = await _context.Inv_Store.Where(x => x.StoreName == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Store not found");
            }

            return res;

        }

        public async Task<InvStore> GetByStoreCode (string storeCode)
        {
            var res = await _context.Inv_Store.Where(x => x.StoreCode == storeCode).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Store not found");
            }
            return res;
        }

        public Task UpdateAsync(InvStore store)
        {
            throw new NotImplementedException();
        }
    }
}
