using Microsoft.AspNetCore.Mvc;

namespace LoginSystem.Controllers {
    public class AccountController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
