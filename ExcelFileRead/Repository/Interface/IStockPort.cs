using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IStockPort
    {
        public IQueryable<InvStockPort> GetAll();

        Task<List<InvStockPort>> GetAllAsync();

        Task<InvStockPort> GetByNameAsync(string name);

        Task AddAsync(InvStockPort port);
    }
}
