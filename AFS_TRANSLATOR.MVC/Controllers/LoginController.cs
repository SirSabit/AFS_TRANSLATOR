using AFS_TRANSLATOR.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AFS_TRANSLATOR.MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.NickName == "Admin" && model.Password == "Password")
                {
                    var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,model.NickName)
                };
                    var userIdentity = new ClaimsIdentity(claims, "GlomilCookie");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
