using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class CourseController : Controller
{

    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return RedirectToAction("CourseList", "Course");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
    }


    public IActionResult CourseList()
    {


        return View("CourseList", Repository.Courses);
    }


}
