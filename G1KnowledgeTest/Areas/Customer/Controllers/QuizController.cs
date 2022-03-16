using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using G1KnowledgeTest.Models;
using G1KnowledgeTest.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace G1KnowledgeTest.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class QuizController : Controller
    {
        private readonly IUnitofwork _unitOfWork;

        [BindProperty]
        public StudyModel Study { get; set; }

        public QuizController(IUnitofwork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Study = new StudyModel()
            {
                //OrderHeader = new class_project_dotnet_core.Model.OrderHeader(),
                QuestionsList = new List<Questions>()
            };

        }
        public IActionResult Index()
        {
            Study = new StudyModel()
            {
                //CategoryList = _unitOfWork.Category.GetAll(),
                QuestionsList = _unitOfWork.Questions.GetAll(includeProperties: "Category")
            };
            return View(Study);
        }


    }
}
