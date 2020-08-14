using Microsoft.AspNetCore.Mvc;

namespace SweetShop.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}