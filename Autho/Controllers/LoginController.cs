using Autho.Models;
using Autho.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autho.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Login(UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
            Boolean success = securityService.Authenticate(userModel);

            if (success)
            {
                Session["user"] = userModel;
                return View("LoginSuccess", userModel);
            }
            else
            {
                Session.Clear();
                return View("LoginFailure");
            }
        }
        [CustomAuthorization]
        public ActionResult onPrivateURL()
        {
            return Content("Private information here. Only a logged in user should be able to see this message");
        }
    }
}