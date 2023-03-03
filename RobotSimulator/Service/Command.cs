using RobotSimulator.Interface;
using RobotSimulator.Model;


namespace RobotSimulator.Service
{
    public class Command : ICommand
    {
        private void Invalid(Robot robot)
        {
            Console.WriteLine("Command Invalid, Please enter new command");
            robot.EnteredCommand = Console.ReadLine();
            ProcessCommand(robot);
        }

        private void Place(Robot robot)
        {
            var enteredCommand = robot.EnteredCommand.ToUpper();
            List<string> splittedCommands = enteredCommand.Split(',', ' ').ToList();
            int interval = 0;

            if (!enteredCommand.StartsWith(Constant.PLACE) || (enteredCommand.StartsWith(Constant.PLACE) && splittedCommands.Count() != 4))
            {
                Invalid(robot);
            }

            foreach (var command in splittedCommands)
            {
                if (command == Constant.PLACE)
                {
                    interval++;
                    continue;
                }

                if (interval == 1)
                {
                    if (command == "0")
                    {
                        robot.X = 0;
                        interval++;
                        continue;
                    }

                    int.TryParse(command, out int value);

                    if (value >= 0 && value <= Constant.XMAXCOORDINATES)
                    {
                        robot.X = value;
                        interval++;
                        continue;
                    }
                    Invalid(robot);
                    break;
                }

                if (interval == 2)
                {
                    int.TryParse(command, out int value);

                    if (command == "0")
                    {
                        robot.Y = 0;
                        interval++;
                        continue;
                    }

                    if (value >= 0 && value <= Constant.YMAXCOORDINATES)
                    {
                        robot.Y = value;
                        interval++;
                        continue;
                    }
                    Invalid(robot);
                    break;
                }

                if (interval == 3)
                {
                    switch (command)
                    {
                        case Constant.NORTH:
                        case Constant.SOUTH:
                        case Constant.EAST:
                        case Constant.WEST:
                            robot.Facing = command;
                            break;

                        default:
                            Invalid(robot);
                            break;
                    }
                }
            }

            interval = 0;
            Console.WriteLine("Robot placed, Enter New Command");
            robot.EnteredCommand = Console.ReadLine();
            ProcessCommand(robot);
        }

        private void Stop()
        {
            Environment.Exit(0);
        }

        public void ProcessCommand(Robot robot)
        {
            var enteredCommand = robot.EnteredCommand.ToUpper();

            if (String.IsNullOrWhiteSpace(enteredCommand))
            {
                Invalid(robot);
            }

            if (enteredCommand.Contains(Constant.PLACE))
            {
                Place(robot);
            }

            if (!string.IsNullOrWhiteSpace(robot.Facing))
            {
                if (enteredCommand == Constant.LEFT)
                {
                    Left(robot);
                }

                if (enteredCommand == Constant.RIGHT)
                {
                    Right(robot);
                }
                if (enteredCommand == Constant.REPORT)
                {
                    Report(robot);
                }

                if (enteredCommand == Constant.MOVE)
                {
                    Move(robot);
                }

                if (enteredCommand == Constant.STOP)
                {
                    Stop();
                }
            }

            Invalid(robot);
        }

        private void Report(Robot robot)
        {
            Console.WriteLine("{0}, {1}, {2}", robot.X, robot.Y, robot.Facing);
            Console.WriteLine("Enter new command");
            robot.EnteredCommand = Console.ReadLine();
            ProcessCommand(robot);
        }

        public void Left(Robot robot)
        {
            switch(robot.Facing)
            {
                case Constant.NORTH:
                    robot.Facing = Constant.WEST; 
                    break;
                case Constant.WEST:
                    robot.Facing = Constant.SOUTH;
                    break;
                case Constant.SOUTH:
                    robot.Facing = Constant.EAST;
                    break;
                case Constant.EAST:
                    robot.Facing = Constant.NORTH;
                    break;
            }

            Console.WriteLine("Robot is now facing {0}, Please enter new command", robot.Facing);
            robot.EnteredCommand = Console.ReadLine();
            ProcessCommand(robot);
        }

        public void Right(Robot robot)
        {
            switch (robot.Facing)
            {
                case Constant.NORTH:
                    robot.Facing = Constant.EAST;
                    break;
                case Constant.EAST:
                    robot.Facing = Constant.SOUTH;
                    break;
                case Constant.SOUTH:
                    robot.Facing = Constant.WEST;
                    break;
                case Constant.WEST:
                    robot.Facing = Constant.NORTH;
                    break;
            }

            Console.WriteLine("Robot is now facing {0}, Please enter new command", robot.Facing);
            robot.EnteredCommand = Console.ReadLine();
            ProcessCommand(robot);
        }
        private void Move(Robot robot)
        {
            var originalXCoordinate = robot.X;
            var originalYCoordinate = robot.Y;

            switch (robot.Facing)
            {
                case Constant.NORTH:
                    robot.Y++;
                    break;
                case Constant.EAST:
                    robot.X++;
                    break;
                case Constant.SOUTH:
                    robot.Y--;
                    break;
                case Constant.WEST:
                    robot.X--;
                    break;
            }

            if ((robot.X < 0 || robot.X > Constant.XMAXCOORDINATES) || (robot.Y < 0 || robot.Y > Constant.YMAXCOORDINATES))
            {
                robot.X = originalXCoordinate;
                robot.Y = originalYCoordinate;
                Invalid(robot);
            }

            Console.WriteLine("Robot moved, Please enter new command");
            robot.EnteredCommand = Console.ReadLine();
            ProcessCommand(robot);
        }
    }
}
