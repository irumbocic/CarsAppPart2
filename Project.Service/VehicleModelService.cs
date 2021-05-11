using Project.DAL;
using Project.Model.Common;
using Project.Repository;
using Project.Repository.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleModelService : IVehicleModelService
    {
        private readonly IVehicleRepository<IVehicleModel> repository;

        public VehicleModelService(IVehicleRepository<IVehicleModel> repository)
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
