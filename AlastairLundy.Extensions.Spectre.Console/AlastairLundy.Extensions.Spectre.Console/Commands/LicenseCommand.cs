using System.ComponentModel;

using Spectre.Console;
using Spectre.Console.Cli;

namespace AlastairLundy.Extensions.Spectre.Console.Commands;

public class LicenseCommand : Command<LicenseCommand.Settings>
{
    protected string LicenseTextFile;
    protected string[] ShortLicenseNotice;

    public LicenseCommand(string licenseTextFile, string[] shortLicenseNotice)
    {
        this.LicenseTextFile = licenseTextFile;
        this.ShortLicenseNotice = shortLicenseNotice;
    }
    
    public class Settings : CommandSettings
    {
        [CommandOption("--verbose")]
        [DefaultValue(false)]
        public bool IsVerbose { get; init; }
    }

    public override int Execute(CommandContext context, Settings settings)
    {
        if (settings.IsVerbose)
        {
            try
            {
                string[] lines = File.ReadAllLines(LicenseTextFile);

                foreach (string line in lines)
                {
                    AnsiConsole.WriteLine(line);
                }

                AnsiConsole.WriteLine();
                return 0;
            }
            catch(Exception exception)
            {
                AnsiConsole.WriteException(exception);
                return -1;
            }
        }
        // ReSharper disable once RedundantIfElseBlock
        else
        {
            foreach (string line in ShortLicenseNotice)
            {
                AnsiConsole.WriteLine(line);
            }

            AnsiConsole.WriteLine();
            return 0;
        }
    }
}