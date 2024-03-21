using Backend.Models.DTO;
using Backend.Models;

namespace Backend.Service
{
   
    public interface IPantheonService
        {
            public bool insertPantheon(PantheonDTO dto);

            public bool updatePantheon(Pantheon pantheon);

            public bool deletePantheon(int id);
            List<Pantheon> GetAllPantheons();

            List<Divine> GetDivines(string pantheon);
       }
    

}

