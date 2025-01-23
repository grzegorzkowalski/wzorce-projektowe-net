using InterpreterRobot;

Robot robot = new Robot();
List<ICommand> commands = new List<ICommand>
            {
                new MoveForwardCommand(5), // Przesuń do przodu o 5 jednostek
                new TurnLeftCommand(), // Obróć w lewo
                new MoveForwardCommand(3), // Przesuń do przodu o 3 jednostki
                new TurnRightCommand(), // Obróć w prawo
                new MoveForwardCommand(2) // Przesuń do przodu o 2 jednostki
            };

foreach (var command in commands)
{
    command.Execute(robot);
}

robot.PrintPosition(); // Powinien wydrukować: Pozycja robota: (2, 8), Kierunek: North