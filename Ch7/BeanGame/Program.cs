/*
PROGRAM X (Chapter 7) — Bean Machine Simulation (Arrays + Randomization)

GOAL:
Practice array manipulation, loops, random number generation, and formatted output
by simulating a Bean Machine (also known as a Galton Box or Quincunx).

--------------------------------------------------------------------
BACKGROUND
--------------------------------------------------------------------
The Bean Machine is a statistical device used to demonstrate probability
and the normal distribution.

- Balls are dropped from the top of the machine.
- Each time a ball hits a peg, it randomly falls LEFT (L) or RIGHT (R),
  with a 50% chance for each direction.
- After passing through all rows of pegs, the ball lands in one of the
  slots at the bottom.
- The final distribution of balls forms a histogram.

--------------------------------------------------------------------
PROGRAM REQUIREMENTS
--------------------------------------------------------------------
1) Prompt the user to enter:
   - The number of balls to drop
   - The number of slots in the machine

2) Simulate dropping each ball:
   - Each ball must generate a path consisting of 'L' and 'R' characters
   - The length of the path must be (slots - 1)
   - Print the path for EACH ball on its own line

   Example paths:
   LLRRLLR
   RLRRLRR

3) Determine the slot where the ball lands:
   - Count the number of 'R' characters in the path
   - The count of 'R' determines the slot index
     Example:
       Path: LRLRLRR  →  4 Rs → slots[4]
       Path: RRLLLLL  →  2 Rs → slots[2]

4) Track results:
   - Create an integer array named slots
   - Each element stores the number of balls in that slot

5) Display the final results as a histogram:
   - Each row represents a slot
   - Each ball in a slot is represented by an asterisk (*)
   - The histogram should be printed vertically, with the tallest column
     at the top and slots aligned at the bottom

--------------------------------------------------------------------
RULES / CONSTRAINTS
--------------------------------------------------------------------
- Use arrays to track slot counts
- Use loops for repetition
- Use Random for left/right decisions
- Do NOT use global variables
- All logic must be inside Main or helper methods
- Output must be clearly labeled and easy to read

--------------------------------------------------------------------
SUGGESTED OUTPUT FORMAT
--------------------------------------------------------------------
Enter number of balls: 5
Enter number of slots: 8

Ball paths:
LRLRLRR
RRLLLLL
LLRLRRR
RLRLRLR
LRRLLRL

Final Slot Distribution:
    *
  * *
* * *
--------
0 1 2 3 4 5 6 7

--------------------------------------------------------------------
OPTIONAL ENHANCEMENTS (NOT REQUIRED)
--------------------------------------------------------------------
- Extract path generation into a method
- Align histogram output neatly with spacing
- Label slots numerically at the bottom

--------------------------------------------------------------------
SUBMISSION CHECKLIST
--------------------------------------------------------------------
[ ] User input for balls and slots
[ ] Random L/R path generation
[ ] slots[] array correctly updated
[ ] Paths printed for each ball
[ ] Histogram displayed correctly
[ ] No global variables
*/

using System;

public class BeanGame
{
    public static void Main()
    {
        // TODO: Implement Bean Machine simulation here
    }
}
