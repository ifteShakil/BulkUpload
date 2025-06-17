using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface IStore
    {
        IQueryable<InvStore> GetAll();
        Task<List<InvStore>> GetAllAsync();
        Task<InvStore> GetByNameAsync(string name);
        Task<InvStore> GetByStoreCode(string storeCode);
        Task AddAsync(InvStore store);
        Task UpdateAsync(InvStore store);
    }
}
