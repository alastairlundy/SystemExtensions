using System.Reflection;
using AlastairLundy.Extensions.System.AssemblyExtensions;
using AlastairLundy.Extensions.System.VersionExtensions;
using Spectre.Console;
using Spectre.Console.Cli;

namespace AlastairLundy.Extensions.Spectre.Console.Commands;

public class VersionCommand : Command<VersionCommand.Settings>
{
    
    public class Settings : CommandSettings
    {
        
    }

    public override int Execute(CommandContext context, Settings settings)
    {
        AnsiConsole.WriteLine($"v{Assembly.GetEntryAssembly().GetProjectVersion().GetFriendlyVersionToString()}");
        return 0;
    }
}