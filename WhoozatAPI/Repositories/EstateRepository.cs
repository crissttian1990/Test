using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhoozatAPI.Entities;

namespace WhoozatAPI.Repositories
{
    public class EstateRepository : IEstateRepository
    {
        private WhoozatDBContext _context;

        public EstateRepository(WhoozatDBContext context)
        {
            _context = context;
        }

        public IQueryable<Estate> GetAll()
        {
            return _context.Estates;
        }

        public Estate GetSingle(int id)
        {
            return _context.Estates.FirstOrDefault(x => x.idEstate == id);
        }

        public void Add(Estate item)
        {
            _context.Estates.Add(item);
        }

        public void Delete(int id)
        {
            Estate Estate = GetSingle(id);
            _context.Estates.Remove(Estate);
        }

        public void Update(Estate item)
        {
            _context.Estates.Update(item);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

    }
}
