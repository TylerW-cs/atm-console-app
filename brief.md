SIMPLE ATM CONSOLE APP

THE IDEA: A menu-driven balance simulator that keeps showing options until the user chooses to quit.
Requirements:

Start with a fixed opening balance stored as a decimal (e.g. 250.00m). Print a menu with numbered options — something like:

    1) Check balance
    2) Deposit
    3) Withdraw 
    4) Exit

Wrap the whole thing in a do-while loop so the menu shows at least once and keeps reappearing after each action, only stopping once the user picks Exit.

Read the user's menu choice and use a switch statement to branch on it — one case per option. 

For Check Balance, just print the current balance. Use string interpolation with :F2 everywhere you show a money value, so it's always to 2 decimal places.

For Deposit, ask for an amount, parse it to decimal, and add it to the balance with +=. 

For Withdraw, ask for an amount and use a ternary operator to check whether the balance covers it: if it does, subtract with -=; if not, print an "insufficient funds" message and leave the balance untouched. 

When the user picks Exit, print a short goodbye message and let the loop end naturally.


A few optional stretch goals once the core version works: 

Turn the switch statement into a switch expression for generating the confirmation messages; add an "are you sure you want to exit?" prompt and use char.ToUpper() so it accepts both y and Y.

Keep a running count of how many transactions were made using a compound operator; or use pattern matching (number is >= 1 and <= 4) to validate the menu choice before the switch runs, printing "invalid option" and re-looping if it's out of range.