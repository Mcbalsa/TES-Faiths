using Backend.Models.DTO;
using Backend.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Backend.Service
{
    public class PantheonService : IPantheonService
    {

        private readonly DataContext _context;
        public PantheonService(DataContext context)
        {
            _context = context;
        }

        public bool deletePantheon(int id)
        {
            _context.Pantheons.Remove(new Pantheon() { Id = id });
            return _context.SaveChanges() > 0;
        }

        public bool insertPantheon(PantheonDTO dto)
        {
            var pantheon = new Pantheon
            {

                Name = dto.Name,
                
            };

            
            _context.Pantheons.Add(pantheon);
            return _context.SaveChanges() > 0;
        }

        public bool updatePantheon(Pantheon pantheon)
        {
            _context.Pantheons.Update(pantheon);
            return _context?.SaveChanges() > 0;
        }

        public List<Pantheon> GetAllPantheons()
        {
            return _context.Pantheons.ToList();
        }

        public List<Divine> GetDivines(string pantheon)
        {

            
            var pantheonId = _context.Pantheons
                                     .Where(p => p.Name == pantheon)
                                     .Select(p => p.Id)
                                     .FirstOrDefault();

            if (pantheonId == 0)
            {
                
                return new List<Divine>();
            }

           
            var divines = _context.Divines
                                  .Where(d => d.PantheonId == pantheonId)
                                  .ToList();

            return divines;
        }
    }
}
