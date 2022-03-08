using System.ComponentModel.DataAnnotations;

namespace Dhl.Options;
public enum AddTemplateTypes
{
    [Display(Name = "New Class")]
    Class,

    [Display(Name = "New Interface")]
    Interface,
}