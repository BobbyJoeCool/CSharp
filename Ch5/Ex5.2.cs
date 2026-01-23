/*
PROGRAM 8 (Chapter 5) — Input Validation “Sentinel” Statistics (While / Do-While)

GOAL:
Practice while/do-while loops, sentinel values, counters, and running totals.

PROGRAM REQUIREMENTS:
1) Repeatedly prompt the user to enter integers.
2) Use -1 as the sentinel to stop input (do not include -1 in stats).
3) After the loop ends, display:
   - Count of numbers entered
   - Sum of numbers
   - Average (as double, formatted to 2 decimals)
   - Minimum and maximum
4) Handle edge case: if user enters -1 immediately, print “No numbers entered.”

METHOD REQUIREMENTS:
- int ReadInt(string prompt)
- void UpdateMinMax(int value, ref int min, ref int max, ref bool hasValue)
- double ComputeAverage(int sum, int count)

RULES:
- Use a loop for repeated prompting.
- Use a sentinel value (-1).
- No arrays, no lists.
*/
