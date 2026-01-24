/*
PROGRAM 8 (Chapter 5) — Input Validation “Sentinel” Statistics (While / Do-While)

GOAL:
Practice while/do-while loops, sentinel values, counters, and running totals.

PROGRAM REQUIREMENTS:
1) Repeatedly prompt the user to enter integers.
2) Use -1 as the sentinel to stop input (do not include -1 in stats).
3) After the loop ends, display:
   - Count of numbers entered
   - Sum of numbers
   - Average (as double, formatted to 2 decimals)
   - Minimum and maximum
4) Handle edge case: if user enters -1 immediately, print “No numbers entered.”


RULES:
- Use a loop for repeated prompting.
- Use a sentinel value (-1).
- No arrays, no lists.
*/

using System;

int sum = 0;
int min = 0;
int max = 0;
int count = 0;

Console.WriteLine("Enter an Integer (-1 to stop): ");
int n = int.Parse(Console.ReadLine());
if (n != -1)
{
   sum = n;
   min = n;
   max = n;
   count ++;
}
else
{
   Console.WriteLine("No numbers entered.");
   return;
}

while (n != -1)
{
   Console.WriteLine("Enter an Integer (-1 to stop): ");
   n = int.Parse(Console.ReadLine());

   if (n != -1) 
   {
      sum += n;

      if (n > max)
         max = n;

      if (n< min)
         min = n;
      
      count ++;
   }
}

double average = (double)sum / count;

Console.WriteLine($"You entered {count} numbers.");
Console.WriteLine($"The sum of the numbers you entered is {sum}.");
Console.WriteLine($"The average of the numbers you entered is {average:F2}");
Console.WriteLine($"The highest number you entered is {max}.");
Console.WriteLine($"The lowest number you entered is {min}.");