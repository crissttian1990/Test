using System.Threading.Tasks;

namespace WhoozatAPI.Services
{
    public interface ISeedDataService
    {
        Task EnsureSeedData();
    }
}