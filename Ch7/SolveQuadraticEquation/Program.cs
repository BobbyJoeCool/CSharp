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

public class Program
{
    public static void Main()
    {
        Console.WriteLine("ax^2 + bx + c = 0.  Quadratic Equation Solver!");
        Console.WriteLine("Enter values for a, b, and c:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("If 'a' is 0, it is a linear equation.");
            return;
        }

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double[] eqn = {a, b, c};
        double[] roots = {0, 0};

        int rootCount = SolveQuadratic(eqn, ref roots);

        Console.WriteLine("Your equation has " + rootCount + " real roots.");

        switch (rootCount)
        {
        case 1:
            Console.WriteLine("The root is " + roots[0]);
            break;
        case 2:
            Console.WriteLine("Those roots are " + roots[0] + " and " + roots[1]);
            break;
        case 0:
            Console.WriteLine("No real roots.");
            break;
        }
    }

    public static int SolveQuadratic(double[] eqn,ref double[] roots)
    {
        double a = eqn[0];
        double b = eqn[1];
        double c = eqn[2];

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0) {
            roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return 2;
        } 
        else if (discriminant == 0)
        {
            roots[0] = -b / (2 * a);
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
