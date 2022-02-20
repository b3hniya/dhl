using Dhl.Helpers;
using Sharprompt;

var model = Prompt.Bind<PromptModel>();

GitHelper.AddGitToProject(model);