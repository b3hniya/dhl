using Dhl.Execs;

namespace Dhl.Helpers;
class GitHelper
{
    public static void AddGitToSolution(PromptModel model)
    {
        var projectName = model.GetProjectName();

        if (model.AddGit == true)
        {
            if (model.IsDifferentLocation())
            {
                BashExec.Run($"dotnet new gitignore --output {projectName}");
                BashExec.Run($"git init {projectName}");
                BashExec.Run($"git -C ./{projectName} add .");
                BashExec.Run($"git -C ./{projectName} commit -m 'init.'");

                System.Console.WriteLine("Git initialized successfully.");
            }
            else
            {
                BashExec.Run("dotnet new gitignore");
                BashExec.Run("git init");
                BashExec.Run("git add *");
                BashExec.Run("git add .gitignore");
                BashExec.Run("git commit -m 'init.'");


                System.Console.WriteLine("Git initialized successfully.");
            }
        }
    }
}