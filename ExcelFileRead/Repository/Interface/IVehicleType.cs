using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;

namespace BulkUpload.Repository.Interface
{
    public interface IVehicleType
    {
        IQueryable<VehVehicleType> GetAll();
        Task<List<VehVehicleType>> GetAllAsync();
        Task<VehVehicleType> GetByNameAsync(string name);
        Task AddAsync(VehVehicleType vehicleType);
        Task UpdateAsync(VehVehicleType vehicleType);
    }
}
