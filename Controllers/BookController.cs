﻿using eLibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Controllers
{

    public class BookController : Controller
    {
        private ICRUDBookRepository repository;


        public BookController(ICRUDBookRepository repository)
        {
            this.repository = repository;

        }

        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult AddForm()
        {
            return View();
        }
       
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                return View("ConfirmBook", repository.Add(book));
            }
            else
            {
                return View("AddForm");
            }
        }
       
        public IActionResult List()
        {
            return View(repository.FindAll());
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return View("List", repository.FindAll());
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult EditForm(int id)
        {
            return View(repository.FindById(id));
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            repository.Update(book);
          
            return View("List", repository.FindAll());
        }
    } 
}

