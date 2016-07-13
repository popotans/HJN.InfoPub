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
    public class AdminCommonController : Controller
    {
        // GET: AdminCommon
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddMenu()
        {
            return View();
        }

        [HttpPost]
        public JsonResult MenuaddPost(FormCollection form)
        {
            InfoPub.Entity.infopub_admin_menu adminmenu = new Entity.infopub_admin_menu();
            ModelBindHelper.BindPropertyValue<infopub_admin_menu>(adminmenu, form);

            MenuService mservice = new MenuService();
            mservice.Add(adminmenu);

            BaseJsonResult json = BaseJsonResult.BuildResult(1, "", "");
            return Json(json);
        }

        public ActionResult ShowMenuList()
        {
            return View();
        }
    }
}