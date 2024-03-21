using API.Models;
using API.Models.DTO;

namespace API.Service
{
    public interface IPantheonService
    {
        public bool insertPantheon(PantheonDTO dto);

        public bool updatePantheon(Pantheon pantheon);

        public bool deletePantheon(int id);
        List<Pantheon> GetAllPantheons();
    }
}
