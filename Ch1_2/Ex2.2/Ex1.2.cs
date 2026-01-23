/*
PROGRAM 2 (Chapters 1–2) — Simple Payroll: Gross Pay

GOAL:
Practice elementary console programming using:
- Input and output
- Variables
- Simple arithmetic
- Basic formatting

PROGRAM REQUIREMENTS:
1) Prompt the user for:
   - Employee name (string)
   - Hours worked this week (double)
   - Hourly rate (double)
2) Compute gross pay using the formula:
   gross pay = hours worked × hourly rate
3) Display:
   - Employee name
   - Hours worked
   - Hourly rate
   - Gross pay
4) Format monetary values to two decimal places.

RULES:
- No conditionals (if/else)
- No loops
- No user-defined methods
- No arrays or lists
- Assume valid input
*/

using System;

Console.WriteLine("Enter your Name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter the number of hours you worked this week: ");
double hours = double.Parse(Console.ReadLine());
Console.WriteLine("Enter your rate of pay per hour: ");
double rate = double.Parse(Console.ReadLine());

double pay = hours * rate;

Console.WriteLine("");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Hours Worked: {hours:F1}");
Console.WriteLine($"Pay Rate: {rate:C}");
Console.WriteLine($"Gross Wage: {pay:C}");
