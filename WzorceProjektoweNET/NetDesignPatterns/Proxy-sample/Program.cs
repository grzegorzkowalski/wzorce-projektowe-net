using Proxy_sample;

NewServerProxy proxy = new NewServerProxy();

//Manage orders from a table
Console.WriteLine("What would you like to order? ");
string order = Console.ReadLine();
proxy.TakeOrder(order);
Console.WriteLine("Sure thing!  Here's your " + proxy.DeliverOrder() + ".");
Console.WriteLine("How would you like to pay?");
string payment = Console.ReadLine();
proxy.ProcessPayment(payment);

Console.ReadKey();
