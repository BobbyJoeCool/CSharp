/*
PROGRAM 7 (Chapter 5) — Multiplication Table Generator (For Loops)

GOAL:
Practice nested for-loops, formatting, and input bounds.

PROGRAM REQUIREMENTS:
1) Prompt the user for an integer N (1–20).
2) Print an N x N multiplication table:
   - Rows/columns labeled 1..N
   - Use aligned columns (fixed width) so the table is readable.
3) Example (N=5):
      1  2  3  4  5
   1  1  2  3  4  5
   2  2  4  6  8 10
   ...


RULES:
- Must use nested for loops for the grid.
- No arrays, no lists.
*/

using System;

Console.WriteLine("Enter an integer (1-20): ");
int n = int.Parse(Console.ReadLine());

if (n < 1 || n > 20)
{
   Console.WriteLine("Input must be between 1 and 20.");
   return;
}


for (int col = 0; col <= n; col++)
{
   if (col == 0) 
      Console.Write("{0, 5}", "X");
   else
      Console.Write($"{col, 5}");
}
Console.WriteLine();
for (int row = 1; row <= n; row ++)
{
   for (int col = 0; col <=n; col ++)
   {
      if (col == 0)
         Console.Write($"{row, 5}"); 
      else
         Console.Write($"{row * col, 5}");
   }
   Console.WriteLine();
}