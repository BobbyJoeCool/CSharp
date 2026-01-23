/*
PROGRAM 11 (Functions + All Prior Topics) — “Prime Analyzer” Menu Toolkit

GOAL:
Create a menu-driven program that combines methods, selection, and loops into a single toolkit.

PROGRAM REQUIREMENTS:
1) Display a repeating menu until Exit:
   1) Check if a number is prime
   2) List primes up to a limit
   3) Check if a number is palindromic
   4) Check if a number is a palindromic prime
   5) Exit
2) Validate all inputs (integers within reasonable bounds).
3) For listing primes up to a limit:
   - Print primes in columns or lines (readable formatting)
   - (Optional) Print 10 per line

METHOD REQUIREMENTS:
- void ShowMenu()
- int ReadMenuChoice()
- int ReadIntInRange(string prompt, int min, int max)
- bool IsPrime(int n)
- bool IsPalindrome(int n)           # math-based digit reversal
- void ListPrimesUpTo(int limit)
- void PrintBooleanResult(string label, bool value)

RULES:
- Must use switch for the menu
- Must use loops for repeated prompting and prime listing
- No arrays, no lists

BONUS:
- Add an option to count primes up to N and print the count.
*/
