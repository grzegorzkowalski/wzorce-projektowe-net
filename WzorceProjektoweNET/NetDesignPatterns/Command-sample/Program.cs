using Command_sample;

Patron patron = new Patron();
    patron.SetCommand(1 /*Add*/);
    patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
    patron.ExecuteCommand();

    patron.SetCommand(1 /*Add*/);
    patron.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
    patron.ExecuteCommand();

    patron.SetCommand(1 /*Add*/);
    patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
    patron.ExecuteCommand();

    patron.ShowCurrentOrder();

    //Remove the french fries
    patron.SetCommand(3 /*Add*/);
    patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
    patron.ExecuteCommand();

    patron.ShowCurrentOrder();

    //Now we want 4 hamburgers rather than 2
    patron.SetCommand(2 /*Add*/);
    patron.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
    patron.ExecuteCommand();

    patron.ShowCurrentOrder();

    Console.ReadKey();