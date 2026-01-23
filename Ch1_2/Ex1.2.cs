/*
PROGRAM 2 (Chapters 1–2) — Simple Payroll: Gross Pay + Overtime

GOAL:
Practice input/output, arithmetic, conditionals (basic), and method decomposition.

PROGRAM REQUIREMENTS:
1) Prompt the user for:
   - Employee name (string)
   - Hours worked this week (double)
   - Hourly rate (double)
2) Compute gross pay with overtime:
   - Up to 40 hours paid at normal rate
   - Hours over 40 paid at 1.5x rate
3) Display:
   - Regular hours, overtime hours
   - Regular pay, overtime pay
   - Total gross pay
   Format currency to 2 decimals.

METHOD REQUIREMENTS:
- double ReadDouble(string prompt)
- (double regularHours, double overtimeHours) SplitHours(double totalHours)
- double ComputeRegularPay(double regularHours, double rate)
- double ComputeOvertimePay(double overtimeHours, double rate)
- double ComputeGrossPay(double regularPay, double overtimePay)

RULES:
- Validate that hours and rate are >= 0.
- No arrays, no lists.
*/
