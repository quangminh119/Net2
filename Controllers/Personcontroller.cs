using Microsoft.AspNetCore.Mvc;
using Net2Minh.Models;

namespace Net2Minh.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult CreatePer (Person std)
        {
            string Message =std.MyProperty +"-";
             Message += std.MyProperty1 + "-";
            Message += std.MyProperty12 + "-";
            ViewBag.TT=Message;
            return View();
        }
    }
    
}