using System.ComponentModel.DataAnnotations;
using Dhl.Execs;
using Dhl.Options;

class PromptModel
{

    [Display(Name = "Choose your preferred template")]
    [Required]
    public TemplateTypes Template { get; set; }

    [Display(Name = "Project name")]
    [Required]
    public string ProjectName { get; set; }

    // [Display(Name = "Put solution and project in the same place")]
    // public bool PutSolutionAndProjectInSamePlace { get; set; }

    // [Display(Name = "Solution Name")]
    // public string SolutionName;

    [Display(Name = "add git to your project")]
    [Required]
    public bool GitIgnoreFile { get; set; }
}
