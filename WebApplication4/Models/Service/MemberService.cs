using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models.DTOs;

namespace WebApplication4.Models.Service
{
    public class MemberService
    {
        private IMemberRepository repository;
        public MemberService(IMemberRepository repo)
        {
            this.repository = repo;
        }

        public void Create(MemberCreateDTO dto)
        {
            // 驗證帳號是否唯一

            // 建立記錄
            repository.Create(dto);
        }
    }
}