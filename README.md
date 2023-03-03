# RobotSimulator
Robot Simulator Flexisource Exam

## How to setup the application

1. Download Visual Studio Community 2022 [here](https://visualstudio.microsoft.com/vs/community/).
2. After Downloading, Install the application. Make sure you're installing <strong>.Net 6 and .Net Desktop Development</strong>.
3. After installation. Clone this repository.
4. Open the RobotSimulator.sln via Visual Studio 2022.
5. In menu bar, go to <strong>Tools -> Nuget Package Manager -> Package Manager Settings</strong>.
6. Make sure that the source of your nuget package is https://api.nuget.org/v3/index.json. If no source added. click the "+" button and add the link mentioned then click OK.
7. Close the package manager settings, Right click the solution file in solution explorer.
8. Choose Manage Nuget Packages for Solution.
9. Install Nuget Package Microsoft.Extension.DependencyInjection by microsoft.
10. After Nuget Installation, clean and rebuild the solution then you can now run/debug the application.

## Alternative Option, Run directly the app
1. Clone the repository and put in the file directory where you can easily find it.
2. Once cloned go to the file directory then go to *yourfiledirectory*\RobotSimulator\bin\Debug\net6.0
3. Run RobotSimulator with File type Application