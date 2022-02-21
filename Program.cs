using Dhl.Helpers;
using Sharprompt;


var model = Prompt.Bind<PromptModel>();

var projectInThisFolder = Prompt.Confirm("Do you want to initialize your project in this folder");
if (projectInThisFolder == false)
{
    var projectName = Prompt.Input<string>("please Enter project name");
    model.SetProjectName(projectName);
}

//Implement add solution and project in a same directory
// var solutionAndProjectInTheSameFolder

TemplateHelper.CreateProjectBasedOnTemplate(model);
GitHelper.AddGitToSolution(model);