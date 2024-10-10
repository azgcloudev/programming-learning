using System.Diagnostics;

ListAllRunningProcesses();
GetSpecificProcessById();

Console.WriteLine();
Console.WriteLine("***** Enter PID of process to investigate *****");
Console.Write("PID: ");
string pID = Console.ReadLine();
int pIdInt = int.Parse(pID);
EnumThreadsForPid(pIdInt);

// Modules of a process
Console.WriteLine();
EnumModsForPid(GetFirstProcessInList());

Console.ReadLine();

static void ListAllRunningProcesses()
{
    // Get all the processes on the local machine, ordered by PID
    var runningProcs = from proc in Process.GetProcesses(".")
        orderby proc.Id
        select proc;

    // print out PID and name of process
    foreach (var p in runningProcs)
    {
        string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
        Console.WriteLine(info);
    }

    Console.WriteLine("*****************************************\n");
}

// if the process PID do not exceed it throws an exception
static void GetSpecificProcessById()
{
    Process theProc = null;

    try
    {
        theProc = Process.GetProcessById(30592);
        Console.WriteLine(theProc?.ProcessName);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

static void EnumThreadsForPid(int pid)
{
    Process theProc = null;

    try
    {
        theProc = Process.GetProcessById(pid);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e);
        return;
    }

    //list stats for each thread in the specified process
    Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);

    ProcessThreadCollection theThreads = theProc.Threads;

    foreach (ProcessThread t in theThreads)
    {
        string info =
            $"-> Thread ID: {t.Id}\tStart Time: {t.StartTime.ToShortDateString()}\tPriority: {t.PriorityLevel}";
        Console.WriteLine(info);
    }

    Console.WriteLine("*********************************************\n");
}

static int GetFirstProcessInList()
{
    var allProcesses = from p in Process.GetProcesses() select p.Id;
    var proc = allProcesses.ElementAt(4);

    return 11764;
}

static void EnumModsForPid(int pid)
{
    Process theProc = null;

    try
    {
        theProc = Process.GetProcessById(pid);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine("Here are the loaded modules for: {0}", theProc.ProcessName);
    ProcessModuleCollection theMods = theProc.Modules;
    ;
    foreach (ProcessModule mod in theMods)
    {
        string info = $"-> Mod Name: {mod.ModuleName}";
        Console.WriteLine(info);
    }

    Console.WriteLine("*****************************************\n");
}