using System.CommandLine;
using Simulator.Services;

namespace Simulator.Commands
{
    class InitCommand : Command
    {
        private readonly CommService commService;

        public InitCommand() : base("init", "Initialize a SerialPort configuration file")
        {
            commService = new CommService();
            this.SetHandler(Execute);
        }

        private void Execute()
        {
            commService.Save();
            Console.WriteLine("Initialize success");
        }
    }
}