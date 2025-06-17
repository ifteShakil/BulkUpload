using BulkUpload.DataModel;
using BulkUpload.DataModel.Inventory;
using BulkUpload.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BulkUpload.Repository.Services
{
    public class VehicleTypeService : IVehicleType
    {

        private readonly ApplicationDbContext _context;
        public VehicleTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(VehVehicleType vehicleType)
        {
            throw new NotImplementedException();
        }

        public IQueryable<VehVehicleType> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<VehVehicleType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<VehVehicleType> GetByNameAsync(string name)
        {
            var res = await _context.Veh_VehicleType.Where(x => x.Vehicle_Type == name).FirstOrDefaultAsync();
            return res;

        }

        public Task UpdateAsync(VehVehicleType vehicleType)
        {
            throw new NotImplementedException();
        }
    }
}
