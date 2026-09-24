decimal balance = 250.00m; // Defining a variable called balance that is a decimal data type and assigned to 250.00.
int option; // Defining a variable called option that is an integer data type.
decimal depositAmount; // Defining a variable called depositAmount that is a decimal data type.
decimal withdrawAmount; // Defining a variable called withdrawAmount that is a decimal data type.

do // Start of the do-while loop
{
    Console.WriteLine("\nWhat option do you require?\n\n[1] Check Balance\n[2] Deposit\n[3] Withdraw\n[4] Exit\n"); // Outputs the menu to the console.
    option = int.Parse(Console.ReadLine()); // Assigning the input the user inputs (which is converted to an integer) to the variable called option.

    switch (option) // Start of the switch statement.
    {
        case 1: // If input is 1.
        Console.WriteLine($"\nYour balance is: £{balance:F2}\n"); // Outputs the users balance amount.
        break; // Ends the first case.
            
        case 2: // If input is 2.
        Console.WriteLine("\nHow much would you like to deposit?"); // Outputs asking how much the user wants to deposit.
        depositAmount = decimal.Parse(Console.ReadLine()); // Assigning the input the user inputs (which is converted to a decimal data type) to the variable called depositAmount.
        balance += depositAmount; // Balance gets updated to add on the depositAmount the user inputted.
        Console.WriteLine($"\nYour new balance is: £{balance:F2}\n"); // Outputs the updated balance amount of the user, making sure it is outputted to 2 decimal points.
        break; // Ends the second case.

        case 3: // If input is 3.
        Console.WriteLine("\nHow much would you like to withdraw?"); // Ouputes asking how much the user wants to withdraw.
        withdrawAmount = decimal.Parse(Console.ReadLine()); // Assigning the input the user inputs (which is converted to a decimal data type) to the variable called withdrawAmount.
        string withdrawLimit = withdrawAmount > balance // Start of the Ternary Operator. 
        ? "\nSorry you do not have enough to make this withdrawal.\n" // If the withdrawAmount is more than the balance then this will be outputted to the console at the end of this case.
        : $"\nYour new balance is: £{(balance -= withdrawAmount):F2}\n"; // If the withdrawAmount is less or equal to the balance then this will be outputted to the console at the end of this case.
        Console.WriteLine("\n" + withdrawLimit); // Ouputs the relevant answer from above.
        break; // Ends the third case.

        case 4: // If input is 4.
        Console.WriteLine("\nGoodbye!\n"); // Ouputs a goodbye message.
        break; // Ends the fourth case.
    }
} while (option != 4); // End of the do-while loop. Does not end unless the input integer is 4.