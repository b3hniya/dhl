using System.ComponentModel.DataAnnotations;

namespace Dhl.Model.Options;
public enum AddTemplateTypes
{
    [Display(Name = "New Class")]
    Class,

    [Display(Name = "New Interface")]
    Interface,
    
    [Display(Name = "New Avalonia Resource")]
    avalonia_resource, 
    
    [Display(Name = "New Avalonia Style File")]
    avalonia_styles, 
    
    [Display(Name = "New Avalonia Template Control")]
    avalonia_templatedcontrol, 
    
    [Display(Name = "New Avalonia User Control")]
    avalonia_usercontrol,
    
    [Display(Name = "New Avalonia Window")]
    avalonia_window
}