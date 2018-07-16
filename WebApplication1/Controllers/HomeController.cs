using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();


        public ActionResult Index()
        {
        
             var result = from a in db.Companies
                          join b in db.Products on a.ID equals b.FK_Companies_Products
                          orderby a.ID, b.Name
                          select new ProductsCompaniesViewModel { company = a, product = b };

            return View(result.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}