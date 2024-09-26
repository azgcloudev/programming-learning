using System.Diagnostics;

static void ListAllRunningProcesses()
{
    // Get all the processes on the local machine, ordered by PID
    var runningProcs = from proc in Process.GetProcesses(".")
        orderby proc.Id
        select proc;


}