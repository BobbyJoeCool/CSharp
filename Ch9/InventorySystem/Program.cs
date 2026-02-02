/*
PROGRAM 3 (Moderate) — Inventory System (Objects + Aggregation + 2D Report)

GOAL:
Use multiple classes and generate a 2D-style report (rows x columns) from objects.

REQUIREMENTS:
1) Create a class Item with:
   - private:
       string sku
       string name
       int quantity
       decimal price
   - public:
       constructor Item(string sku, string name, int quantity, decimal price)
       bool AddStock(int amount)
       bool RemoveStock(int amount)
       decimal TotalValue()
       string GetSku()
       string GetName()
       int GetQuantity()
       decimal GetPrice()

RULES:
- quantity cannot go negative
- stock change amount must be > 0

2) Create a class Inventory with:
   - private:
       List<Item> items
   - public:
       bool AddItem(Item item)                 // SKU must be unique
       Item? FindBySku(string sku)
       void PrintCatalog()
       void PrintValueReportByPriceBands()

3) Reporting requirement (the “2D” part):
- Define 4 price bands:
   Band 1: < $5
   Band 2: $5–$19.99
   Band 3: $20–$99.99
   Band 4: >= $100
- Print a table where each row is a band and columns are:
   Count of items, Total quantity, Total inventory value

MAIN MENU:
1) Add new item
2) Stock in (add quantity by SKU)
3) Stock out (remove quantity by SKU)
4) Print catalog
5) Print value report (bands)
6) Quit

NOTES:
- This reinforces object lists, validation, and generating a structured report like a 2D table.

*/

public class InventorySystem
{
    // TODO: Implement
}
