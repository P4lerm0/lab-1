Console.Title = "InformationBoard";
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("SystemInformation");


Console.WriteLine(Environment.MachineName);
Console.WriteLine(Environment.OSVersion);
Console.WriteLine(Environment.UserDomainName);
Console.WriteLine(Environment.UserName);
Console.WriteLine(Environment.Version);
Console.WriteLine(Environment.CurrentDirectory);
Console.WriteLine(Environment.CurrentManagedThreadId);
Console.WriteLine(Environment.ProcessId);
Console.WriteLine(Environment.ProcessorCount);
Console.WriteLine(Environment.Is64BitProcess);
Console.WriteLine(Environment.Is64BitOperatingSystem);

Console.WriteLine(Console.ReadLine());

Console.ReadKey();
Console.Clear();