using Dhl.Model;
using Execs;

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
        AddGitIgnore(folderName);
        GitInit(folderName);
        StageChanges(folderName);
        CommitChanges(folderName);

        Console.WriteLine("Git initialized successfully.");
    }

    private static void AddGitIgnore(string folderName)
        => BashExec.Run($"dotnet new gitignore --output {folderName}");

    private static void GitInit(string folderName)
        => BashExec.Run($"git init {folderName}");

    private static void StageChanges(string folderName)
        => BashExec.Run($"git -C ./{folderName} add .");

    private static void CommitChanges(string folderName)
        => BashExec.Run($"git -C ./{folderName} commit -m 'init.'");
}