# Go Fish – Console Card Game in C #

## Overview

**Go Fish** is a classic card game recreated as a **console application in C#**. The game focuses on object-oriented programming principles, deck and hand management, and basic AI for computer opponents.

Players compete to collect “books” (sets of four cards of the same rank). The project demonstrates practical use of **classes, lists, loops, and game logic** in C#.

## Features

- **Full deck management:** Shuffle, draw, and track remaining cards.
- **Player hands:** Dynamic management of cards with automatic book detection.
- **Turn-based gameplay:** Player vs. computer with random AI for card requests.
- **Book tracking:** Automatic detection and removal of completed sets.
- **Console interface:** Displays hand, turn prompts, and game progress.
- **End-game scoring:** Declares winner based on completed books.

## Project Structure

```
GoFish/  
│  
├─ Program.cs        # Entry point  
├─ Card.cs           # Card class (Rank & Suit)  
├─ Deck.cs           # Deck class (shuffle, draw)  
├─ Player.cs         # Player class (hand, books, check for books)  
└─ Game.cs           # Game logic & turns
```

## Key Concepts Demonstrated

- **Object-Oriented Design**
  - Classes for `Card`, `Deck`, `Player`, and `Game`.
  - Encapsulation of card behavior and game rules.
- **Collections**
  - Use of `List<Card>` to manage hands and deck.
  - LINQ for grouping and counting cards for books.
- **Control Flow**
  - Loops for turns and drawing cards.
  - Conditional logic for asking cards, “Go Fish,” and scoring.
- **Randomness & AI**
  - Randomized computer decisions to simulate opponent moves.

## How to Play

1. Run the program in a **C# console environment** (Visual Studio, VS Code, or .NET CLI).
2. Player is prompted to select a rank from their hand to request from the computer.
3. If the opponent has the requested cards, they are transferred. Otherwise, the player “Go Fishes” by drawing a card from the deck.
4. Completed sets of four cards (“books”) are automatically removed from hands.
5. Turns alternate until all books are collected.
6. Winner is declared based on who has the most books.

## Example Gameplay

Your hand: 2 of Hearts, 5 of Spades, K of Diamonds, 7 of Clubs, 9 of Hearts  
Enter a rank to ask for: 5  
Computer gives 1 card(s) of 5  
You completed a book of 5!  
Computer asks for K  
Go Fish! Computer draws Q of Clubs  
...  
Game Over!  
You: 3 books  
Computer: 2 books  
You win!

## Skills & Technologies

- **Language:** C#
- **Concepts:** Object-Oriented Programming, Classes & Objects, Lists, Loops, Conditional Logic
- **Tools:** Visual Studio, .NET SDK, Console Application

## Potential Extensions

- Multiplayer (2–4 players).
- More advanced AI logic for the computer opponent.
- GUI using **Windows Forms** or **WPF**.
- Track game statistics across sessions.
