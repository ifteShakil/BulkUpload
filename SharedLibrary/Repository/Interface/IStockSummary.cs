using SharedLibrary.DataModel.Inventory;
using SharedLibrary.DataModel.Inventory.ViewModel;

namespace SharedLibrary.Repository.Interface
{
    public interface IStockSummary
    {
        public IQueryable<InvStockSummary> GetAll();
        Task<List<InvStockSummary>> GetAllAsync();

        Task<ReceiveSummaryViewModel> GetReceiveSummery(long pid, long sid, string OCODE);


    }
}
