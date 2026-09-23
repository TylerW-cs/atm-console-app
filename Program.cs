decimal balance = 250.00m;
int option;
decimal depositAmount;
decimal withdrawAmount;

do
{
    Console.WriteLine("\nWhat option do you require?\n\n[1] Check Balance\n[2] Deposit\n[3] Withdraw\n[4] Exit\n");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
        Console.WriteLine($"\nYour balance is: £{balance:F2}\n");
        break;
            
        case 2:
        Console.WriteLine("\nHow much would you like to deposit?");
        depositAmount = decimal.Parse(Console.ReadLine());
        balance += depositAmount;
        Console.WriteLine($"\nYour new balance is: £{balance:F2}\n");
        break;

        case 3:
        Console.WriteLine("\nHow much would you like to withdraw?");
        withdrawAmount = decimal.Parse(Console.ReadLine());
        string withdrawLimit = withdrawAmount > balance
        ? "\nSorry you do not have enough to make this withdrawal.\n" 
        : $"\nYour new balance is: £{(balance -= withdrawAmount):F2}\n";
        Console.WriteLine("\n" + withdrawLimit);
        break;

        case 4:
        Console.WriteLine("\nGoodbye!\n");
        break;
    }
} while (option != 4);