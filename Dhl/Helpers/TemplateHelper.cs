using Dhl.Model;
using Dhl.Model.Options;
using Execs;

namespace Dhl.Helpers;

class TemplateHelper
{
    public static void CreateProjectBasedOnTemplate(CreateModel model)
    {
        string command = "dotnet new ";

        command += model.Template switch
        {
            var x when (_isAvaloniaTemplate(x))
                => $"{_getAvaloniaTemplateName(x)} ",

            _ => $"{model.Template} ",
        };

        command += $"-n {model.ProjectName}";

        if (model.PutSolutionAndProjectInSamePlace == false)
            command += $" --output ./{model.GetSolutionName()}/{model.ProjectName}";


        BashExec.Run(command);
    }


    public static void CreateFileBasedOnTemplate(AddModel model)
    {
        string command = String.Empty;
        string fileName = model.FileName;

        command += model.Template switch
        {
            AddTemplateTypes.Class
                => $"echo 'class {fileName}\n{{\n\tpublic {fileName}()\n\t{{\n\t}}\n}}' > {fileName}.cs",

            AddTemplateTypes.Interface
                => $"echo 'interface {fileName}\n{{\n}}' > {fileName}.cs", 
            
            var t when (_isAvaloniaTemplate(t))
                => $"dotnet new {_getAvaloniaTemplateName(t)} --name {fileName}"
        };

        BashExec.Run(command);
    }


    private static bool _isAvaloniaTemplate(CreateTemplateTypes x)
        => x == CreateTemplateTypes.avalonia_app ||
           x == CreateTemplateTypes.avalonia_mvvm ||
           x == CreateTemplateTypes.avalonia_xplat;

    private static bool _isAvaloniaTemplate(AddTemplateTypes t)
        => t == AddTemplateTypes.avalonia_resource ||
           t == AddTemplateTypes.avalonia_styles ||
           t == AddTemplateTypes.avalonia_templatedcontrol ||
           t == AddTemplateTypes.avalonia_usercontrol ||
           t == AddTemplateTypes.avalonia_window;

    private static string _getAvaloniaTemplateName(CreateTemplateTypes x)
        => string.Join(".", x.ToString().Split("_"));
    
    private static string _getAvaloniaTemplateName(AddTemplateTypes t)
        => string.Join(".", t.ToString().Split("_"));
}