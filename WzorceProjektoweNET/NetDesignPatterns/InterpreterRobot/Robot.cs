namespace InterpreterRobot
{
    public interface ICommand
    {
        void Execute(Robot robot);
    }

    // Klasa reprezentująca robota
    public class Robot
    {
        private int _x = 0;
        private int _y = 0;
        private string _direction = "North";

        public void MoveForward(int units)
        {
            switch (_direction)
            {
                case "North":
                    _y += units;
                    break;
                case "South":
                    _y -= units;
                    break;
                case "East":
                    _x += units;
                    break;
                case "West":
                    _x -= units;
                    break;
            }
        }

        public void TurnLeft()
        {
            _direction = _direction switch
            {
                "North" => "West",
                "West" => "South",
                "South" => "East",
                "East" => "North",
                _ => _direction
            };
        }

        public void TurnRight()
        {
            _direction = _direction switch
            {
                "North" => "East",
                "East" => "South",
                "South" => "West",
                "West" => "North",
                _ => _direction
            };
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Pozycja robota: ({_x}, {_y}), Kierunek: {_direction}");
        }
    }

    // Konkretne polecenie: Przesunięcie do przodu
    public class MoveForwardCommand : ICommand
    {
        private int _units;

        public MoveForwardCommand(int units)
        {
            _units = units;
        }

        public void Execute(Robot robot)
        {
            robot.MoveForward(_units);
        }
    }

    // Konkretne polecenie: Obrót w lewo
    public class TurnLeftCommand : ICommand
    {
        public void Execute(Robot robot)
        {
            robot.TurnLeft();
        }
    }

    // Konkretne polecenie: Obrót w prawo
    public class TurnRightCommand : ICommand
    {
        public void Execute(Robot robot)
        {
            robot.TurnRight();
        }
    }
}
