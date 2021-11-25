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
    public class AdminLoginController : Controller
    {
        BloodBankBusinessAccess blObj;
        public AdminLoginController()
        {
            blObj = new BloodBankBusinessAccess();
        }
        // GET: AdminLogin
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(AdminLoginModel newAdmin)
        {
            try
            {
                AdminDTO newObj = new AdminDTO()
                {
                    Name = newAdmin.Name,
                    Password = newAdmin.Password
                };
                int result = blObj.Check(newObj);
                if (result == 1)
                {
                    return View("Success3");
                }
                else
                {
                    return View("Error3");

                }
            }
            catch
            {
                return View("Error3");
            }

        }
    }
}