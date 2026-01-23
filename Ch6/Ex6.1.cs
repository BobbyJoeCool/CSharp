/*
PROGRAM 9 (Functions + All Prior Topics) — Mersenne Prime Finder

GOAL:
Use methods plus conditionals and loops to find Mersenne primes up to a user-defined limit.

DEFINITIONS:
- A Mersenne number is: M_p = 2^p - 1
- A Mersenne prime is a Mersenne number that is prime.

PROGRAM REQUIREMENTS:
1) Ask the user for:
   - An upper limit for p (integer), e.g., 2..50
2) For each p from 2 to upper limit:
   - Compute M = 2^p - 1
   - Check if M is prime
   - If prime, print p and M in a clean format
3) Print only the Mersenne primes found.

METHOD REQUIREMENTS:
- int ReadIntInRange(string prompt, int min, int max)
- long MersenneNumber(int p)                 # compute (2^p - 1) using looping or Math.Pow carefully
- bool IsPrime(long n)                       # efficient check up to sqrt(n)
- void PrintResult(int p, long m)

RULES:
- Must use loops and methods (Main coordinates only).
- No arrays, no lists.
- Prime check must be better than checking all numbers up to n (use sqrt(n) approach).
- Use long for M to reduce overflow risk; still validate p to stay in range.

BONUS:
- Count how many were found and print the count at the end.
*/
