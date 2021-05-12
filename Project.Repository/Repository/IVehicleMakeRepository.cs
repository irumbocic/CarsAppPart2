using Project.Model.Common;
using System.Threading.Tasks;

namespace Project.Repository.Repository
{
    public interface IVehicleMakeRepository
    {
        Task<IVehicleMake> CreteAsync(IVehicleMake newItem);
        Task<IVehicleMake> DeleteAsync(int id);
        Task<IVehicleMake> GetAsync(int id);
        void GetListOfMakeNamesAsync();
        Task<IVehicleMake> UpdateAsync(IVehicleMake updatedItem);
    }
}