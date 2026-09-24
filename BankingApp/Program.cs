/* 
 * Class name: Banking App
 * Version 1
 * Author: Anjjellan
 */

// Funtion and methods should be verbs.
// With C#, Pascal case should be used with funtion names
// starting with a capital letter for each word.
// Function names should not have underscores in their names.
void BuildBankingApp()
{
    // Initialize the variables
    // Note that an amount is not assigned to the variable
    int choice;
    int subChoice;
    double depositAmount;
    double withdrawAmount;
    double accountBalance = 1000.00;

    // Display the main menu screen
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("========================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    // Read user choice from menu
    // Convert the string to an integer
    // using explicit typecasting

    choice = Convert.ToInt32(Console.ReadLine());

    // the || in the loop represents OR
    // which means that a menu choice of 1 OR 2
    // is acceptable for this logical operation
    if (choice == 1 || choice ==2)
    {
        // Valid menu choice
        if (choice == 1)
        {
            // Deposit or withdraw funds - show sub-menu
            Console.WriteLine("You have chosen to deposit or withdraw funds.");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("========================");
            Console.WriteLine("1 - Deposit funds");
            Console.WriteLine("2 - Withdraw funds");
            Console.WriteLine("Please choose an option (1-2)");

            subChoice = Convert.ToInt32(Console.ReadLine());

            if (subChoice == 1)
            {
                // Deposit funds
                Console.WriteLine("How much would you like to deposit?");
                Console.WriteLine("Enter amount including pence using a decimal point");

                // Typically a currency value is input as a decimal value 
                // so the "double" type is required to store the 
                // deposit amount.

                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original account balance was {accountBalance}");

                //This line of code is interpreted as 
                // account balance = account balance + deposit amount
                // This is an example of an assignment operator

                accountBalance += depositAmount;
                Console.WriteLine($"Your new account balance is {accountBalance}");
            }
            else if (subChoice == 2)
            {
                // Withdraw funds
                Console.WriteLine("How much would you like to withdraw?");
                Console.WriteLine("Enter amount including pence using a decimal point");

                withdrawAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Your original account balance was {accountBalance}");

                // Check that there are sufficient funds before withdrawing
                if (withdrawAmount <= accountBalance)
                {
                    // This line of code is interpreted as
                    // account balance = account balance - withdraw amount
                    accountBalance -= withdrawAmount;
                    Console.WriteLine($"Your new account balance is {accountBalance}");
                }
                else
                {
                    // Insufficient funds
                    Console.WriteLine("Insufficient funds. Withdrawal cancelled.");
                    Console.WriteLine($"Your account balance remains {accountBalance}");
                }
            }
            else
            {
                // Invalid sub-menu choice
                Console.WriteLine("Invalid choice, please choose 1 or 2."); 
            }
        }
        else if (choice == 2)
        {
                // View current account information
                Console.WriteLine("You have chosen to view current account information.");
                Console.WriteLine($"Your current account balance is {accountBalance}");

        }
    }
    else
    {
        // Invalid menu choice
        Console.WriteLine("Invalid choice, please choose 1 or 2.");
    }
}

BuildBankingApp();
