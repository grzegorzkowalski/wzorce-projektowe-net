using Mediator_sample;

ConcessionsMediator mediator = new ConcessionsMediator();

NorthConcessionStand leftKitchen = new NorthConcessionStand(mediator);
SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

mediator.NorthConcessions = leftKitchen;
mediator.SouthConcessions = rightKitchen;

leftKitchen.Send("Can you send some popcorn?");
rightKitchen.Send("Sure thing, Kenny's on his way.");

rightKitchen.Send("Do you have any extra hot dogs?  We've had a rush on them over here.");
leftKitchen.Send("Just a couple, we'll send Kenny back with them.");

Console.ReadKey();
