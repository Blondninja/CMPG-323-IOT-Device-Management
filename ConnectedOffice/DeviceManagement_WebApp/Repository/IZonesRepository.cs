using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {
        object Zone { get; set; }

        Zone GetMostRecentService();
        Task SaveChangesAsync();
        void Update(Zone zone);
    }

}
