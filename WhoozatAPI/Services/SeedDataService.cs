using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhoozatAPI.Entities;

namespace WhoozatAPI.Services
{
    public class SeedDataService : ISeedDataService
    {
        private WhoozatDBContext _context;

        public SeedDataService(WhoozatDBContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            _context.Database.EnsureCreated();

            _context.Estates.RemoveRange(_context.Estates);
            _context.SaveChanges();

            Estate estate = new Estate();
            estate.active = 1;
            estate.address = "Calle falsa 123";
            estate.city = "Dublin";
            estate.creationDate = DateTime.Now;
            estate.Id = Guid.NewGuid();
            estate.idCountry = 1;
            estate.idEstate = 1;
            estate.idUserEstate = 1;
            estate.lastUpdate = DateTime.Now;
            estate.name = "Test";
            estate.phone = "963258741";
            estate.photo = "";
            estate.postalCode = "E11 1BX";
            estate.state = "tate";
            estate.unitsNumber = 52;

            _context.Add(estate);

            Estate estate2 = new Estate();
            estate2.active = 1;
            estate2.address = "Calle falsa 123";
            estate2.city = "Dublin";
            estate2.creationDate = DateTime.Now;
            estate2.Id = Guid.NewGuid();
            estate2.idCountry = 1;
            estate2.idEstate = 2;
            estate2.idUserEstate = 1;
            estate2.lastUpdate = DateTime.Now;
            estate2.name = "Test";
            estate2.phone = "963258741";
            estate2.photo = "";
            estate2.postalCode = "E11 1BX";
            estate2.state = "tate";
            estate2.unitsNumber = 52;

            _context.Add(estate2);

            await _context.SaveChangesAsync();
        }

    }
}
