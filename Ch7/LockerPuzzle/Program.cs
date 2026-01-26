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
   - Print them on ONE line
   - Separate numbers by exactly one space
   - Do not print extra spaces at the beginning or end of the line

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
        // TODO: Implement the locker puzzle simulation here
    }
}
