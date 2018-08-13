using AbstractDesignPattern.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbstractDesignPattern.Controllers
{
    public class BaseController : Controller
    {
        private Ilog _ilog;

        public BaseController()
        {
            _ilog = Logger.Logger.GetInstance;
        }


        protected override void OnException(ExceptionContext filterContext)
        {

            _ilog.LogException(filterContext.Exception.ToString());
            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);

        }
    }
}