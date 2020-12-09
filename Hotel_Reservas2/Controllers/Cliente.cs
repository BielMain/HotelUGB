using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Reservation_System.Controllers

public class ClienteController : Controller
{
    // GET: /Cliente/

    public ActionResult Index()
    {
        ViewBag.Controller = "Customer";
        ViewBag.Action = "Index";
        return View("ActionName");
    }
    public ActionResult List()
    {
        ViewBag.Controller = "Customer";
        ViewBag.Action = "List";
        return View("ActionName");
    }

}
}