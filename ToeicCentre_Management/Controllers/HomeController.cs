using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ToeicCentre_Management.Data;
using ToeicCentre_Management.Models;

namespace ToeicCentre_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly TOIECContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TOIECContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            // Tạo một Dictionary để lưu trữ số lượng bản ghi của các bảng
            var statistics = new Dictionary<string, int>
            {
                { "Số bài thi", _context.Baithis.Count() },
                { "Số câu hỏi", _context.Cauhois.Count() },
                { "Số đề thi", _context.Dethidataos.Count() },
                { "Số sinh viên", _context.Sinhviens.Count() },
                { "Số giáo viên", _context.Giaoviens.Count() },
                { "Số tài liệu học tập", _context.Tailieuhoctaps.Count() },
                { "Số đăng ký thi thử", _context.Dangkythithus.Count() },
                { "Số kết quả thi", _context.Diemthis.Count() }
            };

            // Truyền dữ liệu thống kê sang View
            ViewData["Statistics"] = statistics;
            ViewData["CurrentTime"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
