using Microsoft.AspNetCore.Mvc;
using Net2Minh.Models;

namespace Net2Minh.Controllers
{
    public class StudentCotroller : Controller 
    {
        //khai báo các action để làm việc với các object 
        //thao tác CRUD
        public IActionResult Index
        {
            get
            {
                ViewBag.Thongtin = "gửi dữ liệu qua Viewbag";
                //khoi tao list student 
                List<Student> stdList = new List<Student>()
            {
                new Student {StudentID =1, StudentName= "Nguyen van A",}
            };
                ViewData["Student"] = stdList;
                TempData["Thông báo"] = "gui du lieu qua TempData";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Student std)
        {
            string Message = std.StudentID + "-";
            Message += std.StudentName + "-";
            Message += std.Age;
            ViewBag.TT = Message;
            return View();

        }
        
    }
}