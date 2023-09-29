using Microsoft.AspNetCore.Mvc;

namespace eticaret34.ViewComponents
{
	public class RealtedList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
