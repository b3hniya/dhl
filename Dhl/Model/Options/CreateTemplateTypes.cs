using System.ComponentModel.DataAnnotations;

namespace Dhl.Model.Options;
enum CreateTemplateTypes
{
    [Display(Name = "Console application")]
    console,

    [Display(Name = "Empty web application")]
    web,

    [Display(Name = "Grpc service")]
    grpc,

    [Display(Name = "Web api")]
    webapi,

    [Display(Name = "Web application using razor pages")]
    webapp,

    [Display(Name = "Web application (Model-View-Controller)")]
    mvc,

    [Display(Name = "Blazor Server application")]
    blazorserver,


    [Display(Name = "Blazor web assembly application")]
    blazorwasm,

    [Display(Name = "Class Library")]
    classlib,

    [Display(Name = "XUnit Test project")]
    xunit, 
    
    [Display(Name = "Avalonia Desktop Application")]
    avalonia_app, 
    
    [Display(Name = "Avalonia Desktop Application (MVVM)")]
    avalonia_mvvm,
    
    [Display(Name = "Avalonia Cross platform")]
    avalonia_xplat,
}