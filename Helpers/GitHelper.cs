using Dhl.Execs;

namespace Dhl.Helpers;
class GitHelper
{
    public static void AddGitToProject(PromptModel model)
    {
        if (model.GitIgnoreFile == true)
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