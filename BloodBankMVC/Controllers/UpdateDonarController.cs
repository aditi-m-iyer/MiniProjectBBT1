using BloodbankBAL;
using BloodbankDTO;
using BloodBankMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodBankMVC.Controllers
{
    public class UpdateDonarController : Controller
    {
        BloodBankBusinessAccess blObj;
        public UpdateDonarController()
        {
            blObj = new BloodBankBusinessAccess();
        }
        // GET: BloodBank

        public ActionResult Index()
        {
            return View();
        }

        // GET: UpdateDonar
        public ActionResult Update()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Update(UpdateDonar updateDonar)
        {
            try
            {
                DonarDTO newObj = new DonarDTO()
                {
                    DONAR_ID= updateDonar.DONAR_ID,
                    FIRST_NAME = updateDonar.FIRST_NAME,
                    LAST_NAME = updateDonar.LAST_NAME,
                    EMAIL = updateDonar.EMAIL,
                    CONTACT = updateDonar.CONTACT.ToString(),
                    GENDER = updateDonar.GENDER,
                    BLOODGRP = updateDonar.BLOODGRP,
                    ADDRESS = updateDonar.ADDRESS,
                    AGE = updateDonar.AGE

                };
                int result = blObj.UPDATE(newObj);
                if (result == 1)
                {
                    return View("UpdateDonarSuccess");
                }
                else
                {
                    return View("UpdateDonarError");

                }
            }
            catch
            {
                return View("UpdateDonarError");
            }

        }



    }
}




