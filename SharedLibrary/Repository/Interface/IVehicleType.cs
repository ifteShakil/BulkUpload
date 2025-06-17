using SharedLibrary.DataModel;
using SharedLibrary.DataModel.Inventory;

namespace SharedLibrary.Repository.Interface
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
