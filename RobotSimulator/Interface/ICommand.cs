using RobotSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Interface
{
    public interface ICommand
    {
        public void ProcessCommand(Robot robot);
    }
}
