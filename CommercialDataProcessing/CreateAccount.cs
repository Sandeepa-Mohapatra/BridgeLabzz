// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CreateAccount.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra">
// --------------------------------------------------------------------------------------------------------------------
    

    

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// class for Create Account
    /// </summary>
    class CreateAccount
        {
            /// <summary>
            /// Creates this instance.
            /// </summary>
            public void Create()
            {
                string accountname = null;
                int sharenumber = 0;
                double stockprice = 0;

                Console.WriteLine("Enter Name to Create an new Account");
                accountname = Console.ReadLine();
                
                sharenumber = 0;
                stockprice = 0;

                AccountClass.CreateAccountObject(accountname, sharenumber, stockprice);

                Console.WriteLine("New Account has Been Created with Name as -" + accountname);


            }
        }
    }


