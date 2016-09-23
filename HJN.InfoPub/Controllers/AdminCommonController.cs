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
    public class AdminCommonController : BaseController
    {
        MenuService mservice = new MenuService();
        // GET: AdminCommon
        public ActionResult Index()
        {
            string db = AppConfig.Instance.GetByKey("db");
            return View();
        }

        public ActionResult AddMenu()
        {
            return View();
        }

        [HttpPost]
        [JsonException]
        public JsonResult MenuaddPost(FormCollection form)
        {
            InfoPub.Entity.infopub_admin_menu adminmenu = new Entity.infopub_admin_menu();
            ModelBindHelper.BindPropertyValue<infopub_admin_menu>(adminmenu, form);

            mservice.Add(adminmenu);

            BaseJsonResult json = BaseJsonResult.BuildResult(1, "", "");
            return Json(json);
        }

        public ActionResult MenuEdit()
        {
            string idx = Request["idx"];
            infopub_admin_menu adminMenu = mservice.Get(int.Parse(idx));
            ViewBag.menuinfo = adminMenu;
            string ztreeData= mservice.GetZtreeMenuData4Parent(int.Parse(idx));
            ViewBag.ztreedata = new MvcHtmlString(ztreeData);
            return View();
        }

        [HttpPost]
        [JsonException]
        public JsonResult MenuEdit(FormCollection form)
        {
            string idx = Request["idx"];
            infopub_admin_menu adminMenu = mservice.Get(int.Parse(idx));
            ModelBindHelper.BindPropertyValue<infopub_admin_menu>(adminMenu, form);
            mservice.Update(adminMenu);

            BaseJsonResult json = BaseJsonResult.BuildResult(1, "", "");
            return Json(json);
        }

        public ActionResult ShowMenuList()
        {
            PagedModel pm = mservice.GetList(1, 500, "  1=1");
            List<infopub_admin_menu> list = pm.Data as List<infopub_admin_menu>;
            ViewBag.list = list;

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