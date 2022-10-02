using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Net2Minh.Models;

namespace Net2Minh.Controllers;

public class HomeController : Controller
{
   GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

  public IActionResult Index()
  {
   

    return View();
  }

  public IActionResult Create()
  {
    return View();
  }
  [HttpPost]
  public IActionResult Create(string Fullname)
  {
    String Message = "Hello" + Fullname;
    //sử dụng ViewBag để gửi dữ liệu từ controller 
    ViewBag.ThongBao = Message;
    return View();
  }
  public IActionResult GiaiPhuongTrinh()
        {
           
            return View();

        }
        [HttpPost]
        public IActionResult GiaiPhuongTrinhBacNhat(string heSoa, string heSob, string heSoc)
        {
          string thongBaoBacNhat
          return View();


        }
}  