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
    public class DeleteController : Controller
    {
        BloodBankBusinessAccess blObj;
        public DeleteController()
        {
            blObj = new BloodBankBusinessAccess();
        }
        // GET: BloodBank
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete_Donar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete_Donar(DeleteDonarModel donarobject)
        {
            try
            {
                DonarDTO newDonarDTOObj = new DonarDTO()
                {

                    DONAR_ID = donarobject.DONAR_ID
                    

                };
                int result = blObj.DELETE(newDonarDTOObj);
                if (result == 0)
                {
                    return View("Success1");
                }
                else
                {
                    return View("Error1");
                }
            }
            catch (Exception ex)
            {

                return View("Error1");
            }
        }
    }
}