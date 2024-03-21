using Backend.Models;
using Backend.Models.DTO;

namespace Backend.Service
{
    public class DivineService : IDivineService
    {
        private readonly DataContext _context;

        public DivineService(DataContext context)
        {
            _context = context;
        }
        public bool deleteDivine(int id)
        {
            _context.Divines.Remove(new Divine() { Id = id });
            return _context.SaveChanges() > 0;
        }

        public List<Divine> GetAllDivines()
        {
            return _context.Divines.ToList();
        }

        public Divine GetDivine(string name)
        {
            var divine = _context.Divines.FirstOrDefault(d => d.Name == name);
            return divine;
                               
        }

        public bool insertDivine(DivineDTO dto, int FKey)
        {
            var divine = new Divine
            {

                Name = dto.Name,
                Description = dto.Description,  
                PantheonId = FKey
            };
            _context.Divines.Add(divine);
            return _context.SaveChanges() > 0;
        }

        public bool updateDivine(Divine divine)
        {
            _context.Divines.Update(divine);
            return _context?.SaveChanges() > 0;
        }
    }
}
