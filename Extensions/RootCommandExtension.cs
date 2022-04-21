using System.CommandLine;
using Simulator.Commands;

namespace Simulator.Extensions
{
    public static class RootCommandExtension
    {
        public static RootCommand Initialize(this RootCommand rootCommand)
        {
            rootCommand.Add(new InitCommand());
            rootCommand.Add(new StartupCommand());
            return rootCommand;
        }
    }
}