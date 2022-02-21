using System.ComponentModel.DataAnnotations;
using Dhl.Options;

class PromptModel
{
    //Optional Props
    private string _projectName = string.Empty;
    public string GetProjectName() => _projectName;
    public string SetProjectName(string name) => _projectName = name;


    //Required Props
    [Display(Name = "Choose your preferred template")]
    [Required]
    public TemplateTypes Template { get; set; }

    // [Display(Name = "Put solution and project in the same place")]
    // public bool PutSolutionAndProjectInSamePlace { get; set; }

    // [Display(Name = "Solution Name")]
    // public string SolutionName;

    [Display(Name = "add git to your project")]
    [Required]
    public bool GitIgnoreFile { get; set; }
}
