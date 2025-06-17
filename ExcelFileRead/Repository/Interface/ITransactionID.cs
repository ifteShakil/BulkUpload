using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface ITransactionID
    {
        IQueryable<InvTransactionID> GetAll();
        Task<List<InvTransactionID>> GetAllAsync();


        string GetNewPurchaseTempChallanNo(string OCode);
        string GetNewSalesTempChallanNo(string OCode);
    }
}
