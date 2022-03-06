using Dhl.Execs;
using Dhl.Model;

namespace Dhl.Helpers;

class SolutionHelper
{
    public static void CreateSolution(CreateModel model)
    {

        if (model.PutSolutionAndProjectInSamePlace == false)
        {
            var command = $"dotnet new sln -n {model.GetSolutionName()} --output {model.GetSolutionName()}";
            BashExec.Run(command);
        }
    }

    public static void LinkProjectToSolution(CreateModel model)
    {
        if (model.PutSolutionAndProjectInSamePlace == false)
        {
            var command = $"dotnet sln ./{model.GetSolutionName()}/{model.GetSolutionName()}.sln add ./{model.GetSolutionName()}/{model.ProjectName} ";
            BashExec.Run(command);
        }
    }
}