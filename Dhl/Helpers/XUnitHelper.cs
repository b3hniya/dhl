using Dhl.Model;
using Execs;

namespace Dhl.Helpers;

class XUnitHelper
{
    public static void AddXUnitProject(CreateModel model)
    {
        if (model.AddXUnit())
        {
            string command = $"dotnet new xunit -n {model.GetXUnitProjectName()} --output ./{model.GetSolutionName()}/{model.GetXUnitProjectName()}";
            BashExec.Run(command);

            LinkXunitToSolution(model);
            AddProjectReferenceToXunitProject(model);

            Console.WriteLine("XUnit project added to application successfully.");
        }
    }

    private static void LinkXunitToSolution(CreateModel model)
    {
        var command = $"dotnet sln ./{model.GetSolutionName()}/{model.GetSolutionName()}.sln add ./{model.GetSolutionName()}/{model.GetXUnitProjectName()} ";
        BashExec.Run(command);
    }

    private static void AddProjectReferenceToXunitProject(CreateModel model)
    {
        var command = $"dotnet add ./{model.GetSolutionName()}/{model.GetXUnitProjectName()} reference ./{model.GetSolutionName()}/{model.ProjectName}";
        BashExec.Run(command);
    }

}
