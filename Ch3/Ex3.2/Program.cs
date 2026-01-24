/*
PROGRAM 4 (Chapter 3) — Simple ATM Menu (Single Operation)

GOAL:
Practice switch statements, input validation, and updating program state
using a single menu selection.

PROGRAM REQUIREMENTS:
1) Start with an initial balance (double) of $1000.00
2) Display a menu ONE time:
   1) View Balance
   2) Deposit
   3) Withdraw
   4) Exit
3) Prompt the user to choose ONE option.
4) Implement the selected operation using a switch statement:

   - View Balance:
       Display the current balance.

   - Deposit:
       Prompt for an amount.
       Validate that the amount is greater than 0.
       Add it to the balance.
       Display the updated balance.

   - Withdraw:
       Prompt for an amount.
       Validate that the amount is greater than 0
       AND less than or equal to the balance.
       Subtract it from the balance.
       Display the updated balance.

   - Exit:
       Display a goodbye message.

5) Display a confirmation message after each action.

RULES:
- Must use a switch statement.
- NO loops.
- NO arrays or lists.
- Use if/else only for validation.
*/


using System;

double balance = 1000.00;

Console.WriteLine("Pick from one of the following menu options:");
Console.WriteLine("1) View Balance");
Console.WriteLine("2) Deposit");
Console.WriteLine("3) Withdraw");
Console.WriteLine("4) Exit");
Console.WriteLine("Enter the number for your selection: ");
int selection = int.Parse(Console.ReadLine());

switch (selection)
{
   case 1:
      Console.WriteLine("You selected: View Balance.");
      Console.WriteLine($"Your account has {balance:c} in it.");
      break;
   case 2:
      Console.WriteLine("You selected: Deposit.");
      Console.WriteLine("Enter the amount for your deposit: ");
      double deposit = double.Parse(Console.ReadLine());
      if (deposit > 0)
      {
         balance += deposit;
         Console.WriteLine($"Your account has {balance:c} in it after your deposit.");
      }
      else
      {
         Console.WriteLine("You must deposit a positive amount.");
      }
      break;
   case 3:
      Console.WriteLine("You selected: Withdraw.");
      Console.WriteLine("Enter the amount for your withdraw: ");
      double withdraw = double.Parse(Console.ReadLine());
      if (withdraw > 0 && withdraw <= balance)
      {
         balance -= withdraw;
         Console.WriteLine($"Your account has {balance:c} in it after your withdrawl.");
      }
      else if (withdraw > balance)
      {
         Console.WriteLine("Insufficient funds.");
      }
      else
      {
         Console.WriteLine("You must withdraw a positive amount.");
      }
      break;
   case 4:
      Console.WriteLine("You selected: Exit.");
      Console.WriteLine("Goodbye!");
      break;
}

Console.WriteLine("Thank you for using the banking app.");