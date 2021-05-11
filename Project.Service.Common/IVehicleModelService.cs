using Project.DAL;
using Project.Model.Common;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleModelService
    {
        public Task<IVehicleModel> UpdateAsync(IVehicleModel updatedItem);
        public Task<IVehicleModel> CreteAsync(IVehicleModel newItem);
        public Task<IVehicleModel> DeleteAsync(int id);
        public Task<IVehicleModel> GetAsync(int id);
        //public Task<IPagedList<T>> FindAsync(IFilter filter, ISort sort, IPaging<T> paging); // OVO DODATI NAKNADNO

    }
}
