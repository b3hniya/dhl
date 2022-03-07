using System.ComponentModel.DataAnnotations;
using Dhl.Options;

namespace Dhl.Model;
public class AddModel
{

    [Display(Name = "Choose your preferred template")]
    [Required]
    public AddTemplateTypes Template { get; set; }

    [Display(Name = "Enter file name")]
    [Required]
    public string FileName { get; set; } = "NewClass";
}