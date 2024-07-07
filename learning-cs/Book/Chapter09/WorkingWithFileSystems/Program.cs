using Spectre.Console;

namespace WorkingWithFileSystems;

partial class Program
{
    static void Main(string[] args)
    {
        SectionTitle("Handling cross-platform environments and filesystems");

        #region Handling cross-platform environments and filesystems
        
        // create a spectre console table
        Table table = new Table();
        
        // add two columns with markup for colors
        table.AddColumn("[blue]MEMBER[/]");
        table.AddColumn("[blue]VALUE[/]");
        
        // add rows
        table.AddRow("Path.PathSeparator", PathSeparator.ToString());
        table.AddRow("Path.DirectorySeparatorChar", DirectorySeparatorChar.ToString());
        table.AddRow("Directory.GetCurrentDirectory", GetCurrentDirectory());
        table.AddRow("Environment.GetCurrentDirectory", GetCurrentDirectory());
        table.AddRow("Environment.SystemDirectory", SystemDirectory);
        table.AddRow("Path.GetTempPath()", GetTempPath());
        table.AddRow("");
        table.AddRow("GetFolderPath(SpecialFolder", "");
        table.AddRow("  .System)", GetFolderPath(SpecialFolder.System));
        table.AddRow("  .ApplicationData)", GetFolderPath(SpecialFolder.ApplicationData));
        table.AddRow("  .MyDocuments)", GetFolderPath(SpecialFolder.MyDocuments));
        table.AddRow("  .Personal)", GetFolderPath(SpecialFolder.Personal));
        
        
        // render table in the console
        AnsiConsole.Write(table);
        #endregion
    }
}