Project goal

Implement an object-oriented design with a base class Contractor and a derived class Subcontractor.
Contractors store basic information (name, number, start date).
Subcontractors add shift information and hourly pay rate.
Provide constructors, accessors (getters), mutators (setters), and a pay calculation method that applies a 3% shift differential for night shift workers.
Demonstrate usage by allowing the user to create multiple subcontractor instances and compute pay.

What’s included:

Contractor class
Fields: contractorName (string), contractorNumber (int), contractorStartDate (DateTime)
Constructors: parameterized constructor to initialize all fields
Accessors: GetName(), GetNumber(), GetStartDate()
Mutators: SetName(string), SetNumber(int), SetStartDate(DateTime)
Subcontractor class (inherits Contractor)
Additional fields: shift (int), hourlyPayRate (double)
Constructors: parameterized constructor that initializes base Contractor fields and the new fields
Accessors: GetShift(), GetHourlyPayRate()
Mutators: SetShift(int), SetHourlyPayRate(double)
Pay calculation: GetPay(float hoursWorked) returns a float
pay = hourlyPayRate * hoursWorked
if shift == 2 (night shift), apply a 3% differential (pay *= 1.03)
returns the result as a float
How to use

Create a Subcontractor and interact with its data

Example (programmatic usage, no UI shown here):

Subcontractor sc = new Subcontractor("ACME Works", 123, DateTime.Parse("2024-03-01"), 2, 28.50);
float payFor40Hours = sc.GetPay(40.0f);
Console.WriteLine($"Pay for 40 hours: {payFor40Hours}");
Interactive demo (console app idea)

Prompt the user to enter name, number, start date, shift (1 or 2), and hourly rate
Create Subcontractor objects and store them in a list
Iterate through the list and display each subcontractor’s pay for a given hoursWorked value (e.g., 40 hours)
Key methods (summary)

Contractor
Constructor: Contractor(string name, int number, DateTime startDate)
GetName(): string
GetNumber(): int
GetStartDate(): DateTime
SetName(string): void
SetNumber(int): void
SetStartDate(DateTime): void
Subcontractor (extends Contractor)
Constructor: Subcontractor(string name, int number, DateTime startDate, int shift, double hourlyPayRate)
GetShift(): int
GetHourlyPayRate(): double
SetShift(int): void
SetHourlyPayRate(double): void
GetPay(float hoursWorked): float
Applies 3% shift differential if night shift (shift == 2)
Notes on design decisions

Inheritance: Subcontractor derives from Contractor to reuse common fields (name, number, start date) and behavior, while extending with shift and pay-rate data.
Data encapsulation: Fields are kept protected/private with public accessors and mutators to control access and validation (where you might add validation later).
Pay logic: A simple and explicit calculation that applies a night-shift differential. This keeps the method straightforward and easy to test.
