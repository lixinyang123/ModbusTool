using System.CommandLine;
using Simulator.Services;

namespace Simulator.Commands
{
    class StartupCommand : Command
    {
        private readonly CommService commService;

        public StartupCommand() : base("startup", "Start simulator")
        {
            commService = new CommService();

            var argument = new Argument<int>("port", "Listening Port");
            base.AddArgument(argument);
            
            this.SetHandler<int>(Execute, argument);
        }

        private async Task Execute(int port)
        {
            await commService.Startup(port);
        }
    }
}