using System;
using System.Web.Mvc;

namespace MonoCMS.Areas.Backend
{
	public class BackendAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Backend";
			}
		}
		
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
				"Backend_default",
				"Backend/{controller}/{action}/{id}",
				new { controller="Home", action = "Index", id = UrlParameter.Optional },
				new[] { "MonoCMS.Areas.Backend.Controllers" }
			);
		}
	}
}

