/*
PROGRAM 3 (Chapter 3) — Shipping Cost Calculator (If/Else)

GOAL:
Practice if/else chains with clear, readable business rules and validation.

PROGRAM REQUIREMENTS:
1) Prompt the user for:
   - Package weight in pounds (double)
   - Shipping distance in miles (int)
2) Validate:
   - Weight must be > 0
   - Distance must be >= 1
3) Determine base rate per pound by weight:
   - weight <= 2.0     => $1.10 per lb
   - weight <= 5.0     => $2.20 per lb
   - weight <= 10.0    => $3.70 per lb
   - weight  > 10.0    => $5.00 per lb
4) Determine distance multiplier:
   - distance < 50     => x1.00
   - 50–199            => x1.25
   - 200–499           => x1.50
   - 500+              => x1.75
5) Total cost = weight * baseRate * multiplier
6) Print a clear breakdown and the final cost.

RULES:
- Must use if/else (no switch for the rate tables).
- No arrays, no lists.
*/

using System;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Enter the Package Weight in Pounds: ");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the Shipping Distance in Miles: ");
double distance = double.Parse(Console.ReadLine());

double shippingRate = 0.0;
double distanceMod = 1.0;

if (weight <= 0 || distance < 1)
{
   Console.WriteLine("Invalid input. Weight must be greater than 0 and distance must be at least 1 mile.");
   return;
}

if (weight <= 2.0)
{
   shippingRate = 1.10;
}
else if (weight <= 5.0)
{
   shippingRate = 2.20;
}
else if (weight <= 10.0)
{
   shippingRate = 3.70;
}
else 
{
   shippingRate = 5.00;
}

if (distance >= 49 && distance < 200)
{
   distanceMod = 1.25;
}
else if (distance >= 200 && distance < 500)
{
   distanceMod = 1.50;
}
else if (distance > 500)
{
   distanceMod = 1.75;
}

double subCost = weight * shippingRate;
double totalCost = subCost * distanceMod;

Console.WriteLine("\n--- Shipping Cost Breakdown ---");
Console.WriteLine($"Package weight: {weight} lbs");
Console.WriteLine($"Distance: {distance} miles");
Console.WriteLine($"Base rate: {shippingRate:C} per lb");
Console.WriteLine($"Base cost: {subCost:C}");
Console.WriteLine($"Distance multiplier: x{distanceMod}");
Console.WriteLine($"Total shipping cost: {totalCost:C}");