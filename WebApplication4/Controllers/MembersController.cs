using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models.EFModels;
using WebApplication4.Models.Repository;
using WebApplication4.Models.Service;
using WebApplication4.Models.VM;

namespace WebApplication4.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        private IMemberRepository repository;
        public MembersController()
        {
            repository = new MemberRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Members/Details/5
       

        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        [HttpPost]
        public ActionResult Create(MemberCreateVM model)
        {
            try
            {
                new MemberService(repository).Create(model.ToDTO());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(model);

        }

        // GET: Members/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Members/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Members/Delete/5
        
    }
}
