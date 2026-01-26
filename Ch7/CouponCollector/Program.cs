/*
PROGRAM X (Simulation) — Coupon Collector: Collect All 4 Suits

GOAL:
Practice simulation with random number generation, loops, and state tracking by
modeling the coupon collector’s problem using a standard 52-card deck.

--------------------------------------------------------------------
PROBLEM DESCRIPTION
--------------------------------------------------------------------
You repeatedly “pick” a random card from a standard 52-card deck.
After each pick, the card is placed back into the deck (sampling WITH replacement).

Your goal is to determine how many picks are needed until you have seen
at least ONE card from EACH of the four suits:
- Clubs
- Diamonds
- Hearts
- Spades

You must display:
1) The total number of picks required.
2) The FOUR cards that completed your collection of suits (one card per suit).
   (It is possible that the same exact card value/suit combination is picked again
    during the simulation, but each suit’s “first seen” card should be stored once.)

--------------------------------------------------------------------
PROGRAM REQUIREMENTS
--------------------------------------------------------------------
1) Represent a standard deck of 52 cards:
   - Ranks: A, 2–10, J, Q, K  (13 ranks)
   - Suits: Clubs, Diamonds, Hearts, Spades (4 suits)

2) Simulate random picking:
   - Generate a random rank and suit each pick (or generate a random number 0–51)
   - Treat each pick as independent and put the card “back” (with replacement)

3) Track collection progress:
   - Continue picking until all four suits have been seen at least once.
   - Keep a counter for the number of picks.

4) Store the first card found for each suit:
   - When you see a suit for the first time, save that card (rank + suit).
   - Do NOT overwrite the saved card for a suit after it has been recorded.

5) Output:
   - Print the total number of picks needed.
   - Print the four saved cards, clearly labeled by suit.

--------------------------------------------------------------------
RULES / CONSTRAINTS
--------------------------------------------------------------------
- Use loops for repetition.
- Use Random for selection.
- Do NOT use global variables.
- Keep Main focused on coordination; use helper methods if you choose.
- Output must be clearly labeled and easy to read.

--------------------------------------------------------------------
SUGGESTED OUTPUT FORMAT (EXAMPLE)
--------------------------------------------------------------------
Picks needed: 14

First card from each suit:
Clubs:    7 of Clubs
Diamonds: K of Diamonds
Hearts:   A of Hearts
Spades:   10 of Spades

--------------------------------------------------------------------
OPTIONAL ENHANCEMENTS (NOT REQUIRED)
--------------------------------------------------------------------
- Display each pick as it happens (may be verbose).
- Run the simulation multiple times and report average picks across trials.
- Use enums for Suit and Rank for cleaner code.

--------------------------------------------------------------------
SUBMISSION CHECKLIST
--------------------------------------------------------------------
[ ] Random card picking with replacement
[ ] Loop continues until all 4 suits obtained
[ ] Pick counter correct
[ ] First-seen card for each suit stored and displayed
[ ] Clean, labeled output
*/

using System;

public class CouponCollector
{
    public static void Main()
    {
        // TODO: Implement the simulation here
    }
}
