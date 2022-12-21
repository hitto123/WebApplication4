using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models.DTOs;

namespace WebApplication4.Models.Service
{
    public interface IMemberRepository
    {
        void Create(MemberCreateDTO dto);
    }
}