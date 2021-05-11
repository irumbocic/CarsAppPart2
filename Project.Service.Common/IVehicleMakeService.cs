//using Project.Model; // MORAM SKUZITI ZA STO NAM TREBA OVAJ MODEL I MODEL.COMMON --> moram provjeriti!!
using Project.DAL;
using Project.Model.Common;
using Project.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IVehicleMakeService
    {
        public Task<IVehicleMake> UpdateAsync(IVehicleMake updatedItem);
        public Task<IVehicleMake> CreteAsync(IVehicleMake newItem);
        public Task<IVehicleMake> DeleteAsync(int id);
        public Task<IVehicleMake> GetAsync(int id);
        //public Task<IPagedList<T>> FindAsync(IFilter filter, ISort sort, IPaging<T> paging); // OVO DODATI NAKNADNO

        public Task<IEnumerable<IVehicleMake>> GetListOfMakeNamesAsync(); // OVO STAVITI NEGDJE DRUGO?????

    }
}
