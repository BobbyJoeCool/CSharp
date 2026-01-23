/*
ASSIGNMENT 4 — Loan Payment Calculator

OBJECTIVE:
Simulate a simple financial calculator using:
- loops
- mathematical formulas
- formatted output
- methods

PROGRAM REQUIREMENTS:
1. Prompt the user for:
   - Loan amount
   - Annual interest rate (as a percentage)
   - Loan term in years
2. Calculate the monthly payment.
3. Display:
   - Monthly payment
   - Total amount paid
   - Total interest paid
4. Validate all inputs (must be positive numbers).

METHOD REQUIREMENTS:
- A method to calculate monthly payment
- A method to calculate total interest
- A method to read and validate numeric input

FORMULA:
monthlyRate = annualRate / 1200
monthlyPayment = loan * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -years * 12))

BONUS:
- Display an amortization schedule using a loop
*/
