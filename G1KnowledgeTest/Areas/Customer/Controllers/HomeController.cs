using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G1KnowledgeTest.Models;
using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using G1KnowledgeTest.Models.ViewModel;

namespace G1KnowledgeTest.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitofwork _unitOfWork;
        private HomeViewModel HomeVM;
        public HomeController(IUnitofwork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            HomeVM = new HomeViewModel()
            {
                CategoryList = _unitOfWork.Category.GetAll(),
                QuestionsList = _unitOfWork.Questions.GetAll(includeProperties: "Category")
            };

            return View(HomeVM);
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
