using Backend.Models.DTO;
using Backend.Models;

namespace Backend.Service
{
    public interface IDivineService
    {
        public bool insertDivine(DivineDTO dto, int FKey);

        public bool updateDivine(Divine divine);

        public bool deleteDivine(int id);
        List<Divine> GetAllDivines();

        Divine GetDivine(string name);
    }
}
