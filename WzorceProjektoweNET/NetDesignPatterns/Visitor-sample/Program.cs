// Who are my employees?
using Visitor_sample;

Employees e = new Employees();
e.Attach(new LineCook());
e.Attach(new HeadChef());
e.Attach(new GeneralManager());

// Employees are visited, giving them 10% raises and 3 extra paid time off days.
e.Accept(new IncomeVisitor());
e.Accept(new PaidTimeOffVisitor());

Console.ReadKey();
