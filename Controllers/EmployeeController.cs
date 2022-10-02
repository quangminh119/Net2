using Microsoft.AspNetCore.Mvc;
using Net2Minh.Models;

namespace Net2Minh.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult CreateEmp (Employee std)
        {
            string Message =std.EmployeeID + "-";
            Message += std.EmployeeName + "-";
            Message += std.Number + "-";
            ViewBag.TT=Message;
            return View();
        }
    }
    
}