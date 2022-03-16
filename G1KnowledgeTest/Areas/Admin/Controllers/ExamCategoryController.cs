using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using G1KnowledgeTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace G1KnowledgeTest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExamCategoryController : Controller
    {
        private readonly IUnitofwork _unitofwork;

        public ExamCategoryController(IUnitofwork unitOfWork)
        {
            _unitofwork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            ExamCategory category = new ExamCategory();
            if (id == null)
            {
                return View(category);
            }
            category = _unitofwork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ExamCategory examcategory)
        {
            if (ModelState.IsValid)
            {
                if (examcategory.id == 0)
                {
                    _unitofwork.Category.Add(examcategory);
                }
                else
                {
                    _unitofwork.Category.Update(examcategory);
                }
                _unitofwork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(examcategory);
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitofwork.Category.GetAll() });
            // return Json(new { data = _unitofwork.SP_Call.ReturnList<Category>(SD.usp_GetAllCategory,null)  });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitofwork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }

            _unitofwork.Category.Remove(objFromDb);
            _unitofwork.Save();
            return Json(new { success = true, message = "Delete successful." });

        }

        #endregion
    }
}
