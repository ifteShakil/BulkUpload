using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;
using SharedLibrary.Repository.Interface;
using Microsoft.EntityFrameworkCore;
//using System.Linq.Dynamic.Core;

namespace SharedLibrary.Repository.Services
{
    public class CustomerService : ICustomer
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(InvCustomer customer)
        {
            throw new NotImplementedException();
        }

        public IQueryable<InvCustomer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InvCustomer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<InvCustomer> GetByNameAsync(string name)
        {
            var res = await _context.INV_Customer.Where(x => x.CustomerName == name).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Customer not found");

            }
     
            return res;
        }

        public async Task<InvCustomer> GetByCustomerCodeAsync(string customerCode)
        {
            var res = await _context.INV_Customer.Where(x => x.CustomerCode == customerCode).FirstOrDefaultAsync();
            if (res == null)
            {
                throw new Exception("Customer not found");
            }
            return res;
        }


        public Task UpdateAsync(InvCustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}
