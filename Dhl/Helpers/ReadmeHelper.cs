using Dhl.Model;
using Execs;

namespace Dhl.Helpers;

class ReadmeHelper
{
    public static void AddReadmeFile(CreateModel model)
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