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
    public class UserController : Controller
    {
        BloodBankBusinessAccess blObj;
        public UserController()
        {
            blObj = new BloodBankBusinessAccess();
        }
        // GET: BloodBank
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Users(UserModel donarobject)
        {
            try
            {
                UserDTO newUserDTOObj = new UserDTO()
                {
                    EMAIL = donarobject.EMAIL,
                    FULLNAME= donarobject.FULLNAME,


                    CONTACT = donarobject.CONTACT,
                    ADDRESS = donarobject.ADDRESS,
                    BLOODGRP = donarobject.BLOODGRP
                 
                };
                int result = blObj.Addusers(newUserDTOObj);
                if (result == 0)
                {
                    return View("Success2");
                }
                else
                {
                    return View("Error2");
                }
            }
            catch (Exception ex)
            {

                return View("Error2");
            }
        }
    }
}