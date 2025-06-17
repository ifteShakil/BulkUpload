using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface IUnit
    {
        IQueryable<InvUnit> GetAll();
        Task<List<InvUnit>> GetAllAsync();
        Task<InvUnit> GetByProductIdAsync(int id);
        Task AddAsync(InvUnit unit);
        Task UpdateAsync(InvUnit unit);

    }
}
