using Project.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Project.Repository.Common;
using Microsoft.EntityFrameworkCore;
using Project.Model.Common;
using System.Linq;

namespace Project.Repository.Repository
{
    public class VehicleMakeRepository : IVehicleRepository<IVehicleMake>
    {
        private readonly IUnitOfWork unitOfWork;
        internal DbSet<IVehicleMake> dbSet;


        public VehicleMakeRepository (IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork"); // MOzda negdje drugo staviti?
            this.unitOfWork = unitOfWork;
            this.dbSet = unitOfWork.Db.Set<IVehicleMake>();
        }

        public async Task<IVehicleMake> CreteAsync(IVehicleMake newItem)
        {
            await dbSet.AddAsync(newItem);
            await unitOfWork.CommitAsync();
            return newItem;
        }

        public async Task<IVehicleMake> DeleteAsync(int id)
        {
            var deleteItem = await dbSet.FindAsync(id);
            unitOfWork.Db.Remove(deleteItem);
            await unitOfWork.CommitAsync();
            return deleteItem;
        }

        public async Task<IVehicleMake> GetAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }
        public async Task<IVehicleMake> UpdateAsync(IVehicleMake updatedItem)
        {
            var item = dbSet.Attach(updatedItem);
            item.State = EntityState.Modified;
            await unitOfWork.CommitAsync();
            return updatedItem;
        }
        public async Task<IEnumerable<IVehicleMake>> GetListOfMakeNamesAsync() // OVO NAPRAVI DRUGACIJE!!!!
        {
            var listOfMakeNames = await dbSet.ToListAsync();
            return listOfMakeNames;
        }

    }
}
