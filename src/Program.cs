using System.CommandLine;
using Simulator.Extensions;

RootCommand rootCommand = new("MetrologyWorks Simulator");
rootCommand.Initialize();

return rootCommand.Invoke(args);
