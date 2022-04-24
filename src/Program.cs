using System.CommandLine;
using Simulator.Extensions;

RootCommand rootCommand = new RootCommand("MetrologyWorks Simulator");
rootCommand.Initialize();
return rootCommand.Invoke(args);

//int time = Convert.ToInt32(DateTimeOffset.Now.ToUnixTimeSeconds());

//byte[] buffer = BitConverter.GetBytes(1646841754);

//string str = BitConverter.ToString(buffer);

////int num = BitConverter.ToInt32(buffer, 0);

//static byte[] IntToBytes(int num)
//{
//    byte[] buffer = new byte[4];
//    buffer[0] = (byte)(num);
//    buffer[1] = (byte)(num >> 8);
//    buffer[2] = (byte)(num >> 16);
//    buffer[3] = (byte)(num >> 24);
//    return buffer;
//}

//byte[] temp = IntToBytes(time);

//static int BytesToInt(byte[] src, int offset)
//{
//    int value = (src[offset] & 0xff)
//            | ((src[offset + 1] & 0xff) << 8)
//            | ((src[offset + 2] & 0xff) << 16)
//            | ((src[offset + 3] & 0xff) << 24);
//    return value;
//}

//int num2 = BytesToInt(buffer, 0);

//// 1646841754

//// 62 28 cf 9a

//// 98 40 207 154

//// 154 207 40 98

//Console.Read();
