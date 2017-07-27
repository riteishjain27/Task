using System.Web.Mvc;
using Assignment.InfraStructure.Service;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userService)
        {
            this._userService = userService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserDetail(string userName)
        {
            var model = this._userService.GetUserDetail(userName);

            return View("UserDetail", model);
        }
    }
}

