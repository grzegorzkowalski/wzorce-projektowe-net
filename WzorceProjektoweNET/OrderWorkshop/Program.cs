using OrderWorkshop;

OrderFactory standardOrderFactory = new StandardOrderFactory();
OrderFactory expressOrderFactory = new ExpressOrderFactory();

Order standardOrder = standardOrderFactory.CreateOrder();
Order expressOrder = expressOrderFactory.CreateOrder();

standardOrder.AddNotification(new EmailNotification());
expressOrder.AddNotification(new SmsNotification());

ICommand standardOrderCommand = new ProcessOrderCommand(standardOrder);
ICommand expressOrderCommand = new ProcessOrderCommand(expressOrder);

standardOrderCommand.Execute();
expressOrderCommand.Execute();