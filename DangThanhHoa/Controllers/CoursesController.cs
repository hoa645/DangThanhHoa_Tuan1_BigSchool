﻿using DangThanhHoa.Models;
using DangThanhHoa.ViewModels;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CouresViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CouresViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create",viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                Datetime=viewModel.GetDateTime(),
                CategoryId=viewModel.Category,
                Place=viewModel.Place,
            };
            _dbContext.Coureses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}