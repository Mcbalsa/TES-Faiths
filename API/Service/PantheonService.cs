﻿using API.Models.DTO;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Service
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
            _context.Pantheon.Remove(new Pantheon() { Id = id });
            return _context.SaveChanges() > 0;
        }

        public bool insertPantheon(PantheonDTO dto)
        {
            var pantheon = new Pantheon
            {
                Name = dto.Name,
                //Divines = dto.Divines,
            };
            _context.Pantheon.Add(pantheon);
            return _context.SaveChanges() > 0;
        }

        public bool updatePantheon(Pantheon pantheon)
        {
            _context.Pantheon.Update(pantheon);
            return _context?.SaveChanges() > 0;
        }
    }
}