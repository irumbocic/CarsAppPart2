using Project.Model.Common;
using Project.Service.Common;
using Project.Repository.Repository;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        private readonly VehicleModelRepository repository;

        public VehicleModelService(VehicleModelRepository repository )
        {
            this.repository = repository;
        }

        public async Task<IVehicleModel> CreteAsync(IVehicleModel newItem)
        {
           return  await repository.CreteAsync(newItem);
        }

        public async Task<IVehicleModel> DeleteAsync(int id)
        {
            return await repository.DeleteAsync(id);

        }

        public async Task<IVehicleModel> GetAsync(int id)
        {
            return await repository.GetAsync(id);
        }

        public async Task<IVehicleModel> UpdateAsync(IVehicleModel updatedItem)
        {
            return await repository.UpdateAsync(updatedItem);
        }
    }
}
