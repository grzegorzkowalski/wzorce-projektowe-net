//Let's cook a steak!
using State_sample;

Steak steak = new Steak("T-Bone");

// Apply temperature changes
steak.AddTemp(120);
steak.AddTemp(15);
steak.AddTemp(15);
steak.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
steak.RemoveTemp(15);
steak.AddTemp(20);
steak.AddTemp(20);
steak.AddTemp(20);

Console.ReadKey();
