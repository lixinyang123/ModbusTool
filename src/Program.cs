using System.CommandLine;
using Simulator.Extensions;

RootCommand rootCommand = new RootCommand("MetrologyWorks Simulator");
rootCommand.Initialize();
return rootCommand.Invoke(args);

//using System.Globalization;

//int time = Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds());
//byte[] buffer = BitConverter.GetBytes(time);
//int num = BitConverter.ToInt32(buffer, 0);

//string str = BitConverter.ToString(buffer).Replace("-", string.Empty);

//Console.Read();
