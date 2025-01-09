using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IStockReceiveService
    {

        public IQueryable<InvStockReceiveTemp> GetAll();

        Task<List<InvStockReceiveTemp>> GetAllAsync();

        Task AddAsync(InvStockReceiveTemp stockReceive);
    }
}
