
using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface ICustomer
    {
        IQueryable<InvCustomer> GetAll();
        Task<List<InvCustomer>> GetAllAsync();
        Task<InvCustomer> GetByNameAsync(string name);
        Task<InvCustomer> GetByCustomerCodeAsync(string customerCode);
        Task AddAsync(InvCustomer customer);
        Task UpdateAsync(InvCustomer customer);

    }
}
