using System.CommandLine;
using Simulator.Extensions;

RootCommand rootCommand = new("Modbus Simulator");
rootCommand.Initialize();

return rootCommand.Invoke(args);
