using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicCRUD.Models;

namespace BasicCRUD.Controllers
{
    public class UserController : Controller
    {
       public ActionResult Details(int id)
        {

            //User user = new User()
            //{
            //    Id = 1,
            //    FirstName = "kamal",
            //    LastName = "lamgade",
            //    Prefix = "mr",
            //    ProfileName = "klamgade",
            //    DateCreated = DateTime.UtcNow
            //};

            UserContext userContext = new UserContext();
            Users user = userContext.Users.Single(x => x.Id == id);
            return View(user);
        }
    }
}