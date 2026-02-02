/*
ASSIGNMENT 1 (Moderate) — Seating Chart Analyzer (2D char array)

BACKGROUND:
A teacher has a classroom seating chart where each seat is:
- 'E' = Empty
- 'S' = Student
- 'T' = Teacher desk (exactly one)

GOAL:
Write a C# program that:
1) Prompts the user for rows r and columns c.
2) Reads an r x c grid of characters (E, S, T).
3) Validates:
   - Only E/S/T are allowed
   - Exactly ONE 'T' exists
4) Computes:
   - Total students
   - The row with the most students (if tie, print the first)
   - The number of students adjacent to the teacher desk (8-direction neighbors)
5) Prints a clean summary report.

INPUT EXAMPLE:
Enter rows and cols: 4 5
Enter grid:
E S S E E
E E S E E
E S T S E
E E S E E

OUTPUT EXAMPLE:
Valid chart: Yes
Teacher desk at: (2, 2)
Total students: 7
Row with most students: 0 (count=2)
Students adjacent to teacher: 3

REQUIREMENTS:
- Use char[,] for the grid.
- Use nested loops.
- Adjacent includes diagonals.
- Handle boundaries safely.
- Don’t hardcode sizes.
*/

public class SeatingChartAnalyzer
{
    // TODO: Implement
}
