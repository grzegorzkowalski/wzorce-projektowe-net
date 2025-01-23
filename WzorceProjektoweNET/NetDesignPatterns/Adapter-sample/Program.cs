//Non-adapted
using Adapter_sample;

Meat unknown = new Meat("Beef");
unknown.LoadData();

//Adapted
MeatDetails beef = new MeatDetails("Beef");
beef.LoadData();

MeatDetails turkey = new MeatDetails("Turkey");
turkey.LoadData();

MeatDetails chicken = new MeatDetails("Chicken");
chicken.LoadData();

Console.ReadKey();
