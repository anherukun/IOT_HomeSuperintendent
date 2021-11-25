using IOT_HomeSuperintendent.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOT_HomeSuperintendent.Controllers
{
    public class IOTDeviceController : Controller
    {
        // GET: IOTDeviceController
        public ActionResult Index()
        {
            ViewData["devices"] = RepoIOTDevice.Get();
            return View();
        }

        // GET: IOTDeviceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}
