using Dhl.Execs;

namespace Dhl.Helpers;

class ReadmeHelper
{
    public static void AddReadmeFile(PromptModel model)
    {
        if (model.AddReadme)
        {
            if (model.IsDifferentLocation())
                BashExec.Run($"touch ./{model.GetProjectName()}/README.md");
            else
                BashExec.Run("touch README.md");
        }
    }
}