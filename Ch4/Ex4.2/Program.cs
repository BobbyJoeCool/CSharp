/*
PROGRAM 6 (Chapter 4) — Number Inspector (Math + Minimal Strings, No Loops)

GOAL:
Practice integer math (division/modulo), place-value extraction, range checks,
and formatted output. Minimal string usage (input + validation).

------------------------------------------------------------
PROGRAM REQUIREMENTS
------------------------------------------------------------

1) Prompt the user to enter a WHOLE NUMBER as text (string input).
   - The number must be exactly 6 digits long.
   - Example valid inputs: "120045", "999999", "000123"
   - You will validate and then convert it to an int.

2) Validate the input:
   A) Length must be exactly 6 characters
   B) Every character must be a digit (0–9)
   C) After conversion, the numeric value must be between 0 and 999999

3) Convert the string to an int using TryParse.

4) Using ONLY integer math (/, %), extract each digit:
      d1 d2 d3 d4 d5 d6
   Where:
      d1 is the hundred-thousands digit
      d6 is the ones digit

   Example for 120045:
      d1=1, d2=2, d3=0, d4=0, d5=4, d6=5

5) Compute and output ALL of the following:

   A) Sum of digits
      sum = d1 + d2 + d3 + d4 + d5 + d6

   B) Reverse number (6 digits, keep leading zeros in output)
      reversedDigits = d6 d5 d4 d3 d2 d1
      (Compute using math, not string reversing)

   C) Even/odd digit counts
      Count how many of the six digits are even and how many are odd

   D) Divisibility checks (based on math rules)
      - Is the number divisible by 3?  (sum of digits divisible by 3)
      - Is the number divisible by 9?  (sum of digits divisible by 9)
      - Is the number divisible by 2?  (last digit even)

6) Output formatting requirements:
   - Print the original 6-digit input
   - Print the six digits with labels
   - Print each computed result with clear labels

------------------------------------------------------------
RULES
------------------------------------------------------------

- NO loops (no for, while, do-while, foreach).
- NO arrays, NO lists.
- NO regular expressions.
- MUST use integer math (/, %) to extract digits and compute reversed number.
- Strings may be used ONLY for input, length checking, and digit checking.
- Do NOT use DateTime or any advanced parsing libraries.

------------------------------------------------------------
SUGGESTED VARIABLES (You may use these names)
------------------------------------------------------------

string input;
int number;

int d1, d2, d3, d4, d5, d6;
int sum;
int reversed;

int evenCount, oddCount;

bool divisibleBy2, divisibleBy3, divisibleBy9;

------------------------------------------------------------
HINTS (Math Only)
------------------------------------------------------------

Digit extraction for a 6-digit number N:
d6 = N % 10
d5 = (N / 10) % 10
d4 = (N / 100) % 10
d3 = (N / 1000) % 10
d2 = (N / 10000) % 10
d1 = (N / 100000) % 10

Reversing using math:
reversed = (d6 * 100000) + (d5 * 10000) + (d4 * 1000) + (d3 * 100) + (d2 * 10) + d1

Even check:
digit % 2 == 0

Divisible by 3 / 9:
sum % 3 == 0
sum % 9 == 0
*/

using System;

Console.WriteLine("Enter a whole number that is 6 digits long: ");
string input = Console.ReadLine();

if (input.Length != 6)
{
   Console.WriteLine("Your number is not 6 digits.");
   return;
}

bool inputNumber = int.TryParse(input, out int number);

if (!inputNumber)
{
   Console.WriteLine("Your input is not a whole number.");
   return;
}

int d6 = number % 10;
int d5 = (number / 10) % 10;
int d4 = (number / 100) % 10;
int d3 = (number / 1000) % 10;
int d2 = (number / 10000) % 10;
int d1 = (number / 100000) % 10;

int digitSum = d1 + d2 + d3 + d4 + d5 + d6;
int reversedDigits = 100000 * d6 + 10000 * d5 + 1000 * d4 + 100 * d3 + 10 * d2 + d1;

int oddCount = d6 % 2 + d5 %2 + d4 % 2 + d3 % 2 + d2 % 2 + d1 % 2;
int evenCount = 6 - oddCount;

bool divisibleBy2 = false, divisibleBy3 = false, divisibleBy9 = false;

if (number % 2 == 0)
{
   divisibleBy2 = true;
}

if (number % 9 == 0)
{
   divisibleBy9 = true;
}

if (number % 3 == 0)
{
   divisibleBy3 = true;
}

Console.WriteLine($"The number you entered is {number}");
Console.WriteLine($"Digit 1: {d1}");
Console.WriteLine($"Digit 2: {d2}");
Console.WriteLine($"Digit 3: {d3}");
Console.WriteLine($"Digit 4: {d4}");
Console.WriteLine($"Digit 5: {d5}");
Console.WriteLine($"Digit 6: {d6}");
Console.WriteLine($"The number reversed is {reversedDigits}.");
Console.WriteLine($"The sum of the digits is {digitSum}.");
Console.WriteLine($"The number has {evenCount} even digits and {oddCount} odd digits.");
Console.WriteLine($"Is the number divisible by 2: {divisibleBy2}");
Console.WriteLine($"Is the number divisible by 3: {divisibleBy3}");
Console.WriteLine($"Is the number divisible by 9: {divisibleBy9}");