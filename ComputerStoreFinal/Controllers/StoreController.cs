﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComputerStoreFinal.Models;
using ComputerStoreFinal.DataContexts;

namespace ComputerStoreFinal.Controllers
{
    public class StoreController : Controller
    {
        ComputerStoreDb ComputerStoreDb = new ComputerStoreDb();
        // GET: Store
        public ActionResult Index(int CategoryID)
        {
            var category = new List<Category>
            {
                var computerID = new List<Category>
                {
                    new Category {}
                }
            }
            return View(category);
        }

        public ActionResult Browse()
        {

            return View();
        }

        public ActionResult Details(int id)
        {
            var part = ComputerStoreDb.Parts.Find(id);
            return View(part);
        }
    }
}