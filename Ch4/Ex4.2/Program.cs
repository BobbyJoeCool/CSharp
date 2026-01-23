/*
PROGRAM 6 (Chapter 4) — Password Rules Checker (Characters + Strings)

GOAL:
Practice character classification, string scanning, and boolean logic.

PROGRAM REQUIREMENTS:
1) Prompt the user for a password (string).
2) Validate against ALL rules:
   - Length must be between 8 and 20
   - Must contain at least 1 uppercase letter
   - Must contain at least 1 lowercase letter
   - Must contain at least 1 digit
   - Must contain at least 1 “special” character (anything that is NOT letter or digit)
   - Must NOT contain spaces
3) Display:
   - “Valid password” OR “Invalid password”
   - If invalid, print a list of which rules failed.

RULES:
- Use char helper methods (char.IsUpper, char.IsLower, char.IsDigit, char.IsLetterOrDigit, etc.)
- No regular expressions.
- No arrays or lists for storing failures (print failures directly via conditionals).
*/
