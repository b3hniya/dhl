using System.ComponentModel.DataAnnotations;
using Dhl.Options;

namespace Dhl.Model;
class CreateModel
{
    //Optional Props
    private static string _solutionName = string.Empty;
    public string GetSolutionName() => _solutionName;
    public string SetSolutionName(string name) => _solutionName = name;


    private bool _addXUnit = false;
    public bool AddXUnit() => _addXUnit;
    public void SetAddXunit(bool add) => _addXUnit = add;

    private static string _xUnitProjectName = string.Empty;
    public string GetXUnitProjectName() => _xUnitProjectName;
    public string SetXUnitProjectName(string name) => _xUnitProjectName = name;


    //Required Props
    [Display(Name = "Choose your preferred template")]
    [Required]
    public CreateTemplateTypes Template { get; set; }


    [Display(Name = "Add git to your project")]
    [Required]
    public bool AddGit { get; set; }


    [Display(Name = "Add README.md file to your project")]
    [Required]
    public bool AddReadme { get; set; }


    [Display(Name = "Put solution and project in the same place")]
    [Required]
    public bool PutSolutionAndProjectInSamePlace { get; set; }

    [Display(Name = "Enter project name")]
    [Required]
    public string ProjectName { get; set; } = "NewProject";
}
