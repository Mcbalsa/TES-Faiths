﻿using Backend.Models.DTO;
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

        [HttpPost(Name = "InsertPantheon")]
        public ActionResult InsertPantehon(PantheonDTO pantheonDTO)
        {
            if (_pantheonService.insertPantheon(pantheonDTO)) return Ok();
            return BadRequest();
        }

        [HttpPut(Name = "UpdatePantheon")]
        public ActionResult UpdatePantheon(Pantheon pantheon)
        {
            if (_pantheonService.updatePantheon(pantheon)) return Ok();
            return BadRequest();
        }


        [HttpDelete(Name = "DeletePantheon")]
        public ActionResult DeletePantheon(int id)
        {
            if (_pantheonService.deletePantheon(id)) return Ok();
            return BadRequest();
        }

        [HttpGet(Name = "GetPantheon")]
        public ActionResult<List<Pantheon>> Get()
        {
            var products = _pantheonService.GetAllPantheons();

            if (products == null) return NotFound();

            return Ok(products);
        }
    }
}