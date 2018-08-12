using SingeltonApplication.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingeltonApplication.Controllers
{
    public class BaseController : Controller
    {

        private Ilog _ILog;
        public BaseController()
        {
            _ILog = Logger.Logger.GetInstance;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            _ILog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}