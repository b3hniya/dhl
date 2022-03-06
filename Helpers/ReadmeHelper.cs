using Dhl.Execs;
using Dhl.Model;

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