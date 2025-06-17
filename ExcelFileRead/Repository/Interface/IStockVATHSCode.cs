using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IStockVATHSCode
    {
        IQueryable<InvStockVATHSCode> GetAll();
        Task<List<InvStockVATHSCode>> GetAllAsync();
        Task<InvStockVATHSCode> GetByNameAsync(string name);
        Task AddAsync(InvStockVATHSCode stockVATHSCode);
        Task UpdateAsync(InvStockVATHSCode stockVATHSCode);
    }
}
