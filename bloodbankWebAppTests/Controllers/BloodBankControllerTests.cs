using Microsoft.VisualStudio.TestTools.UnitTesting;
using BloodbankBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http.Hosting;
using System.Web.Http;
using BloodbankDTO;
using bloodbankWebApp.Controllers;
using Moq;
//using ICSharpCode.Decompiler.IL;
using System.Net.Http;

namespace BloodbankBAL.Tests
{
    [TestClass()]
    public class BusinessAccessTests
    {
        [TestMethod()]
        public void AddDonarsTest()
        {
            //Setup Expected Input and Output
            //Expected Result Setup

            int expectedResult = 0;
            DonarDTO testDonarObj = new DonarDTO()
            {
                DONAR_ID = 1,
                FIRST_NAME = "RAVITEJA",
                LAST_NAME = "kOLLURI",
                EMAIL = "RAVITEJA@GMAIL.COM",
                CONTACT = "9908009196",
                GENDER = "MALE",
                BLOODGRP = "B+",
                ADDRESS = "KHAMMAM",
                AGE = 22

            };

            Mock<IBloodbank> mockBLObj = new Mock<IBloodbank>();

            mockBLObj.Setup(x => x.AddDonars(testDonarObj)).Returns(() => expectedResult);

            BloodBankController testControllerObj = new BloodBankController(mockBLObj.Object);
            testControllerObj.Request = new System.Net.Http.HttpRequestMessage()
            {
                Properties =
                {
                    {
                        HttpPropertyKeys.HttpConfigurationKey,new HttpConfiguration()
                    }
                }
            };

            var actualResult = testControllerObj.AddDonars(testDonarObj);

            //Assert

            Assert.AreEqual(HttpStatusCode.OK, actualResult.StatusCode);
            var actualContent = actualResult.Content.ReadAsAsync<List<DonarDTO>>().Result;
            Assert.AreEqual(expectedResult, actualContent);



        }
    }
}