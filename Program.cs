using Dhl.Helpers;
using Sharprompt;

var model = Prompt.Bind<PromptModel>();

GitHelper.AddGitToSolution(model);