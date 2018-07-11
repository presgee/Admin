using ManageUser.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.Mvc;

namespace ManageUser.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult ViewEntries()
        {
            //ViewBag.Message = "Your products page.";
            //RootObject entries = new RootObject();
            //string urlAction = String.Format("/hansard/entries/");
            //entries = await GetWSObject<RootObject>(urlAction);
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = client.GetAsync("http://staging.odekro.org:8000/api/v0.1/hansard/entries/").Result;
                string stringData = response.Content.ReadAsStringAsync().Result;
                RootObject data = JsonConvert.DeserializeObject<RootObject>(stringData);
                // return data;

                return View(data);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        public ActionResult Index()
        {
            return View();
        }


        //    [ActionName("about-us")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }


        [HandleError(View = "Error")]
        public ActionResult Contact()
        {
            //  throw new StackOverflowException();
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult SerialNumber(string letterCase)
        {
            // get user IP Address
            var ip = Request.UserHostAddress;

            var serial = "DFJGAJGHDHFKAGFA";

            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
        }
    }
}