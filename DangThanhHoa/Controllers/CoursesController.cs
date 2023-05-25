using DangThanhHoa.Models;
using DangThanhHoa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DangThanhHoa.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CouresViewModel
            {
                Categories = _dbContext.Categories.ToList(),
            };
            return View();
        }
    }
}