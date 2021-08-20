using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SACLA.Models.Data;

namespace SACLA.Controllers
{
    [Authorize(Roles = "Author")]
    public class PaperController : Controller
    {
        PaperDbContext paperDbContext = new PaperDbContext();
        // GET: Paper
        public ActionResult Paper()
        {
            //return only papers of the logged in user
            var paper = paperDbContext.Paper.Where
                (pap => pap.paperAbstract == User.Identity.Name);

            return View(paper);
        }
        [AllowAnonymous]
        public ActionResult Papers()
        {
            var papers = paperDbContext.Paper.ToList();




            return View(papers);
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(Paper paper)
        {
            if (ModelState.IsValid)
            {
                paper.paperAbstract = User.Identity.Name;
                paperDbContext.Paper.Add(paper);
                paperDbContext.SaveChanges();



                return RedirectToAction("List");
            }
            else
                ModelState.AddModelError("", "Paper Not Submitted");
            return View();
        }
    }
}

    
