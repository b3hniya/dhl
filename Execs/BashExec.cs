using System.Diagnostics;

namespace Dhl.Execs;

class BashExec
{
    public static void Run(string command)
    {

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

        process.WaitForExit();

        // var output = process.StandardOutput.ReadToEnd();
    }
}