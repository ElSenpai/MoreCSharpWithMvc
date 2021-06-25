using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            var list = cm.GetList();
            return View(list);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator vali = new CategoryValidator();
            ValidationResult results = vali.Validate(category);
            if (results.IsValid)
            {
                cm.Add(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var category = cm.GetById(id);
            cm.Delete(category);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var value = cm.GetById(id);

            return View(value);
        }
        [HttpPost]
        public ActionResult EditCategory(Category category)
        {
            cm.Update(category);
            return RedirectToAction("Index");
        }

    }
}