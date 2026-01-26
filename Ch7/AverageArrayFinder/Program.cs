/*
PROGRAM X (Arrays + Method Overloading) — Overloaded Average Methods

GOAL:
Practice array processing and method overloading by writing multiple Average() methods
that compute the average of arrays with different numeric element types.

--------------------------------------------------------------------
PROGRAM REQUIREMENTS
--------------------------------------------------------------------
1) Write FOUR overloaded methods named Average that return the average of an array
   with the following signatures:

   static short  Average(short[] array)
   static int    Average(int[] array)
   static long   Average(long[] array)
   static double Average(double[] array)

   Notes:
   - Each method must compute the average of the elements in its array.
   - The return type must match the method signature above.
   - Use appropriate accumulation types to avoid overflow where reasonable.
     (Example: sum shorts into an int or long; sum ints into a long.)

2) Write a test program (Main) that:
   a) Declares FOUR arrays of different data types:
      - short[]
      - int[]
      - long[]
      - double[]

   b) Ensures each array has a DIFFERENT size.
      Example sizes: 5, 6, 7, 8 (any distinct sizes are acceptable).

   c) Calls the correct overloaded Average() method for each array.

   d) Displays for each array:
      - A clear label of the array type (short, int, long, double)
      - The elements of the array (easy to read)
      - The average value returned by the method

3) Output must be clearly labeled and easy to read.

--------------------------------------------------------------------
RULES / CONSTRAINTS
--------------------------------------------------------------------
- You MUST use method overloading (same name: Average, different parameter types).
- Do NOT use global variables.
- Arrays must NOT be modified inside Average().
  (In C#, arrays are reference types; treat the parameter as read-only by convention.)
- Main should only coordinate:
  - Creating arrays
  - Calling Average()
  - Printing results
  Put the averaging logic inside the Average() methods.

--------------------------------------------------------------------
EDGE CASE REQUIREMENT
--------------------------------------------------------------------
- If an array length is 0, handle it safely (do not divide by zero).
  Choose ONE approach:
  - Print an error message and return 0 (or 0.0 for double), OR
  - Throw an ArgumentException.

--------------------------------------------------------------------
SUGGESTED OUTPUT FORMAT (EXAMPLE)
--------------------------------------------------------------------
Type: short
Elements: 10, 20, 30, 40, 50
Average: 30

Type: int
Elements: ...
Average: ...

--------------------------------------------------------------------
SUBMISSION CHECKLIST
--------------------------------------------------------------------
[ ] Four overloaded Average() methods with correct signatures
[ ] Four arrays: short[], int[], long[], double[]
[ ] All four arrays have different sizes
[ ] Each array is printed with labels and its computed average
[ ] No global variables; Main coordinates only
*/
