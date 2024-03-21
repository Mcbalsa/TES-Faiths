using Backend.Models.DTO;
using Backend.Models;
using Backend.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantheonController : ControllerBase
    {
        private readonly IPantheonService _pantheonService;

        public PantheonController(IPantheonService pantheonService)
        {
            _pantheonService = pantheonService;
        }

        [HttpPost("Insert", Name = "InsertPantheon")]
        public ActionResult InsertPantehon(PantheonDTO pantheonDTO)
        {
            if (_pantheonService.insertPantheon(pantheonDTO)) return Ok();
            return BadRequest();
        }

        [HttpPut("Update", Name = "UpdatePantheon")]
        public ActionResult UpdatePantheon(Pantheon pantheon)
        {
            if (_pantheonService.updatePantheon(pantheon)) return Ok();
            return BadRequest();
        }


        [HttpDelete("Delete", Name = "DeletePantheon")]
        public ActionResult DeletePantheon(int id)
        {
            if (_pantheonService.deletePantheon(id)) return Ok();
            return BadRequest();
        }

        [HttpGet("GetAll", Name = "GetAllPantheons")]
        public ActionResult<List<Pantheon>> Get()
        {
            var pantheons = _pantheonService.GetAllPantheons();

            if (pantheons == null) return NotFound();

            return Ok(pantheons);
        }

        [HttpGet("GetPantheon", Name = "GetPantheon")]
        public ActionResult<List<Divine>> GetPantheon(string name)
        {
            var pantheons = _pantheonService.GetDivines(name);

            if (pantheons == null) return NotFound();

            return Ok(pantheons);
        }
    }
}
