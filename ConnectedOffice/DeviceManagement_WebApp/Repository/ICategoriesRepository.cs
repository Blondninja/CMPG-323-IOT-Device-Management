using DeviceManagement_WebApp.Models;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        object Category { get; }

        Category GetMostRecentService();
        Task SaveChangesAsync();
        void Update(Category category);
    }

}
