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

METHOD REQUIREMENTS:
- double ReadDouble(string prompt)
- double PercentToDecimal(double percent)
- double ComputeTax(double subtotal, double taxRateDecimal)
- double ComputeTip(double subtotal, double tipRateDecimal)

RULES:
- Validate numeric input with a loop (do not crash on bad input).
- No arrays, no lists.

SUGGESTED OUTPUT (example):
Subtotal: $25.00
Tax (8.25%): $2.06
Tip (18%): $4.50
Total: $31.56
*/

using System;

Console.WriteLine("Enter the meal subtotal: ");
double subtotal = double.Parse(Console.ReadLine());

