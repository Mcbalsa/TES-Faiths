using Backend.Models.DTO;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Backend.Service;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class DivineController : ControllerBase { 

            private readonly IDivineService _divineService;

        public DivineController (IDivineService divineService)
        {
            _divineService = divineService;
        }
    
        [HttpPost("Insert", Name = "InsertDivine")]
        public ActionResult InsertDivine(DivineDTO divineDTO, int FKey)
        {
            if (_divineService.insertDivine(divineDTO, FKey)) return Ok();
            return BadRequest();
        }

        [HttpPut("Update", Name = "UpdateDivine")]
        public ActionResult UpdateDivine(Divine divine)
        {
            if (_divineService.updateDivine(divine)) return Ok();
            return BadRequest();
        }


        [HttpDelete("Delete", Name = "DivineDivine")]
        public ActionResult DeleteDivine(int id)
        {
            if (_divineService.deleteDivine(id)) return Ok();
            return BadRequest();
        }

        [HttpGet("GetAll", Name = "GetAllDivines")]
        public ActionResult<List<Pantheon>> Get()
        {
            var divine = _divineService.GetAllDivines();

            if (divine == null) return NotFound();

            return Ok(divine);
        }

        [HttpGet("GetDivine", Name = "GetDivine")]
        public ActionResult<List<Divine>> GetDivine(string name)
        {
            var divine = _divineService.GetDivine(name);

            if (divine == null) return NotFound();

            return Ok(divine);
        }
    }
}

