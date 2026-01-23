/*
PROGRAM 10 (Functions + All Prior Topics) — Palindromic Prime Printer

GOAL:
Practice number analysis with methods and loops by printing all palindromic primes up to a limit.

DEFINITIONS:
- Palindrome: reads the same forward and backward
- Palindromic prime: number is both prime and palindrome

PROGRAM REQUIREMENTS:
1) Ask the user for an upper limit (integer >= 2).
2) For every number from 2 to that limit:
   - Determine if it is prime
   - Determine if it is a palindrome
   - Print it ONLY if it satisfies both
3) Output must be readable (space-separated or one-per-line).

METHOD REQUIREMENTS:
- int ReadIntInRange(string prompt, int min, int max)
- bool IsPrime(int n)                # check up to sqrt(n)
- bool IsPalindrome(int n)           # reverse digits using math
- int ReverseNumber(int n)

RULES:
- No strings for palindrome checking (must use math).
- No arrays, no lists.
- Main should coordinate; logic goes in methods.

BONUS:
- Print how many palindromic primes were found.
*/
