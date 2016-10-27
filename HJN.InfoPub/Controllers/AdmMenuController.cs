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
    public class AdmMenuController : BaseAdmController
    {
        MenuService mservice = new MenuService();
        // GET: AdmMenu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuAdd()
        {
            return View();
        }

        [HttpPost]
        [JsonException]
        public JsonResult MenuaddPost(FormCollection form)
        {
            admin_menu adminmenu = new admin_menu();
            ModelBindHelper.BindPropertyValue<admin_menu>(adminmenu, form);

            mservice.Add(adminmenu);

            BaseJsonResult json = BaseJsonResult.BuildResult(1, "", "");
            return Json(json);
        }

        public ActionResult MenuEdit()
        {
            string idx = Request["idx"];
            admin_menu adminMenu = mservice.Get(int.Parse(idx));
            ViewBag.menuinfo = adminMenu;
            string ztreeData = mservice.GetZtreeMenuData4Parent(int.Parse(idx));
            ViewBag.ztreedata = new MvcHtmlString(ztreeData);
            return View();
        }

        [HttpPost]
        [JsonException]
        public JsonResult MenuEdit(FormCollection form)
        {
            string idx = Request["idx"];
            admin_menu adminMenu = mservice.Get(int.Parse(idx));
            ModelBindHelper.BindPropertyValue<admin_menu>(adminMenu, form);
            mservice.Update(adminMenu);

            BaseJsonResult json = BaseJsonResult.BuildResult(1, "", "");
            return Json(json);
        }

        public ActionResult MenuShowList()
        {
            PagedModel pm = mservice.GetList(1, 500, "  1=1");
            List<admin_menu> list = pm.Data as List<admin_menu>;
            ViewBag.list = list;

            return View();
        }

        public ActionResult MenuManage()
        {
            return View();
        }
    }
}