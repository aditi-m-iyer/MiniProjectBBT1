
using BloodbankBAL;
using BloodbankDTO;
using BloodBankMVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBankMVCAPP.Controllers
{
    public class BloodBankController : Controller
    {

        BloodBankBusinessAccess blObj;
        public BloodBankController()
        {
            blObj = new BloodBankBusinessAccess();
        }
        // GET: BloodBank

               public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDonars()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDonars(AddDonarModel donarobject)
        {
            try
            {
                DonarDTO newDonarDTOObj = new DonarDTO()
                {

                    FIRST_NAME = donarobject.FIRST_NAME,
                    LAST_NAME = donarobject.LAST_NAME,
                    EMAIL = donarobject.EMAIL,
                    CONTACT = donarobject.CONTACT.ToString(),
                    GENDER = donarobject.GENDER,
                    BLOODGRP = donarobject.BLOODGRP,
                    ADDRESS = donarobject.ADDRESS,
                    AGE = donarobject.AGE

                };
               
                int result = blObj.AddDonars(newDonarDTOObj);
                
                if (result ==0)
                {
                    return View("Success");
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
    }
}