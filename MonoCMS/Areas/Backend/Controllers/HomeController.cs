using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace MonoCMS.Areas.Backend.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index ()
		{
			return View();
		}

		public ViewResult Test ()
		{
			return View();
		}
	}
}

