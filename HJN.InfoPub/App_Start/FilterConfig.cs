using HJN.InfoPub.Core.Mode;
using System;
using System.Web;
using System.Web.Mvc;

namespace HJN.InfoPub
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogExceptionAttribute());
            filters.Add(new JsonExceptionAttribute());
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class LogExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                string msgTemplate = "在执行 controller[{0}] 的 action[{1}] 时产生异常";
                // LogManager.GetLogger("LogExceptionAttribute").Error(string.Format(msgTemplate, controllerName, actionName), filterContext.Exception);

            }

            if (filterContext.Result is JsonResult)
            {
                //当结果为json时，设置异常已处理
                filterContext.ExceptionHandled = true;
            }
            else
            {
                //否则调用原始设置
                base.OnException(filterContext);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class JsonExceptionAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                //返回异常JSON
                filterContext.Result = new JsonResult
                {
                    //Data = new { Success = false, Message = filterContext.Exception.Message }
                    Data = BaseJsonResult.BuildResult(0, "exception", filterContext.Exception.Message)
                };
            }
        }
    }
}
