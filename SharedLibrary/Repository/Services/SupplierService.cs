
using Microsoft.EntityFrameworkCore;
using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;

namespace SharedLibrary.Repository.Services
{
    public class SupplierService : ISupplier
    {
        private readonly ApplicationDbContext _context;

        public SupplierService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<InvSupplier> GetByNameAsync(string name)
        {
            var res = await _context.Inv_Supplier.Where(x => x.SupplierName == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Supplier not found");
            }
            return res;
        }


        public async Task<InvSupplier> GetByCodeAsync(string code)
        {
            var res = await _context.Inv_Supplier.Where(x => x.SupplierCode == code).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Supplier CODE not found");
            }
            return res;
        }


        public IQueryable<InvSupplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvSupplier>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public Task AddAsync(InvSupplier supplier)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(InvSupplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
