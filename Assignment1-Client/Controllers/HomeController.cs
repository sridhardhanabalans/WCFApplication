using Assignment1_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace WCFClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["Tag"]!=null)
            {
                ViewBag.Message = TempData["Tag"].ToString();
            }
            return View();
        }

        public ActionResult InvokeHTTP()
        {
            Assignment1_Client.SayHello.SayHelloClient client = new Assignment1_Client.SayHello.SayHelloClient("BasicHttpBinding_ISayHello");
            TempData["Tag"] = client.DoWork("Folks - Fetched through http binding");
            return RedirectToAction("Index");
        }

        public ActionResult InvokeTCP()
        {
            Assignment1_Client.SayHello.SayHelloClient client = new Assignment1_Client.SayHello.SayHelloClient("NetTcpBinding_ISayHello");
            TempData["Tag"] = client.DoWork("Folks - Fetched through tcp binding");
            return RedirectToAction("Index");
        }

        public ActionResult JobOpenings()
        {
            Assignment1_Client.SayHello.SayHelloClient client = new Assignment1_Client.SayHello.SayHelloClient("BasicHttpBinding_ISayHello");
            List<JobOpenings> openings = new List<JobOpenings>();
            var response = client.OpeningJobs();
            foreach (var item in response)
            {
                JobOpenings opening = new JobOpenings();
                opening.opening = item.Value;
                opening.role = item.Key;
                openings.Add(opening);
            }
            return View(openings);
        }

        public ActionResult JobOpeningsByRole(string role)
        {
            Assignment1_Client.SayHello.SayHelloClient client = new Assignment1_Client.SayHello.SayHelloClient("BasicHttpBinding_ISayHello");
            JobOpenings openings = new JobOpenings();
            openings.role = role;
            openings.opening = client.OpeningJobsByRole(role);
            return View(openings);
        }
    }
}