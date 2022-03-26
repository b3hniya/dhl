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
        string command = String.Empty;
        string fileName = model.FileName;

        switch (model.Template.ToString())
        {
            case "Class":
                command += $"echo 'class {fileName}\n{{\n\tpublic {fileName}()\n\t{{\n\t}}\n}}' > {fileName}.cs";
                break;

            case "Interface":
                command += $"echo 'interface {fileName}\n{{\n}}' > {fileName}.cs";
                break;

            default:
                command = "";
                break;
        }

        BashExec.Run(command);
    }
}