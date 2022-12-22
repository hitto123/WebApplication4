using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models.DTOs;
using WebApplication4.Models.EFModels;
using WebApplication4.Models.Service;

namespace WebApplication4.Models.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private AppDbContext db;
        public MemberRepository()
        {
            db = new AppDbContext();
        }
        public void Create(MemberCreateDTO dto)
        {
            Member member = new Member
            {  
				Name = dto.Name,
                Account = dto.Account,
                Password = dto.Password,
                Cellphone = dto.Cellphone
            };
            db.Members.Add(member);
            db.SaveChanges();

        }

    }
}