using BulkUpload.DataModel.Inventory;
using BulkUpload.DataModel.Inventory.ViewModel;

namespace BulkUpload.Repository.Interface
{
    public interface IStockSummary
    {
        public IQueryable<InvStockSummary> GetAll();
        Task<List<InvStockSummary>> GetAllAsync();

        Task<ReceiveSummaryViewModel> GetReceiveSummery(long pid, long sid, string OCODE);


    }
}
