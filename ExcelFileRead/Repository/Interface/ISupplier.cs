using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface ISupplier
    {
        IQueryable<InvSupplier> GetAll();
        Task<List<InvSupplier>> GetAllAsync();
        Task<InvSupplier> GetByNameAsync(string name);
        Task<InvSupplier> GetByCodeAsync(string code);

        Task AddAsync(InvSupplier supplier);
        Task UpdateAsync(InvSupplier supplier);

    }
}
