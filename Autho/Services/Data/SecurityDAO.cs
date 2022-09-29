using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autho.Models;

namespace Autho.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            return user.Username == "admin" && user.Password == "123";
           
        }
    }
}