using System.ComponentModel.DataAnnotations;

namespace Dhl.Model.Options;
public enum AddTemplateTypes
{
    [Display(Name = "New Class")]
    Class,

    [Display(Name = "New Interface")]
    Interface,
}