using Autho.Models;
using Autho.Services.Business;
using System;
using System.Web.Mvc;

namespace Autho.Controllers
{
    internal class CustomAuthorizationAttribute : FilterAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            SecurityService securityService = new SecurityService();
            UserModel user =(UserModel) filterContext.HttpContext.Session["user"];
            bool success = false;
            if(user!=null)
                success = securityService.Authenticate(user);
            if (success)
            {
                //logged in successfully
            }
            else
            {
                filterContext.Result = new RedirectResult("/login");
            }
        }
    }
}