using DeviceManagement_WebApp.Models;
using System.Collections;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        object Device { get; }
        IEnumerable Category { get; }
        IEnumerable Zone { get; set; }

        Device GetMostRecentService();
        Task<object> SaveChangesAsync();
        void Update(Device device);
    }

}
