using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models.DTOs;
using WebApplication4.Models.EFModels;
using WebApplication4.Models.Repository;

namespace WebApplication4.Models.Service
{
    public class RegisterServices
    {   
        private IRegisterRepository repository;

        public RegisterServices(IRegisterRepository repo)
        {
            repo = repository;
        }

        public void Create(RegisterDTO registerDTO) {
            Register register= new Register();

            //var dataIndb = db.Registers.FirstOrDefault(x => x.Email == register.Email);
            var dataIndb = repository.FindByEmail(register.Email);
            if (dataIndb != null)
            {                           //欄位//  //錯誤訊息
                                        //ModelState.AddModelError("Email", "此信箱已經註冊過");
                throw new Exception("此信箱已經註冊過");
            }
            //由程式直接加入時間
            register.CreateTime = DateTime.Now;
            //db.Registers.Add(register);
            //db.SaveChanges();
            repository.Create(registerDTO);
        }

        public Register Find(int id) 
        {
            Register register = repository.FindById(id);
            if (register == null)
            {
                throw new Exception("找不到指定的紀錄");
            }
            return register;
        }
    }
}