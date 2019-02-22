using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Assignment1_Section1;
using System.Web.Mvc;
using ServiceHost.Models;

namespace WCFServiceHost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult InvokeHTTP()
        {
            Uri httpURI = new Uri("http://localhost:55431/");
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(Assignment1_Section1.SayHello), httpURI);
            host.Open();
            SayHelloProxy proxy = new SayHelloProxy();
            ViewBag.Message=proxy.DoWork("Hello World");
            host.Close();
            return RedirectToAction("Home");
        }

        public ActionResult InvokeTCP()
        {
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(Assignment1_Section1.SayHello));
            host.Open();
            SayHelloProxy proxy = new SayHelloProxy();
            ViewBag.Message = proxy.DoWork("Hello World");
            host.Close();
            return RedirectToAction("Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}