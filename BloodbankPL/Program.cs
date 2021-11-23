
using BloodbankBAL;
using BloodbankDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type username");
            String UserId1 = Console.ReadLine();
            Console.WriteLine("Type password");
            String Pass = Console.ReadLine();

            String UserIdCorrect = "test1";
            String PassCorrect = "password1";
            int MaxAttempts = 3;
            Console.ReadKey();

            if (UserId1 != UserIdCorrect && Pass != PassCorrect)
            {
                Console.WriteLine("password missmatch!!!!!!!!!!!!!!");
                MaxAttempts++;

            }


            Console.ReadKey();

            Console.WriteLine("**********Hello! Welcome to Blood Bank***************");
            Console.WriteLine("Click 1 for ADMIN");

            Console.WriteLine("Click 2 for USER");
           // int input;
            Console.WriteLine("****Enter your choice!*****");
           int input= Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Click 1 for add donar");

                    Console.WriteLine("click 2 for delete donar");
                    
                    Console.WriteLine("****Enter your choice!*****");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    switch (input1)

                    {
                        case 1:

                            try
                            {
                                BloodBankBusinessAccess blObj = new BloodBankBusinessAccess();

                                Console.WriteLine("**************** WELCOME TO BLOOD-BANK ****************************");


                                Console.WriteLine("Enter Donar_Id");
                                int userInputOne = Convert.ToInt32(Console.ReadLine());


                                Console.WriteLine("Enter firstName:");
                                string userInputTwo = Console.ReadLine();
                                Console.WriteLine("Enter LastName");
                                String userInputThree = Console.ReadLine();
                                Console.WriteLine("Enter Email");
                                string userInputFour = Console.ReadLine();
                                Console.WriteLine("Enter Contact");
                                string userInputFive = Console.ReadLine();
                                Console.WriteLine("Enter Gender");
                                string userInputSix = Console.ReadLine();
                                Console.WriteLine("Enter Blood group");
                                string userInputSeven = Console.ReadLine();
                                Console.WriteLine("Enter Address");
                                string userInputEight = Console.ReadLine();
                                Console.WriteLine("Enter Age");
                                int userInputNine = Convert.ToInt32(Console.ReadLine());

                                DonarDTO newSampleObj = new DonarDTO();
                                newSampleObj.DONAR_ID = userInputOne;
                                newSampleObj.FIRST_NAME = userInputTwo;
                                newSampleObj.LAST_NAME = userInputThree;
                                newSampleObj.EMAIL = userInputFour;
                                newSampleObj.CONTACT = userInputFive;
                                newSampleObj.GENDER = userInputSix;
                                newSampleObj.BLOODGRP = userInputSeven;
                                newSampleObj.ADDRESS = userInputEight;
                                newSampleObj.AGE = userInputNine;



                                int result = blObj.AddDonars(newSampleObj);

                                if (result == -1)
                                {
                                    Console.WriteLine("****Enter the proper input for gender!!*****");
                                    Console.ReadLine();
                                }
                                else if (result == -2)
                                {
                                    Console.WriteLine("****Enter the valid contact number!!*****");
                                    Console.ReadLine();
                                }
                                else if (result == -99)
                                {
                                    Console.WriteLine("****Enter the valid blood group Such as A+/A-   !!*****");
                                    Console.ReadLine();
                                }

                                else
                                {
                                    Console.WriteLine("****Data saved successfully!. Thankyou for your initiative to Donate Blood!!*****");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Something went wrong. Our developers are working on it.Please quote the error message before when you contact customer care");

                                Console.WriteLine(ex.Message);
                                Console.ReadLine();
                            }
                            break;


                        case 2:
                            Console.WriteLine("Enter Donar Id");
                            int DONAR_ID = Convert.ToInt32(Console.ReadLine());

                            DonarDTO dataobj1 = new DonarDTO();

                           dataobj1.DONAR_ID = DONAR_ID;



                           BloodBankBusinessAccess businessobj= new BloodBankBusinessAccess();
                            int result3 = businessobj.DELETE(dataobj1);
                            Console.WriteLine("deleted successfully");
                            Console.ReadLine();

                            break;
                        default:
                            Console.WriteLine("wronng choice");
                            break;
                    }


                    break;
                case 2:
                    try
                    {
                        BloodBankBusinessAccess blObj1 = new BloodBankBusinessAccess();

                        Console.WriteLine("**************** WELCOME TO BLOOD-BANK ****************************");
                        Console.WriteLine("************YOU CAN SEARCH FOR BLOOD-GROUP************");


                        Console.WriteLine("Enter User id");
                        int userInputOne = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Enter Email:");
                        string userInputTwo = Console.ReadLine();
                        Console.WriteLine("Enter FullName");
                        String userInputThree = Console.ReadLine();
                        Console.WriteLine("Enter Contact");
                        string userInputFour = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        string userInputFive = Console.ReadLine();
                        Console.WriteLine("Enter required blood group");
                        string userInputSix = Console.ReadLine();


                        UserDTO newSampleObj1 = new UserDTO();
                        newSampleObj1.USER_ID = userInputOne;
                        newSampleObj1.EMAIL = userInputTwo;
                        newSampleObj1.FULLNAME = userInputThree;
                        newSampleObj1.CONTACT = userInputFour;
                        newSampleObj1.ADDRESS = userInputFive;
                        newSampleObj1.BLOODGRP = userInputSix;



                        int result = blObj1.Addusers(newSampleObj1);

                        if (result == -1)
                        {
                            Console.WriteLine("****Enter the valid contact number!!*****");
                            Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("****User Data saved successfully!!*****");
                            Console.ReadLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong. Our developers are working on it.Please quote the error message before when you contact customer care");

                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("****you have entered wrong input!!*****");
                    Console.ReadLine();
                    break;
            }
           
             

              




           


        }
    }
}
























