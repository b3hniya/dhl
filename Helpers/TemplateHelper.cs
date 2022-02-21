using Dhl.Execs;

namespace Dhl.Helpers;

class TemplateHelper
{
    public static void CreateProjectBasedOnTemplate(PromptModel model)
    {
        var command = string.Empty;

        command += $"dotnet new {model.Template.ToString()}";

        if (model.IsDifferentLocation())
            command += $" -n {model.GetProjectName()}";

        BashExec.Run(command);
    }
}