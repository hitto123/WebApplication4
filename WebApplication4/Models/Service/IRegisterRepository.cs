using System.Collections.Generic;
using WebApplication4.Models.DTOs;
using WebApplication4.Models.EFModels;

namespace WebApplication4.Models.Service
{
    public interface IRegisterRepository
    {
        void Create(RegisterDTO registerDTO);
        Register FindByEmail(string email);
        Register FindById(int id);
        List<Register> GetAll();
    }
}