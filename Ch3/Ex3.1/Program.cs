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
