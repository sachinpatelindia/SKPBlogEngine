using Microsoft.AspNetCore.Mvc;
using SKPBlogEngine.Web.Models;
using SKPBlogEngine.Web.System;
using System.Diagnostics;

namespace SKPBlogEngine.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRepository<Member> _memberRepository;
        public HomeController(ILogger<HomeController> logger, IRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var members=_memberRepository.Table.ToList();
            return View(members);
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