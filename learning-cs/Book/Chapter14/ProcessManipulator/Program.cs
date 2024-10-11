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

// start and kill programatically a process
StartAndKillProcess();
StartAndKillProcessV2();

UseApplicationVerbs();

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
        try
        {
            string info =
                $"-> Thread ID: {t.Id}\tStart Time: {t.StartTime.ToShortDateString()}\tPriority: {t.PriorityLevel}";
            Console.WriteLine(info);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    Console.WriteLine("*********************************************\n");
}

static int GetFirstProcessInList()
{
    var allProcesses = from p in Process.GetProcesses() select p.Id;
    var proc = allProcesses.ElementAt(4);

    return proc;
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

    try
    {
        ProcessModuleCollection theMods = theProc.Modules;

        foreach (ProcessModule mod in theMods)
        {
            string info = $"-> Mod Name: {mod.ModuleName}";
            Console.WriteLine(info);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine("*****************************************\n");
}

// start and kill a process programatically
static void StartAndKillProcess()
{
    Process proc = null;

    try
    {
        proc = Process.Start(@"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe", "www.yahoo.com");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return;
    }

    Console.Write($"-> Hit enter to kill: {proc.ProcessName}...");
    Console.Read();

    // Kill the process
    try
    {
        string procName = proc.ProcessName;
        proc.Kill(true);
        Console.WriteLine($"Process {procName} has been ended.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine("*************************************************\n");
}

static void StartAndKillProcessV2()
{
    Process proc = null;

    try
    {
        ProcessStartInfo startInfo = new ProcessStartInfo("brave", "www.yahoo.com");
        startInfo.UseShellExecute = true;

        if (startInfo != null)
        {
            proc = Process.Start(startInfo)!;
        }
        else
        {
            return;
        }
        
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }

    Console.Write($"-> To kill the process {proc.ProcessName} hit enter: ");
    Console.ReadKey();

    // kill the process
    try
    {
        string procName = proc.ProcessName;
        proc.Kill(true);
        Console.WriteLine($"Process {procName} has been ended.");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    Console.WriteLine("*************************************************\n");
}

static void UseApplicationVerbs()
{
    string path = @"C:\Users\aldai\Desktop\dotnet.txt";

    int i = 0;

    ProcessStartInfo si = new ProcessStartInfo(path);

    foreach (var verb in si.Verbs)
    {
        Console.WriteLine($"  {i++}. {verb}");
    }

    si.WindowStyle = ProcessWindowStyle.Maximized;
    si.Verb = "Edit";
    si.UseShellExecute = true;
    Process.Start(si);
}