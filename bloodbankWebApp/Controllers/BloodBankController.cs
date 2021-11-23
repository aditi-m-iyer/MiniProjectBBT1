using BloodbankBAL;
using BloodbankDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace bloodbankWebApp.Controllers
{
    public class BloodBankController : ApiController
    {

        private readonly IBloodbank blObj;
        //Mocking of your BL : Testing of Controller
        public BloodBankController(IBloodbank iObj)
        {
            blObj = iObj;
        }

        public BloodBankController() : this(new BloodBankBusinessAccess())
        {

        }
        [HttpGet]
        public HttpResponseMessage GetAvailableBlood()
        {
            try
            {
                BloodBankBusinessAccess blobj1 = new BloodBankBusinessAccess();
                var pro = blobj1.GetBloodDetails();

                if (pro != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, pro);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "no data found");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public string GetMessage()
        {
            return "**********************WELCOME TO BLOOD bANK***************";
            return "save life";
        }
        

        [HttpPost]
        public HttpResponseMessage AddDonars(DonarDTO newDonarObj)
        {
            try
            {
                if (newDonarObj != null)
                {
                    //BusinessAccess blObj = new BusinessAccess();
                    int result = blObj.AddDonars(newDonarObj);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Donar added successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Donar not added");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for donar");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }


        [HttpPost]
        public HttpResponseMessage AddUsers(UserDTO newuserObj)
        {
            try
            {
                if (newuserObj != null)
                {
                    BloodBankBusinessAccess blObj1 = new BloodBankBusinessAccess();
                    int result = blObj1.Addusers(newuserObj);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "user data added successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "user data not added");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for donar");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
        [HttpPost]
        public object AddDonars(object newObj)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage DELETE(DonarDTO newDltObj)
        {
            try
            {
                if (newDltObj != null)
                {
                    BloodBankBusinessAccess blObj2 = new BloodBankBusinessAccess();
                    int result = blObj2.DELETE(newDltObj);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Donar deleted  successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Donar not deleted");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for donarId");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }


    }
}
