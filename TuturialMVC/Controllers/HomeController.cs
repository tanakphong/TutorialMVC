using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuturialMVC.Models;

namespace TuturialMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> ls = new List<Product>();
            ls.Add(new Product { Id = 1, Name = "Apple MacBook Pro 15", Desc = "512GB, Touch Bar, Touch ID, Mid 2018", Price = 100900, Url = "https://notebookspec.com/nbs/upload_notebook/20171004-154822_20161028-133122_c.jpg" });
            ls.Add(new Product { Id = 2, Name = "MSI GT75 8RG", Desc = "205TH Titan", Price = 99900, Url = "https://notebookspec.com/nbs/upload_notebook/20180404-135906_c.jpg" });
            ls.Add(new Product { Id = 3, Name = "Acer Predator Helios 500 PH517-51", Desc = "9650", Price = 99900, Url = "https://notebookspec.com/nbs/upload_notebook/20180619-173653_c.jpg" });
            ls.Add(new Product { Id = 3, Name = "DELL Alienware 15 R3", Desc = "W5691002THW10KBL", Price = 94900, Url = "https://notebookspec.com/nbs/upload_notebook/20161102-143120_c.jpg" });
            ls.Add(new Product { Id = 3, Name = "Asus ROG Strix GL503VS", Desc = "EI034T SCAR Edition", Price = 89900, Url = "https://notebookspec.com/nbs/upload_notebook/20171101-132629_c.jpg" });
            return View(ls.ToList());
        }
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        // GET: Home
        public ActionResult Register()
        {
            return View();
        }
    }
}