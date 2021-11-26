using BloodBankMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBankMVC.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        BloodBankEntities db = new BloodBankEntities();
        public ActionResult Search(string Search)
        {
            return View(db.DONARS.Where(x => x.BLOODGRP.Contains(Search) || Search == null).ToList());

        }
    }
}

