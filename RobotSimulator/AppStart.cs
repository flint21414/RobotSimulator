using RobotSimulator.Interface;
using RobotSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    public class AppStart
    {
        private readonly ICommand _command;

        public AppStart(ICommand command)
        {
            _command = command;
        }

        public void Start()
        {
            Robot robot = new Robot();
            Console.WriteLine("Robot Simulator Started!");
            Console.WriteLine("Please Enter a Command");
            robot.EnteredCommand = Console.ReadLine();

            _command.ProcessCommand(robot);
        }
    }
}
