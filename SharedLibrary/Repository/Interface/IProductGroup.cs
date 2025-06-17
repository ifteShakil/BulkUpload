using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface IProductGroup
    {
        IQueryable<InvProductGroup> GetAll();
        Task<List<InvProductGroup>> GetAllAsync();
        Task<InvProductGroup> GetByProductIdAsync(int id);
        Task<InvProductGroup> GetByNameAsync(string name);
        Task AddAsync(InvProductGroup productGroup);
        Task UpdateAsync(InvProductGroup productGroup);
    }
}
