/*
PROGRAM 1 (Moderate) — Work Order Tracker (Classes + List<T> + State)

GOAL:
Practice:
- defining classes
- creating objects
- storing in a List<WorkOrder>
- enforcing state rules through methods

REQUIREMENTS:
1) Create a class WorkOrder with:
   - private fields:
       int id
       string description
       string assignedTo
       WorkStatus status   (enum)
       DateTime createdAt
   - public:
       constructor WorkOrder(int id, string description)
       void Assign(string employeeName)
       bool Start()        // only allowed if Assigned
       bool Complete()     // only allowed if InProgress
       bool Cancel()       // allowed unless Completed
       void Print()        // prints full details

2) Create an enum WorkStatus:
   - New, Assigned, InProgress, Completed, Cancelled

3) In Main:
   - Maintain a List<WorkOrder>
   - Menu loop:
       1) Create new work order
       2) List all work orders
       3) Assign work order by id
       4) Start work order by id
       5) Complete work order by id
       6) Cancel work order by id
       7) Quit

RULES:
- IDs must be unique (reject duplicates).
- Print clear error messages when rules prevent a transition.
- Validate input (don’t crash on bad ids).

OUTPUT:
- After each successful change, print the updated work order.

*/

public class WorkOrderTracker
{
    // TODO: Implement
}
