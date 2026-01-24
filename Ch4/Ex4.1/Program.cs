/*
PROGRAM 5 (Chapter 4) — Date Inspector (Math + Strings)

GOAL:
Practice Math, string parsing/validation, and formatted output.

PROGRAM REQUIREMENTS:
1) Prompt the user to enter a date in the format: YYYY-MM-DD
2) Validate:
   - Must match the format exactly (length and hyphens)
   - Year must be 1–9999
   - Month must be 1–12
   - Day must be valid for the month (ignore leap years)
3) Output:
   - The normalized date (YYYY-MM-DD)
   - The day-of-year number (1–365)
4) Do not use DateTime for calculations (manual logic required).

RULES:
- Use Math where helpful (e.g., bounds checks).
- Strings must be inspected character-by-character at least once.
- No arrays, no lists.
*/

using System;

Console.WriteLine("Enter a date in the following format: YYYY-MM-DD: ");
string date = Console.ReadLine();

bool yearValid, monthValid, dayValid, hyphensValid;

if (date.Length != 10)
{
   Console.WriteLine("Your entry is not the correct length.");
   return;
}

hyphensValid = date[4] == '-' && date[7] == '-';

if (!hyphensValid)
{
   Console.WriteLine("You did not follow the YYYY-MM-DD format.");
   return;
}

string year = date.Substring(0, 4);
string month = date.Substring(5, 2);
string day = date.Substring(8, 2);

yearValid = int.TryParse(year, out int yearInt);
monthValid = int.TryParse(month, out int monthInt);
dayValid = int.TryParse(day, out int dayInt);

if (monthValid)
{
   if (monthInt > 12 || monthInt < 1)
   {
      monthValid = false;
   }
}

int dayMax = 0;

if (dayValid)
{
   switch (monthInt)
   {
      case 1:
      case 3:
      case 5:
      case 7:
      case 8:
      case 10:
      case 12:
         dayMax = 31;
         break;
      case 4:
      case 6:
      case 9:
      case 11:
         dayMax = 30;
         break;
      case 2:
         dayMax = 28;
         break;
   }
   if (dayInt <= 0 || dayInt > dayMax)
   {
      dayValid = false;
   }
}

if (dayValid && monthValid && yearValid)
{
   Console.WriteLine($"You entered the correct date format: {date}");
   Console.WriteLine($"Month: {month}, Day: {day}, Year: {year}.");
}
else
{
   Console.WriteLine("You entered an invalid format or date.");
}
