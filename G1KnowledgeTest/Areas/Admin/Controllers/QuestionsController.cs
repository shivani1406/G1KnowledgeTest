using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using G1KnowledgeTest.DataAccess.Data;
using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using G1KnowledgeTest.Models;
using G1KnowledgeTest.Models.ViewModel;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace G1KnowledgeTest.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionsController : Controller
    {
        private readonly IUnitofwork _unitOfwork;
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public QuestionVM ServVM { get; set; }

        public QuestionsController(IUnitofwork unitOfWork, ApplicationDbContext db)
        {
            _unitOfwork = unitOfWork;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            QuestionVM ServVM = new QuestionVM()
            {
                Questions = new G1KnowledgeTest.Models.Questions(),
                CategoryList = _unitOfwork.Category.GetCategoryListForDropDown(),
               
            };
            if (id != null)
            {
                ServVM.Questions = _unitOfwork.Questions.Get(id.GetValueOrDefault());
            }

            return View(ServVM);
        }

        #region API Calls
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfwork.Questions.GetAll(includeProperties: "Category") });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var quesFromDb = _unitOfwork.Questions.Get(id);
            

            if (quesFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }

            _unitOfwork.Questions.Remove(quesFromDb);
            _unitOfwork.Save();
            return Json(new { success = true, message = "Deleted Successfully." });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(int id)
        {
            if (ModelState.IsValid)
            {
                //string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if (ServVM.Questions.id == 0)
                {
                    //New Service
                    string fileName = Guid.NewGuid().ToString();
                    //var uploads = Path.Combine(webRootPath, @"images\services");
                    //var extension = Path.GetExtension(files[0].FileName);

                    //using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    //{
                    //    files[0].CopyTo(fileStreams);
                    //}
                    //ServVM.Service.ImageUrl = @"\images\services\" + fileName + extension;
                    if (files.Count > 0)
                    {
                        byte[] p1 = null;
                        using (var fs1 = files[0].OpenReadStream())
                        {
                            using (var ms1 = new MemoryStream())
                            {
                                fs1.CopyTo(ms1);
                                p1 = ms1.ToArray();
                            }
                        }
                        ServVM.Questions.Picture = p1;
                    }

                    if (ServVM.Questions.id == 0)
                    {
                        _db.Questions.Add(ServVM.Questions);
                    }
                    else
                    {
                        var imageFromDb = _db.Questions.Where(c => c.id == id).FirstOrDefault();

                        imageFromDb.Question = ServVM.Questions.Question;
                        imageFromDb.Option1 = ServVM.Questions.Option1;
                        imageFromDb.Option2 = ServVM.Questions.Option2;
                        imageFromDb.Option3 = ServVM.Questions.Option3;
                        imageFromDb.Option4 = ServVM.Questions.Option4;
                        imageFromDb.Answer = ServVM.Questions.Answer;
                        imageFromDb.Remark = ServVM.Questions.Remark;
                        imageFromDb.CategoryId = ServVM.Questions.CategoryId;
                        if (files.Count > 0)
                        {
                            imageFromDb.Picture = ServVM.Questions.Picture;
                        }
                    }
                    _unitOfwork.Questions.Add(ServVM.Questions);
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ServVM.CategoryList = _unitOfwork.Category.GetCategoryListForDropDown();

                return View(ServVM);
            }
            //        _unitOfwork.Service.Update(ServVM.Service);
            //    }
            //    _unitOfwork.Save();
            //    return RedirectToAction(nameof(Index));
            //}
            //else
            //{
            //    ServVM.CategoryList = _unitOfwork.Category.GetCategoryListForDropDown();
            //    ServVM.FrequencyList = _unitOfwork.Frequency.GetFrequencyListForDropDown();
            //    return View(ServVM);
            //}
        }

        #endregion
    }
}
