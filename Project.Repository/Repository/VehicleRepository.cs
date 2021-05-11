using Microsoft.EntityFrameworkCore;
using Project.DAL;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository
{
    public class VehicleRepository<T> : IVehicleRepository<T> where T : class
    {
        private readonly IUnitOfWork unitOfWork;
        internal DbSet<T> dbSet;

        public VehicleRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork"); // MOzda negdje drugo staviti?
            this.unitOfWork = unitOfWork;
            this.dbSet = unitOfWork.Db.Set<T>();
        }

        public async Task<T> CreteAsync(T newItem)
        {
            await dbSet.AddAsync(newItem);
            await unitOfWork.CommitAsync();
            return newItem;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var deleteItem = await dbSet.FindAsync(id);
            unitOfWork.Db.Remove(deleteItem);
            await unitOfWork.CommitAsync();
            return deleteItem;
        }

        public async Task<T> GetAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }


        public async Task<T> UpdateAsync(T updatedItem)
        {
            var item = dbSet.Attach(updatedItem);
            item.State = EntityState.Modified;
            await unitOfWork.CommitAsync();
            return updatedItem;
        }
        public Task<IEnumerable<T>> GetListOfMakeNamesAsync() // NAKNADNO SREDITI!!!!
        {
            throw new NotImplementedException();
        }
    }
}
