using Microsoft.EntityFrameworkCore;
using Project.Model;
using Project.Model.Common;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        private readonly IVehicleRepository<IVehicleModel> repository;

        public VehicleModelRepository(IVehicleRepository<IVehicleModel> repository)
        {
            this.repository = repository;
        }

        public async Task<IVehicleModel> CreteAsync(IVehicleModel newItem)
        {
            return await repository.CreteAsync(newItem);
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
