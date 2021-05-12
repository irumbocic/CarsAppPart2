using Project.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Microsoft.EntityFrameworkCore;
using Project.Model.Common;
using System.Linq;
using Project.DAL;

namespace Project.Repository.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        private readonly IVehicleRepository<IVehicleMake> repository;

        public VehicleMakeRepository(IVehicleRepository<IVehicleMake> repository)
        {
            this.repository = repository;
        }


        public async Task<IVehicleMake> CreteAsync(IVehicleMake newItem)
        {
            await repository.CreteAsync(newItem);

            return newItem;
        }

        public async Task<IVehicleMake> DeleteAsync(int id) // PROBAJ NAPRAVITI DA I OVO BUDE VehicleMake, da NEMAS OVOG FindAsync mozda, ne znam
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
        public void GetListOfMakeNamesAsync() // OVO NAPRAVI DRUGACIJE!!!!
        {
            //var listOfMakeNames = await dbSet.ToListAsync();
            //return listOfMakeNames;
        }

    }
}
