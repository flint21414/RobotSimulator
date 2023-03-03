using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Model
{
    public class Robot
    {
        public int X { get; set; }  
        public int Y { get; set; } 
        public string? Facing { get; set; }

        public string? EnteredCommand { get; set; }
    }
}
