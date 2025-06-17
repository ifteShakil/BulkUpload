using BulkUpload.DataModel.Inventory;


namespace BulkUpload.Repository.Interface
{
    public interface IStockSalesTempService
    {
        public IQueryable<InvStockSalesTemp> GetAll();

        Task<List<InvStockSalesTemp>> GetAllAsync();
        Task AddAsync(InvStockSalesTemp stockSales);

        Task AddRangeAsync(List<InvStockSalesTemp> list);

    }
}
