using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> ContentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.ContentRepo = contentRepo;
        }
        public ViewResult Index()
        {
            var model = ContentRepo.GetAll();

            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = ContentRepo.GetById(id);

            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CreateByCategoryId(int id)
        {
            ViewBag.CategoryId = id;
            return View();
        }
        [HttpPost]
        public ActionResult CreatebyCategoryId(Content content)
        {
            if (ModelState.IsValid)
            {
                ContentRepo.Create(content);
                return RedirectToAction("Details", "Category", new { id = content.CategoryId });
            }
            return View(content);
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            Content model = ContentRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Content content)
        {
            if (ModelState.IsValid)
            {
                ContentRepo.Update(content);
                return RedirectToAction("Details", "Category", new { id = content.CategoryId });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
           Content model = ContentRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Content content)
        {
            ContentRepo.Delete(content);

            return RedirectToAction("Index");
        }








    }

}
