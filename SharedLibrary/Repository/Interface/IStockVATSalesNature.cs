using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
{
    public interface IStockVATSalesNature
    {
        IQueryable<InvStockVAT_SalesNature> GetAll();
        Task<List<InvStockVAT_SalesNature>> GetAllAsync();
        Task<InvStockVAT_SalesNature> GetByNameAsync(string name);
        Task AddAsync(InvStockVAT_SalesNature salesNature);
        Task UpdateAsync(InvStockVAT_SalesNature salesNature);

    }
}
