using Dhl.Execs;
using Dhl.Model;

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


    public static void CreateFileBasedOnTemplate(AddModel model)
    {
        var command = String.Empty;
        if (model.Template.ToString() == "Class")
        {
            command += $"echo 'class {model.FileName}\n{{\n\tpublic void {model.FileName}()\n\t{{\n\t}}\n}}' > {model.FileName}.cs";
        }

        BashExec.Run(command);
    }
}