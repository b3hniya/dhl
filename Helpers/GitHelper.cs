using Dhl.Execs;
using Dhl.Model;

namespace Dhl.Helpers;
class GitHelper
{
    public static void AddGitToSolution(CreateModel model)
    {
        if (model.AddGit == true)
        {
            if (model.PutSolutionAndProjectInSamePlace)
                InitializeGit(model.ProjectName);
            else
                InitializeGit(model.GetSolutionName());
        }
    }

    private static void InitializeGit(string folderName)
    {

        BashExec.Run($"dotnet new gitignore --output {folderName}");
        BashExec.Run($"git init {folderName}");
        BashExec.Run($"git -C ./{folderName} add .");
        BashExec.Run($"git -C ./{folderName} commit -m 'init.'");

        System.Console.WriteLine("Git initialized successfully.");
    }
}