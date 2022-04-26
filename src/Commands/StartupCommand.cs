using System.CommandLine;
using Simulator.Services;

namespace Simulator.Commands
{
    class StartupCommand : Command
    {
        public StartupCommand() : base("startup", "Start simulator")
        {
            var argument = new Argument<int>("port", "Listening Port");
            AddArgument(argument);
            
            this.SetHandler<int>(Execute, argument);
        }

        private async Task Execute(int port)
        {
            try
            {
                await CommService.Startup(port);
            }
            catch (System.Exception) { }
        }
    }
}