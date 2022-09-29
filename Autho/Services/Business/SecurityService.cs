using Autho.Models;
using Autho.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autho.Services.Business
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            return securityDAO.FindByUser(user);
        }
    }
}