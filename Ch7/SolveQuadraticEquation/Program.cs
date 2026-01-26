/*
PROGRAM X (Methods + Arrays) — Solve Quadratic Equations

GOAL:
Practice method creation, array parameter passing, and mathematical computation
by solving quadratic equations of the form:

    ax² + bx + c = 0

--------------------------------------------------------------------
PROGRAM REQUIREMENTS
--------------------------------------------------------------------
1) Implement the following method:

   public static int SolveQuadratic(double[] eqn, double[] roots)

   Where:
   - eqn is an array of size 3 containing:
       eqn[0] = a
       eqn[1] = b
       eqn[2] = c
   - roots is an array of size 2 used to store real roots (if any)
   - The method returns:
       0 → no real roots
       1 → one real root
       2 → two real roots

2) Root calculation rules:
   - Compute the discriminant:  b² − 4ac
   - If discriminant < 0 → no real roots
   - If discriminant == 0 → one real root
   - If discriminant > 0 → two real roots

3) Write a test program that:
   - Prompts the user to enter values for a, b, and c
   - Calls SolveQuadratic(...)
   - Displays:
       - The number of real roots
       - All real roots (if any)

--------------------------------------------------------------------
RULES / CONSTRAINTS
--------------------------------------------------------------------
- Use arrays to pass coefficients and return roots
- Do NOT use global variables
- Main should handle:
   - User input
   - Method call
   - Output
- All math logic must be inside SolveQuadratic()

--------------------------------------------------------------------
SUGGESTED OUTPUT FORMAT
--------------------------------------------------------------------
Enter a, b, and c: 1 3 2

Number of real roots: 2
Roots:
x1 = -1
x2 = -2

--------------------------------------------------------------------
SUBMISSION CHECKLIST
--------------------------------------------------------------------
[ ] SolveQuadratic(double[], double[]) implemented
[ ] Correct discriminant logic
[ ] Roots stored correctly in array
[ ] User input and output handled in Main
*/

using System;

public class SolveQuadraticEquations
{
    public static void Main()
    {
        // TODO: Implement SolveQuadratic method here

    }
}
