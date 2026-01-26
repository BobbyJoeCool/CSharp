/*
PROGRAM X (Arrays + Strings) — Hangman Game

GOAL:
Practice array usage, string manipulation, loops, and user input by implementing
a console-based Hangman game.

--------------------------------------------------------------------
PROGRAM REQUIREMENTS
--------------------------------------------------------------------
1) Store a list of possible words in a string array.
   Example:
     string[] words = { "write", "that", "program", "java", "computer" };

2) Randomly select a word from the array at the start of each round.

3) Display the word using asterisks (*) to hide unguessed letters.

4) Prompt the user to guess one letter at a time:
   - If the letter exists in the word, reveal it in all correct positions.
   - If the letter does not exist, count it as a miss.
   - Repeated guesses of the same letter should NOT count as a miss.

5) Continue prompting until the word is fully revealed.

6) After the word is guessed:
   - Display the completed word
   - Display the number of misses
   - Ask the user whether they want to play another round

7) Continue or terminate based on the user’s response.

--------------------------------------------------------------------
RULES / CONSTRAINTS
--------------------------------------------------------------------
- Use arrays for word storage.
- Use loops for repetition.
- Do NOT use global variables.
- All logic must be implemented in Main or helper methods.
- Output must be clearly labeled and easy to read.

--------------------------------------------------------------------
SUBMISSION CHECKLIST
--------------------------------------------------------------------
[ ] Word array declared
[ ] Random word selection
[ ] Letter-by-letter guessing
[ ] Miss counter implemented correctly
[ ] Replay prompt implemented
*/

using System;

public class Hangman
{
    public static void Main()
    {
        // TODO: Implement the Hangman game logic here
    }
}
