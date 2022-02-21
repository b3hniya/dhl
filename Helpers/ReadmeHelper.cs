using Dhl.Execs;

namespace Dhl.Helpers;

class ReadmeHelper
{
    public static void AddReadmeFile(PromptModel model)
    {
        if (model.AddReadme)
        {
            if (model.PutSolutionAndProjectInSamePlace == false)
                BashExec.Run($"touch ./{model.GetSolutionName()}/README.md");
            else
                BashExec.Run($"touch ./{model.ProjectName}/README.md");
        }
    }
}