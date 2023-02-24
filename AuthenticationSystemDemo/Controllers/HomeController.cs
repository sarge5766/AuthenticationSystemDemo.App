using AuthenticationSystemDemo.Models;
using System.Web.Mvc;

namespace AuthenticationSystemDemo.Controllers {
    public class HomeController : Controller {
        User admin;

        public HomeController() {
            admin = new User() {
                Email = "test@test.com",
                Password = "Test@123"
            };
        }

        // GET: Home
        public ActionResult Index() {
            if (Session["Username"] == null) {
                return RedirectToAction("Login");
            }

            return View();
        }

        public ActionResult Login() {

            return View();
        }

        public ActionResult Logout() {
            Session["Username"] = null;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(User user) {
            if (!ModelState.IsValid) {
                return View();
            }

            if(user.Email == admin.Email || user.Password == admin.Password) {
                Session["Username"] = user.Email;

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}