using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IProduct
    {
        IQueryable<InvProduct> GetAll();
        Task<List<InvProduct>> GetAllAsync();
        Task<InvProduct> GetByNameAsync(string name);

        Task<InvProduct> GetByCodeAsync(string code);

        Task AddAsync(InvProduct product);
        Task UpdateAsync(InvProduct product);


    }
}
