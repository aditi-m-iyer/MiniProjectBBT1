


using BloodbankDAL;
using BloodbankDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodbankBAL
{
    public class BloodBankBusinessAccess 
    {
       

        public int AddDonars(DonarDTO newObj)
        {
            try
            {
                BloodBankDataAccess dalObj = new BloodBankDataAccess();
                int result = dalObj.insertbloodbankdoner(newObj);
                return result;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

       

        public int Addusers(UserDTO newObj1)
        {
            try
            {
                BloodBankDataAccess dalObj = new BloodBankDataAccess();
                int result = dalObj.insertuser(newObj1);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int DELETE(DonarDTO obj2)
        {
            try
            {
                BloodBankDataAccess dalObj = new BloodBankDataAccess();
                int result = dalObj.deletedonars(obj2);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ReqBlood> GetBloodDetails()
        {
            try
            {
                BloodBankDataAccess dalObj = new BloodBankDataAccess();
                List<ReqBlood> results = dalObj.FetchReqBloodGrp();
                return results;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}













