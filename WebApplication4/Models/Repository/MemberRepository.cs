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
        private AppDbContext db = new AppDbContext();
        public MemberRepository()
        {
            db = new AppDbContext();
        }
        public void Create(MemberCreateDTO memberCreateDTO)
        {
            Member member = new Member
            {
                Name = memberCreateDTO.Name,
                Account = memberCreateDTO.Account,
                Password = memberCreateDTO.Password,
                Cellphone = memberCreateDTO.Cellphone
            };
            db.Members.Add(member);
            db.SaveChanges();

        }

    }
}