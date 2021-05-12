using Project.Model.Common;
using Project.Repository;
using Project.Repository.Common;
using Project.Repository.Repository;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleMakeService : IVehicleMakeService // AUTOMAPPER - mapirati iz DAL u MOdel!!
    {
        private readonly VehicleMakeRepository repository;

        public VehicleMakeService(VehicleMakeRepository repository)
        {
            this.repository = repository;
        }
        public async Task<IVehicleMake> CreteAsync(IVehicleMake newItem)
        {
            return await repository.CreteAsync(newItem);
        }

        public async Task<IVehicleMake> DeleteAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }

        public async Task<IVehicleMake> GetAsync(int id)
        {
            return await repository.GetAsync(id);
        }

       
        public async Task<IVehicleMake> UpdateAsync(IVehicleMake updatedItem)
        {
            return await repository.UpdateAsync(updatedItem);
        }


        public Task<IEnumerable<IVehicleMake>> GetListOfMakeNamesAsync()
        {
            throw new NotImplementedException();
        }

    }
}
