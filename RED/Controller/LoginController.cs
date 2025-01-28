using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REDMIS.Models;
using REDMIS.DBLayer;

namespace REDMIS.Controllers
{
    public class LoginController : Controller
    {
        DB_Layer DB = new DB_Layer();
        // GET: Login
        public ActionResult Logout()
        {
            return RedirectToAction("UserLogin", "Login");
        }
        public ActionResult UserLogin()
        {
            Login Model = new Login();
            return View(Model);
        }
        [HttpPost]
        public ActionResult UserLogin(Login Model)
        {
            Model.ProcId = 1;
            Model = DB.Proc_CheckUser(Model).FirstOrDefault();
            if (Model.msg == "Success")
            {
                Session["UserId"] = Model.UserId;
                Session["DistrictId"] = Model.DistrictId;
                Session["DivisionId"] = Model.DivisionId;
                Session["ZoneId"] = Model.ZoneId;
                Session["CircleId"] = Model.CircleId;
                Session["UserType"] = Model.UserTypeId;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}