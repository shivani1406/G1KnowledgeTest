﻿using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G1KnowledgeTest.Models;
using G1KnowledgeTest.Models.ViewModel;
using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;

using System.Collections.Generic;
using Class_Project_dotnet_core.Extensions;
using G1KnowledgeTest.Utility;

namespace G1KnowledgeTest.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class StudyController : Controller
    {
        private readonly IUnitofwork _unitOfWork;

        [BindProperty]
        public StudyModel Study { get; set; }

        public StudyController(IUnitofwork unitOfWork)
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
