using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonoCMS.Models;

namespace MonoCMS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
			/**var category = new Category();
			category.CategoryName = "Manoj";
			var db = new PetaPoco.Database("MonoCMS");
			db.Save(category);**/
			return View ();
        }
		 
    }
}
