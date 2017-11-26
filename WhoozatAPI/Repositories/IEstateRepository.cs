using System.Linq;
using WhoozatAPI.Entities;

namespace WhoozatAPI.Repositories
{
    public interface IEstateRepository
    {
        void Add(Estate item);
        void Delete(int id);
        IQueryable<Estate> GetAll();
        Estate GetSingle(int id);
        bool Save();
        void Update(Estate item);
    }
}