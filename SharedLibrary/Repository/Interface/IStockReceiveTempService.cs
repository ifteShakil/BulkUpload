using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface IStockReceiveTempService
    {

        public IQueryable<InvStockReceiveTemp> GetAll();

        Task<List<InvStockReceiveTemp>> GetAllAsync();

        Task AddAsync(InvStockReceiveTemp stockReceive);

        Task AddRangeAsync(List<InvStockReceiveTemp> list);
    }
}
