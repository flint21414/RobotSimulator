using RobotSimulator.Interface;
using RobotSimulator.Service;
using Microsoft.Extensions.DependencyInjection;

namespace RobotSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ServiceCollection()
            .AddSingleton<AppStart, AppStart>()
            .AddSingleton<ICommand, Command>()
            .BuildServiceProvider();

            var appStart = builder.GetRequiredService<AppStart>();

            appStart.Start();
        }
    }
}