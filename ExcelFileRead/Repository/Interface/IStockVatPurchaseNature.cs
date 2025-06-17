using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IStockVatPurchaseNature
    {
        IQueryable<InvStockVatPurchaseNature> GetAll();
        Task<List<InvStockVatPurchaseNature>> GetAllAsync();
        Task<InvStockVatPurchaseNature> GetByNameAsync(string name);
        Task AddAsync(InvStockVatPurchaseNature purchaseNature);
        Task UpdateAsync(InvStockVatPurchaseNature purchaseNature);
    }
}
