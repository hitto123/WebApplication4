using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models.DTOs;
using WebApplication4.Models.EFModels;
using WebApplication4.Models.Repository;
using WebApplication4.Models.Service;

namespace WebApplication4.Controllers
{
    public class RegistersController : Controller
    {
        //private Model1 db = new Model1();

        // GET: Registers
        private IRegisterRepository repository;

        public RegistersController()
        {
            repository=new RegisterRepository();
        }
        public ActionResult Index()
        {
            var data = new RegisterRepository().GetAll();
            return View(data);
        }

        // GET: Registers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            try
            {
                var data = new RegisterRepository().GetAll();
                return View(data);
            }
            catch (Exception ex) 
            {
                return HttpNotFound();
            }
           
                
            
           
        }

        // GET: Registers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registers/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Email")] Register register)
        {
            try
            {
                //驗證Email
                //var dataIndb = db.Registers.FirstOrDefault(x => x.Email == register.Email);
                //if (dataIndb != null)
                //{                           //欄位//  //錯誤訊息
                //    //ModelState.AddModelError("Email", "此信箱已經註冊過");
                //    throw new Exception("此信箱已經註冊過");
                //}
                ////由程式直接加入時間
                //register.CreateTime = DateTime.Now;
                //db.Registers.Add(register);
                //db.SaveChanges();
                new RegisterRepository().Create(register.EntityToDTO());
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            if (ModelState.IsValid)
            {
               
                return RedirectToAction("Index");
            }

            return View(register);
           
        }

       
     
    }
}
