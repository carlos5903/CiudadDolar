using Exceptionless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UDEOExceptionless.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            // Submit logs
            ExceptionlessClient.Default.SubmitLog("Logging made easy");

            // You can also specify the log source and log level.
            // We recommend specifying one of the following log levels: Trace, Debug, Info, Warn, Error
            ExceptionlessClient.Default.SubmitLog(typeof(InvalidProgramException).FullName, "This is so easy", "Info");
            ExceptionlessClient.Default.CreateLog(typeof(InvalidProgramException).FullName, "This is so easy", "Info").AddTags("CiudadDelDolla").Submit();

            // Submit feature usages
            ExceptionlessClient.Default.SubmitFeatureUsage("MyFeature");
            ExceptionlessClient.Default.CreateLog(typeof(InvalidProgramException).FullName, "sss", Exceptionless.Logging.LogLevel.Info).AddTags("CiudadDelDolla").Submit();

            // Submit a 404
            ExceptionlessClient.Default.SubmitNotFound("/somepage");
            ExceptionlessClient.Default.CreateNotFound("/somepage").AddTags("CiudadDelDolla").Submit();
            return View();
        }
    }
}
