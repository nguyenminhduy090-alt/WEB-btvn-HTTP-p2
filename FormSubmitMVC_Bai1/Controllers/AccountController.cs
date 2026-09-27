using Microsoft.AspNetCore.Mvc;

namespace FormSubmitMVC_Bai1.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                ViewBag.Message = "Login success";
            }
            else
            {
                ViewBag.Message = "Login failed";
            }

            return View();
        }
    }
}