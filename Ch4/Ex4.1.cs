/*
PROGRAM 5 (Chapter 4) — Date Inspector (Math + Strings)

GOAL:
Practice Math, string parsing/validation, and formatted output.

PROGRAM REQUIREMENTS:
1) Prompt the user to enter a date in the format: YYYY-MM-DD
2) Validate:
   - Must match the format exactly (length and hyphens)
   - Year must be 1–9999
   - Month must be 1–12
   - Day must be valid for the month (handle leap years)
3) Output:
   - The normalized date (YYYY-MM-DD)
   - Whether the year is a leap year
   - The day-of-year number (1–365/366)
4) Do not use DateTime for calculations (manual logic required).

METHOD REQUIREMENTS:
- string ReadNonEmptyString(string prompt)
- bool IsValidDateFormat(string s)  # checks positions of hyphens + digits
- bool IsLeapYear(int year)
- int DaysInMonth(int year, int month)
- int ComputeDayOfYear(int year, int month, int day)
- bool TryParseDate(string s, out int year, out int month, out int day)

RULES:
- Use Math where helpful (e.g., bounds checks).
- Strings must be inspected character-by-character at least once.
- No arrays, no lists.
*/
