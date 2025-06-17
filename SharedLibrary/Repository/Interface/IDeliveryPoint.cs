using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface IDeliveryPoint
    {
        IQueryable<InvStockVAT_DeliveryPoint> GetAll();
        Task<List<InvStockVAT_DeliveryPoint>> GetAllAsync();
        Task<InvStockVAT_DeliveryPoint> GetByNameAsync(string name);
        Task AddAsync(InvStockVAT_DeliveryPoint deliveryPoint);
        Task UpdateAsync(InvStockVAT_DeliveryPoint deliveryPoint);
    }
}
