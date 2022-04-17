using System.Diagnostics;

namespace Execs;

public class BashExec
{
    public static string Run(string command)
    {
        var output = string.Empty;
        command = command.Replace("\"", "\"\"");

        var processInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = "-c \"" + command + "\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(processInfo);

        if (process is not null)
        {
            process.WaitForExit();
            output = process.StandardOutput.ReadToEnd();
        }


        return output;
    }
}