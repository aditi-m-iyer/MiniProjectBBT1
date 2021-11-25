using BloodbankDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodbankDAL
{
    public class BloodBankDataAccess
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

        public BloodBankDataAccess()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();

        }


        public int insertbloodbankdoner(DonarDTO newObj)
        {
            try
            {
                //SQL COnnection
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["BloodBank"].ConnectionString;
                //SQL Command
                sqlCmdObj.CommandText = @"usp_insertbloodbankdoner";
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;
                //Input Parameter defintion
             //   sqlCmdObj.Parameters.AddWithValue("@DONAR_ID", newObj.DONAR_ID);
                sqlCmdObj.Parameters.AddWithValue("@FIRST_NAME", newObj.FIRST_NAME);
                sqlCmdObj.Parameters.AddWithValue("@LAST_NAME", newObj.LAST_NAME);
                sqlCmdObj.Parameters.AddWithValue("@EMAIL", newObj.EMAIL);
                sqlCmdObj.Parameters.AddWithValue("@CONTACT", newObj.CONTACT);
                sqlCmdObj.Parameters.AddWithValue("@GENDER", newObj.GENDER);
                sqlCmdObj.Parameters.AddWithValue("@BLOODGRP", newObj.BLOODGRP);
                sqlCmdObj.Parameters.AddWithValue("@ADDRESS", newObj.ADDRESS);
                sqlCmdObj.Parameters.AddWithValue("@AGE", newObj.AGE);

                //Return Value
                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                //OPen COnnection
                sqlConObj.Open();
                //Anything other than SELECT/INSERT/UPDATE/DELETE we use Execute Non Query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);

            }
            catch (Exception ex)
            {

                throw ex;
            }




        }




        public int insertuser(UserDTO newObj1)
        {
            try
            {
                //SQL COnnection
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["BloodBank"].ConnectionString;
                //SQL Command
                sqlCmdObj.CommandText = @"usp_insertusers";
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;
                //Input Parameter defintion
                //sqlCmdObj.Parameters.AddWithValue("@USER_ID", newObj1.USER_ID);
                sqlCmdObj.Parameters.AddWithValue("@EMAIL", newObj1.EMAIL);
                sqlCmdObj.Parameters.AddWithValue("@FULLNAME", newObj1.FULLNAME);
                sqlCmdObj.Parameters.AddWithValue("@CONTACT", newObj1.CONTACT);
                sqlCmdObj.Parameters.AddWithValue("@ADDRESS", newObj1.ADDRESS);
                sqlCmdObj.Parameters.AddWithValue("@BLOODGRP", newObj1.BLOODGRP);

                //Return Value
                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                //OPen COnnection
                sqlConObj.Open();
                //Anything other than SELECT/INSERT/UPDATE/DELETE we use Execute Non Query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);

            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        public int deletedonars(DonarDTO deleteobj)
        {
            sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["BloodBank"].ConnectionString;

            sqlCmdObj.CommandText = @"DeleteDonars";

            sqlCmdObj.CommandType = CommandType.StoredProcedure;
            sqlCmdObj.Connection = sqlConObj;


            sqlCmdObj.Parameters.AddWithValue("@DONAR_ID", deleteobj.DONAR_ID);



            SqlParameter prmReturn = new SqlParameter();
            prmReturn.Direction = ParameterDirection.ReturnValue;
            prmReturn.SqlDbType = SqlDbType.Int;
            sqlCmdObj.Parameters.Add(prmReturn);

            sqlConObj.Open();

            //non execute query
            sqlCmdObj.ExecuteNonQuery();
            return Convert.ToInt32(prmReturn.Value);


        }

        public List<AvlBloodGrpDTO> FetchReqBloodGrp()
        {
            try
            {
                //Setting up the connectionstring to the connection object
                sqlConObj.ConnectionString = ConfigurationManager.
                    ConnectionStrings["BloodBank"].ConnectionString;
                //SEtting up the command text for the command object
                sqlCmdObj.CommandText = @"select BloodGrp from donars";
                sqlCmdObj.Connection = sqlConObj;

                //Execute
                sqlConObj.Open();//COnnection should be open not command
                SqlDataReader sqlDataReaderObj = sqlCmdObj.ExecuteReader();
                List<AvlBloodGrpDTO> lstDept = new List<AvlBloodGrpDTO>();

                DonarDTO newepartObj = new DonarDTO();

                while (sqlDataReaderObj.Read())
                {
                    //newepartObj.DeptName = sqlDataReaderObj[0].ToString();
                    //newepartObj.DeptGroupName = sqlDataReaderObj[1].ToString();
                    //lstDept.Add(newepartObj);

                    lstDept.Add(new AvlBloodGrpDTO()
                    {
                        BLOODGRP = sqlDataReaderObj[0].ToString()

                    }) ;

                }
                return lstDept;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                sqlConObj.Close();
            }

        }




    }
}


