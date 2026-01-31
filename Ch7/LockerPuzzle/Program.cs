/*
PROGRAM X (Simulation + Arrays) — Locker Puzzle

GOAL:
Practice nested loops and boolean arrays by simulating the classic locker puzzle.

--------------------------------------------------------------------
PROBLEM SUMMARY
--------------------------------------------------------------------
- There are 100 lockers, demonstrating states open/closed.
- There are 100 students, each toggling lockers in a specific pattern:
  S1 toggles every locker.
  S2 toggles every 2nd locker starting at locker 2.
  S3 toggles every 3rd locker starting at locker 3.
  ...
  S100 toggles locker 100.

After all students finish, print all locker numbers that are OPEN,
separated by exactly one space.

--------------------------------------------------------------------
PROGRAM REQUIREMENTS
--------------------------------------------------------------------
1) Create a boolean array of size 100:
   - false = closed
   - true  = open
   - Initially, all values are false (closed)

2) Simulate each student’s pass:
   - For student s from 1 to 100:
       toggle lockers numbered s, 2s, 3s, ... up to 100
   - Toggling means:
       open -> closed
       closed -> open

3) Output:
   - Print the locker numbers that are open after all passes
   - Print them 5 to a line.
   - Separate numbers by a tab.

--------------------------------------------------------------------
RULES / CONSTRAINTS
--------------------------------------------------------------------
- Use a boolean[] array for locker states
- Use loops to simulate the process
- Do NOT use global variables
- Output must match the spacing requirement exactly

--------------------------------------------------------------------
SUBMISSION CHECKLIST
--------------------------------------------------------------------
[ ] boolean[100] created and initialized to closed
[ ] Nested loop simulation implemented correctly
[ ] Correct locker numbers printed with single-space separation
*/

using System;

public class LockerPuzzle
{
    public static void Main()
    {
        bool[] lockers = new bool[100];

        for (int student = 1; student <= lockers.Length; student++)
        {
            toggleLockersForStudent(student, ref lockers);
        }

        int openCount = 0;

        Console.WriteLine("The following lockers are open.");

        for (int locker = 1; locker <= lockers.Length; locker++)
        {
            if (lockers[locker - 1])
            {
                Console.Write(locker + "\t");
                openCount++;
                if (openCount % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine();
    }

    public static void toggleLockersForStudent(int studentNumber, ref bool[] lockers)
    {
        for (int i = studentNumber - 1; i < lockers.Length; i += studentNumber)
        {
            // studentNumber - 1 is used because the Array starts at 0, but the studentNumber has to start with 1.
            lockers[i] = !lockers[i]; // Flips from false to true or true to false.
        }
    }
}
