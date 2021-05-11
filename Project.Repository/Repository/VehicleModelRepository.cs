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
    public class VehicleModelRepository : IVehicleRepository<IVehicleModel>
    {
        private readonly IUnitOfWork unitOfWork;
        internal DbSet<IVehicleModel> dbSet;


        public VehicleModelRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork"); // MOzda negdje drugo staviti?
            this.unitOfWork = unitOfWork;
            this.dbSet = unitOfWork.Db.Set<IVehicleModel>();
        }

        public async Task<IVehicleModel> CreteAsync(IVehicleModel newItem)
        {
            await dbSet.AddAsync(newItem);
            await unitOfWork.CommitAsync();
            return newItem;
        }

        public async Task<IVehicleModel> DeleteAsync(int id)
        {
            var deleteItem = await dbSet.FindAsync(id);
            unitOfWork.Db.Remove(deleteItem);
            await unitOfWork.CommitAsync();
            return deleteItem;
        }

        public async Task<IVehicleModel> GetAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IVehicleModel> UpdateAsync(IVehicleModel updatedItem)
        {
            var item = dbSet.Attach(updatedItem);
            item.State = EntityState.Modified;
            await unitOfWork.CommitAsync();
            return updatedItem;
        }
    }
}
