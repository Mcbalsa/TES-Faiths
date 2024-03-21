using Backend.Models.DTO;
using Backend.Models;

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
                //Divines = dto.Divines,
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
    }
}
