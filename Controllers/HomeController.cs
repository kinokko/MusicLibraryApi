using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers {
  public class HomeController : Controller {
    public IActionResult Index () {
      return new JsonResult("Hello world");
    }
  }
}