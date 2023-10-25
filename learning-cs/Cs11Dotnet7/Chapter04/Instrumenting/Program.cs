using System.Diagnostics;
using Microsoft.Extensions.Configuration;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine("Writing to: {0}", logPath);

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

// text writer is buffered, so this option calls
// Flush() on all listeners after writing
Trace.AutoFlush = true;

//===================

Console.WriteLine("Reading from appsettings.json in {0}", Directory.GetCurrentDirectory());

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "The switch is set via JSON config");

configuration.GetSection("PacktSwitch").Bind(ts);

ts.Level = TraceLevel.Info;

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace vernose");

Console.ReadLine();