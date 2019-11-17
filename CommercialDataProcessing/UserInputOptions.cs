 // --------------------------------------------------------------------------------------------------------------------
 // <copyright file="UserInputsOptions.cs" company="Bridgelabz">
 //   Copyright © 2019 Company="BridgeLabz"
 // </copyright>
 // <creator name="Sandeepa Mohapatra">
 // --------------------------------------------------------------------------------------------------------------------using System;
    

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class For User Inputs Options
    /// </summary>
    class UserInputOptions
        {
            /// <summary>
            /// Gets the inputs.
            /// </summary>
            public void GetInputs()
            {
                try
                {
                    char choice;
                    int ch = 0;
                    do
                    {
                        Console.WriteLine("Enter What you want to do");
                        Console.WriteLine("");
                        Console.WriteLine("Create a New Account(1)");
                        Console.WriteLine("Display Total Value of Account Stock(2)");
                        Console.WriteLine("ADD Shares and Stock to Account(3)");
                        Console.WriteLine("Sell Shares of Stock from Account(4)");
                        Console.WriteLine("Display Particular Account Details Reports of Shares and Stocks(5)");
                        Console.WriteLine("Exit(6)");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Enter your choice to perform");
                        ch = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        switch (ch)
                        {
                            //// case 1 for creating an new account
                            case 1:
                                CreateAccount create = new CreateAccount();
                                create.Create();
                                break;
                            //// case 2 for Displaying Total Value of Account Stock
                            case 2:
                                AccountOperation accountDisplay = new AccountOperation();
                                accountDisplay.DisplayTotalStocks();
                                break;
                            //// case 3 for ADDING Shares and Stock to Account
                            case 3:
                                AccountOperation accountbuy = new AccountOperation();
                                accountbuy.Buy();
                                break;
                            //// case 4 for Selling Shares of Stock from Account
                            case 4:
                                AccountOperation accountsell = new AccountOperation();
                                accountsell.Sell();
                                break;
                            case 5:
                                AccountOperation displayaccount = new AccountOperation();
                                displayaccount.DisplayParticularAccount();
                                break;
                            
                        }
                        Console.WriteLine("Do you want to Continue then Press Y");
                        choice = Convert.ToChar(Console.ReadLine());
                    }
                    while (choice == 'y');

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }


