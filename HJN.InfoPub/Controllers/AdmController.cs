using HJN.InfoPub.Core;
using HJN.InfoPub.Core.Mode;
using HJN.InfoPub.Core.Service;
using HJN.InfoPub.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YueWen.Utility.Common;

namespace HJN.InfoPub.Web.Controllers
{
    public class AdmController : BaseAdmController
    {
        MenuService mservice = new MenuService();
        // GET: AdminCommon
        public ActionResult Index()
        {
            string db = AppConfig.Instance.GetByKey("db");
            return View();
        }
    }

    public class Process
    {
        public static bool Execute(Action action)
        {
            try
            {
                action.Invoke();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
            }
        }
    }
}