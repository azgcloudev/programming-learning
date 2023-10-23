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