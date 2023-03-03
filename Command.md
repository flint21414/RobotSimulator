# Rules:
* The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5
units.
* There are no other obstructions on the table surface.
* The robot is free to roam around the surface of the table but must be prevented from falling to
destruction. Any movement that would result in the robot falling from the table must be prevented,
however further valid movement commands must still be allowed.
* Create an application that can read in commands of the following form -
    * PLACE X,Y,F
    * MOVE
    * LEFT
    * RIGHT
    * REPORT
* PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
* The origin (0,0) can be considered to be the SOUTH WEST most corner.
* The first valid command to the robot is a PLACE command, after that, any sequence of commands may
be issued, in any order, including another PLACE command. The application should discard all
commands in the sequence until a valid PLACE command has been executed.
* MOVE will move the toy robot one unit forward in the direction it is currently facing.
* LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position
of the robot.
* REPORT will announce the X,Y and F of the robot. This can be in any form, but standard output is
sufficient.
* A robot that is not on the table can choose to ignore the MOVE, LEFT, RIGHT and REPORT commands.
* Input can be from a file, or from command line input, as the developer chooses.


## Commands

* All commands can be executed in the command line.
* All inputed command line are converted to capital letters.
* There are only 5 Commands in the application. When a specific command is typed and entered in the console app (following the rules), the following will execute:
    * Place
        * Words should consist of the following (Place X Coordinate, Y Coordinate, Cardinal Direction) Example Place 0,0,North
        * X and Y coordinate can only be greater or equal than 0 or Less than or equal to 5
    * Move
        * Depending on the Cardinal Direction of the both, the X or Y Coordinate will be increased or decrease. After the command, it will print a notification. Sample Notification: "Robot is now facing {0}, Please enter new command"
         * if Facing North, every move will add 1 to Y Coordinate
         * if Facing South, every move will substract 1 to Y Coordinate
         * if Facing East, every move will add 1 to X Coordinate
         * if Facing West, every move will substract 1 to X Coordinate
    * Left
        * Depending on the Cardinal Direction of the both, the robot will move to the left after the command executes it will print a notification. Sample Notification:"Robot is now facing East, Please enter new command"
         * if Facing North, Cardinal Direction will be West
         * if Facing West, Cardinal Direction will be South
         * if Facing South, Cardinal Direction will be East
         * if Facing East, Cardinal Direction will be North
    * Right
        * Depending on the Cardinal Direction of the both, the robot will move to the right after the command executes, it will print a notification. Sample Notification: "Robot is now facing West, Please enter new command"
         * if Facing North, Cardinal Direction will be East
         * if Facing East, Cardinal Direction will be South
         * if Facing South, Cardinal Direction will be West
         * if Facing West, Cardinal Direction will be North
    * Report
        * Print the existing placement of the robot in the console application. Sample Notification:"3, 2, EAST"
    * Stop
        * Closes the application.

    Note: If invalid command is typed and entered. a console notification will appear. Sample Notificaiton: "Command Invalid, Please enter new command"


## Example Scenarios:

  Scenario 1:
  
      1.Robot Simulator Started!
      2.Please Enter a Command
      3.place 0,0,North (Input)
      4.Robot placed, Enter New Command(Output)
      5.Move (Input)
      6.Robot moved, Please enter new command(Output)
      7.Move (Input)
      8.Robot moved, Please enter new command(Output)
      9.Right (Input)
      10.Robot is now facing EAST, Please enter new command(Output)
      11.Move (Input)
      12.Robot moved, Please enter new command(Output)
      13.Move (Input)
      14.Robot moved, Please enter new command(Output)
      15.Report (Input)
      16.2, 2, EAST Enter new command(Output)
      18. Stop (Input)

  Scenario 2:
  
      1.Robot Simulator Started! 
      2.Please Enter a Command
      3.place 5,5,North (Input)
      4.Robot placed, Enter New Command (Output)
      5.report (Input)
      6.5, 5, NORTH (Output)
      7.Enter new command  (Output)
      8.move (Input)
      9.Command Invalid, Please enter new command (Output)
      10.right (Input)
      11.Robot is now facing EAST, Please enter new command (Output)
      12.right (Input)
      13.Robot is now facing SOUTH, Please enter new command (Output)
      14.move (Input)
      15.Robot moved, Please enter new command (Output)
      16.move (Input)
      17.Robot moved, Please enter new command (Output)
      18.right (Input)
      19.Robot is now facing WEST, Please enter new command (Output) 
      20.move (Input)
      21.Robot moved, Please enter new command (Output)
      22.move (Input)
      23.Robot moved, Please enter new command (Output)
      24.report (Input)
      25. 3, 3, WEST Enter new command (Output)
      26. Stop (Input)