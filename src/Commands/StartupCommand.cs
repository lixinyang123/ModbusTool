using Simulator.Services;
using System.CommandLine;

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

        private void Execute(int port)
        {
            try
            {
                CommService.Startup(port);
            }
            catch (Exception) { }
        }
    }
}