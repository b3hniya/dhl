using Sharprompt;
using Dhl.Helpers;
using Dhl.Model;

namespace Dhl.Commands;

class CreateCommand
{
    public static void Handle()
    {
        var model = Prompt.Bind<CreateModel>();

        if (model.PutSolutionAndProjectInSamePlace == false)
        {
            var solutionName = Prompt.Input<string>("please enter solution name", model.ProjectName);
            model.SetSolutionName(solutionName);
        }

        SolutionHelper.CreateSolution(model);

        TemplateHelper.CreateProjectBasedOnTemplate(model);

        SolutionHelper.LinkProjectToSolution(model);

        ReadmeHelper.AddReadmeFile(model);
        GitHelper.AddGitToSolution(model);
    }
}