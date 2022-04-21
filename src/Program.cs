using System.CommandLine;
using Simulator.Extensions;

RootCommand rootCommand = new RootCommand("MetrologyWorks Simulator");
rootCommand.Initialize();
return rootCommand.Invoke(args);