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
            this.SetHandler(Execute);
        }

        private void Execute()
        {
            commService.Start();
        }
    }
}