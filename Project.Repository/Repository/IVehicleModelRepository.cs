using Project.Model.Common;
using System.Threading.Tasks;

namespace Project.Repository.Repository
{
    public interface IVehicleModelRepository
    {
        Task<IVehicleModel> CreteAsync(IVehicleModel newItem);
        Task<IVehicleModel> DeleteAsync(int id);
        Task<IVehicleModel> GetAsync(int id);
        Task<IVehicleModel> UpdateAsync(IVehicleModel updatedItem);
    }
}