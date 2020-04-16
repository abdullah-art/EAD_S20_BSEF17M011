using Assignment.BAL;
using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EadAssignment3.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateUser(String Login,String Password)
        {
            bool result = UserBO.validateUser(Login, Password);
            var data = new
            {
               success=result
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult RegisterUser(UserDTO user)
        {
            int id = UserBO.save(user);
            bool flag = true;
            if(id==0)
            {
                flag = false;
            }
            user.id = id;
            var data = new
            {
                success = flag
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }
    }
}