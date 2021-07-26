using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            int correctPin = 1111;
            int correctAcct = 12345;
            double acctTotal = 0;



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter your Account Number for your account: ");
                string acctString = Console.ReadLine();
                int acctNum = Int32.Parse(acctString);

                if (acctNum == correctAcct)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("Please enter your Pin Number for your account: ");
                        string pinString = Console.ReadLine();
                        int pinNum = Int32.Parse(pinString);

                        if (pinNum == correctPin) {
                            
                            do
                            {
                                
                                do
                                {
                                    
                                    do
                                    {

                                        Console.WriteLine("Welcome, Would you like to check balance(1), deposit(2), withdraw(3), or exit(4)? ");
                                        string choiceInput = Console.ReadLine().ToLower();

                                        switch (choiceInput)
                                        {


                                            case "1":
                                            case "balance":
                                            case "check balance":
                                                Console.WriteLine($"Your current balance is: {acctTotal}");
                                                break;


                                            case "2":
                                            case "deposit":
                                                Console.WriteLine("Please enter the amount to deposit: ");
                                                string depositString = Console.ReadLine();
                                                double depositAmount = Double.Parse(depositString);

                                                acctTotal += depositAmount;

                                                Console.WriteLine($"You have successfully deposited {depositAmount}, Your new account balance is: {acctTotal}");

                                                break;

                                            case "3":
                                            case "withdraw":
                                                Console.WriteLine("Please enter the amount to withdraw: ");
                                                string withdrawString = Console.ReadLine();
                                                double withdrawAmount = Double.Parse(withdrawString);

                                                acctTotal -= withdrawAmount;

                                                Console.WriteLine($"You have successfully wthdrawn {withdrawAmount}, Your new account balance is: {acctTotal}");
                                                break;


                                            case "4":
                                            case "exit":
                                                Console.WriteLine("You have exited your account. Thank you for your business. Have a nice day!");
                                                exit = true;
                                                break;

                                            default:
                                                Console.WriteLine("Invalid input. Please retry with a valid input.");
                                                break;
                                        }

                                    } while (exit == false);
                                

                            } while (pinNum == correctPin && exit == false);
                        } while (acctNum == correctAcct && exit == false) ;
                    }
                        else if (pinNum != correctPin && j < 3 && j != 2)
                        {
                            Console.WriteLine($"Incorrect pin number try again. You have {2 - j} tries left. Try again.");
                        } //END ELSE IF
                        else if (pinNum != correctPin && j == 2)
                        {
                            Console.WriteLine("You have been locked out. Try again later.");
                        } //END ELSE IF

                    } //END FOR LOOP PINS

                } // END IF ATTEMPTS

                else if (acctNum != correctAcct && i < 3 && i != 2)
                {
                    Console.WriteLine($"Incorrect account number try again. You have {2 - i} tries left. Try again.");
                } //END ELSE IF
                else if (acctNum != correctAcct && i == 2)
                {
                    Console.WriteLine("You have been locked out. Try again later.");
                } //END ELSE IF

            

        } // END FOR LOOP
    
            } // END MAIN
        } // END CLASS
    }// END NAMESPACE

