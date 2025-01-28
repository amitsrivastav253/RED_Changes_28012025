using REDMIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REDMIS.DBLayer;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Sockets;
using System.Net;


namespace REDMIS.Controllers
{
    [SessionCheck]
    public class REDController : Controller
    {
        // GET: RED
        DB_Layer DB = new DB_Layer();
        public ActionResult ProjectReport()
        {
            OldProjectReport Model = new OldProjectReport();
            Model.DistrictId = Convert.ToInt32(Session["DistrictId"].ToString());
            Model.UserTypeId = Convert.ToInt32(Session["UserType"].ToString());
            return View(Model);
        }
        [HttpPost]
        public ActionResult ProjectReport(OldProjectReport Model)
        {
            Model.DistrictId = Convert.ToInt32(Session["DistrictId"].ToString());
            Model.UserTypeId = Convert.ToInt32(Session["UserType"].ToString());
            Model.ProcId = 1;
            var list = DB.Proc_OldProjectReport(Model).ToList();
            if (list.Count > 0)
            {
                ViewBag.Listdata = list;
            }
            else
            {
                ViewBag.Listdata = null;
            }
            return View(Model);
        }

        #region AmitSrivastava

        public ActionResult ProjectRptDrill()
        {

            OldProjectReport Model = new OldProjectReport();
            Model.DistrictId = Convert.ToInt32(Session["DistrictId"].ToString());
            if (Request.QueryString["WorkId"] != null)
            {
                Model.WorkId = Convert.ToInt32(Request.QueryString["WorkId"].ToString());
                Model.WorkTypeId = Convert.ToInt32(Request.QueryString["WorkTypeId"].ToString());
            }
            if (Model.WorkTypeId == 1)
            {
                ViewBag.WorkTypeId = " भवन ";
                Model.ProcId = 2;
            }
            if (Model.WorkTypeId == 3)
            {
                ViewBag.WorkTypeId = " पुलिया और  संपर्क मार्ग ";
                Model.ProcId = 3;
            }

            var list = DB.Proc_OldProjectReport(Model).ToList();
            if (list.Count > 0)
            {
                ViewBag.listdata = list;
            }
            else
            {
                ViewBag.listdata = null;
            }
            return View();
        }

        #endregion
    }
}