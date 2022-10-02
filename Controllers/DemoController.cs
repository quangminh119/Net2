using Microsoft.AspNetCore.Mvc;
using Net2Minh.Models.Process;

namespace Net2Minh.Controllers
{
    public class DemoController : Controller
    {
    //khai bao theo huong doi tuong class StringProcess
        StringProcess strPro = new StringProcess()
        {
            public IActionResult XuLyChuoi()
            {
                return View();
            }
            [HttpPost]
            public IActionResult XuLyChuoi(string strInput)
            {
                strInput = "Lap trinh Net2";
            //strInput.SuString(0,1) => L
            //strInput.SubString(1) => ap trinh Net 2
                ViewBag.thongtin = strPro.RemoveRemainingWhiteSpace(strInput);
                ViewBag.thongtin = strPro.LowerToUpper (strInput);
                return View();
            }
        }

    }
}