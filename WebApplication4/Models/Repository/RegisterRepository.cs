using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models.DTOs;
using WebApplication4.Models.EFModels;
using WebApplication4.Models.Service;

namespace WebApplication4.Models.Repository
{
    public class RegisterRepository : IRegisterRepository
    {
        private AppDbContext db = new AppDbContext();

        public void Create(RegisterDTO registerDTO)
        {
            Register register = new Register
            {
                id = registerDTO.Id,
                Name = registerDTO.Name,
                Email = registerDTO.Email,
                CreateTime = DateTime.Now
            };

        }

        public Register FindByEmail(string email)
        {
            return db.Registers.FirstOrDefault(x => x.Email == email); ;
        }
        public Register FindById(int id)
        {
            return db.Registers.Find(id);
        }
        public List<Register> GetAll()
        {
            return db.Registers.ToList();
        }
    }
}