/*
PROGRAM 2 (Moderate) — Wallet Simulator (Classes + Encapsulation + Rules)

GOAL:
Practice:
- encapsulation
- method-based validation
- aggregating objects (Wallet has many Transactions)

REQUIREMENTS:
1) Create a class Transaction with:
   - properties (read-only after creation):
       DateTime Timestamp
       string Type   ("DEPOSIT", "SPEND")
       string Note
       decimal Amount

2) Create a class Wallet with:
   - private:
       decimal balance
       List<Transaction> history
   - public:
       Wallet(decimal startingBalance)
       decimal GetBalance()
       bool Deposit(decimal amount, string note)
       bool Spend(decimal amount, string note)
       void PrintStatement(int lastN)   // prints last N transactions newest->oldest
       decimal TotalSpent()
       decimal TotalDeposited()

RULES:
- amount must be > 0
- Spend must not exceed current balance
- Use decimal (money).
- Print helpful messages on failure.

3) In Main:
   - Create one Wallet
   - Menu:
       1) Deposit
       2) Spend
       3) Print last N transactions
       4) Show totals (spent/deposited/balance)
       5) Quit

*/

public class WalletSimulator
{
    // TODO: Implement
}
