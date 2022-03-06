using Dhl.Execs;

namespace Dhl.Helpers;

class TemplateHelper
{
    public static void CreateProjectBasedOnTemplate(CreateModel model)
    {
        var command = $"dotnet new {model.Template.ToString()} -n {model.ProjectName}";

        if (model.PutSolutionAndProjectInSamePlace == false)
            command += $" --output ./{model.GetSolutionName()}/{model.ProjectName}";


        BashExec.Run(command);
    }
}