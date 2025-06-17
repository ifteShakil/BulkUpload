using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IStockPoType
    {
        public IQueryable<InvStockPoType> GetAll();
        Task<List<InvStockPoType>> GetAllAsync();
        Task<InvStockPoType> GetByNameAsync(string name);
        Task AddAsync(InvStockPoType port);
    }
}
