using Refit;
using SharedLibrary.DataModel.Inventory;
using System.Runtime.InteropServices;


namespace SharedLibrary.Repository.Interface
{
    public interface IStockSalesTempService
    {
        public IQueryable<InvStockSalesTemp> GetAll();

        public Task<List<InvStockSalesTemp>> GetAllAsync();

        [Post("/api/SalesTemp")]
        public Task AddAsync(InvStockSalesTemp stockSales);

        [Post("/api/SalesTemp/bulksalestemp")]
        public Task AddRangeAsync(List<InvStockSalesTemp> list);
    }
}
