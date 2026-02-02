/*
ASSIGNMENT 2 (Moderate) — Matrix Region Sum Queries (2D int array)

BACKGROUND:
Given a grid of integers (like heatmap values), you often need the sum of a rectangular region.

GOAL:
Write a C# program that:
1) Prompts the user for rows r and columns c.
2) Reads an r x c integer matrix.
3) Prompts for an integer q (number of queries).
4) For each query, reads:
      r1 c1 r2 c2
   representing the corners of a rectangle (inclusive).
5) Validates:
   - indices in bounds
   - r1 <= r2 and c1 <= c2
6) For valid queries, prints the sum of all elements inside the rectangle.
   If invalid, prints an error message and continues.

INPUT EXAMPLE:
Enter rows and cols: 3 4
Enter matrix:
1  2  3  4
5  6  7  8
9 10 11 12
Enter queries: 2
Query 1 (r1 c1 r2 c2): 0 1 2 2
Query 2 (r1 c1 r2 c2): 2 3 1 0

OUTPUT EXAMPLE:
Sum = 39
Invalid rectangle indices.

REQUIREMENTS:
- Use int[,] matrix.
- Use nested loops per query (moderate difficulty).
- Indices can be 0-based or 1-based, but be consistent.
- Clear formatting and messages.

OPTIONAL CHALLENGE:
- Build a prefix-sum matrix to answer each query in O(1).
*/

public class MatrixRegionSumQueries
{
    // TODO: Implement
}
