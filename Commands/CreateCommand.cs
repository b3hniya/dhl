using Sharprompt;
using Dhl.Helpers;
using Dhl.Model;
using Dhl.Options;

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

        if (model.Template != CreateTemplateTypes.xunit && model.PutSolutionAndProjectInSamePlace == false)
        {
            model.SetAddXunit(
                Prompt.Confirm("Add XUnit Project to solution")
            );
        }

        if (model.AddXUnit())
        {
            string defaultName = model.ProjectName + "UnitTest";
            string XUnitProjectName = Prompt.Input<string>("please enter unit test project name", defaultName);

            model.SetXUnitProjectName(XUnitProjectName);
        }

        SolutionHelper.CreateSolution(model);

        TemplateHelper.CreateProjectBasedOnTemplate(model);

        SolutionHelper.LinkProjectToSolution(model);

        ReadmeHelper.AddReadmeFile(model);
        GitHelper.AddGitToSolution(model);

        XUnitHelper.AddXUnitProject(model);
    }
}