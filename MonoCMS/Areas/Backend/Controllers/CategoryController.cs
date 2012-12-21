using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using PetaPoco;
using MonoCMS.Models;

namespace MonoCMS.Areas.Backend.Controllers
{
	public class CategoryController : Controller
	{
		public ViewResult Index ()
		{
			var db = new PetaPoco.Database("MonoCMS");
			var categories = db.Fetch<Category>("SELECT category_name FROM category");
			return View(categories);
			//return View();
		}
	}
}

