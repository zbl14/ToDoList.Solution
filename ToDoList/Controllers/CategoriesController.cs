using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  {
    private readonly ToDoListContext _db;

    public CategoriesController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index(string searchString)
    {
      ViewBag.PageTitle = "View All Courses";
      if (!String.IsNullOrEmpty(searchString))
      {
        List<Category> model = _db.Categories
          .Where(category => category.Name.Contains(searchString))
          .OrderBy(category => category.Name)
          .ToList();
        return View(model);
      }
      else
      {
        List<Category> model = _db.Categories
          .OrderBy(category => category.Name)
          .ToList();
        return View(model);
      }
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "New Category";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Category category)
    {
      _db.Categories.Add(category);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisCategory = _db.Categories
        .Include(category => category.JoinEntities)
        .ThenInclude(join =>join.Item)
        .FirstOrDefault(category => category.CategoryId == id);
      ViewBag.PageTitle = "Details";
      return View(thisCategory);
    }

    public ActionResult Edit(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      ViewBag.PageTitle = "Edit Category";
      return View(thisCategory);
    }

    [HttpPost]
    public ActionResult Edit(Category category)
    {
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      ViewBag.PageTitle = "Delete Category";
      return View(thisCategory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}