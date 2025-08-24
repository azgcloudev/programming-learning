using System.Diagnostics;
using Microsoft.Extensions.Configuration; // To use ConfigurationBuilder.

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

#if DEBUG
Trace.AutoFlush = true;
#endif

Debug.WriteLine("This is a debug message");
Trace.WriteLine("This is a trace message");