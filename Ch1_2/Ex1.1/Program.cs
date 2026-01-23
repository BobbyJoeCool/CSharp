/*
PROGRAM 1 (Chapters 1–2) — Tip + Tax Receipt Calculator

GOAL:
Practice elementary console programming: input/output, numeric types, basic arithmetic, formatting, and simple helper methods.

PROGRAM REQUIREMENTS:
1) Prompt the user for:
   - Meal subtotal (double)
   - Tax rate as a percent (double, e.g., 8.25)
   - Tip rate as a percent (double, e.g., 18)
2) Calculate:
   - Tax amount
   - Tip amount (based on subtotal, not subtotal+tax)
   - Total amount due
3) Print a receipt-style output showing:
   Subtotal
   Tax rate and tax amount
   Tip rate and tip amount
   Total
   All money values must be formatted to 2 decimal places.

RULES:
- No arrays, no lists.

SUGGESTED OUTPUT (example):
Subtotal: $25.00
Tax (8.25%): $2.06
Tip (18%): $4.50
Total: $31.56
*/

using System;

Console.WriteLine("Enter the meal subtotal: ");
double subtotal = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("What is the Tax Rate where you are (for 7%, type 7): ");
double tax = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter the percent tip to leave (ex: for 10%, type 10): ");
double tip = double.Parse(Console.ReadLine() ?? "0");

tax /= 100;
tip /= 100;

double taxAmount = subtotal * tax;
double tipAmount = subtotal * tip;
double finalTotal = subtotal + taxAmount + tipAmount;

Console.WriteLine("");
Console.WriteLine("Receipt");
Console.WriteLine("-------------------");
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax {tax:P1}: {taxAmount:C}");
Console.WriteLine($"Tip {tip:P1}: {tipAmount:C}");
Console.WriteLine($"Total Due: {finalTotal:C}");
