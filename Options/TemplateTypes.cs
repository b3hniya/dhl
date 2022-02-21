using System.ComponentModel.DataAnnotations;

namespace Dhl.Options;
enum TemplateTypes
{
    [Display(Name = "Console application template.")]
    console,

    [Display(Name = "Empty web app template.")]
    web,

    [Display(Name = "Grpc template.")]
    grpc,

    [Display(Name = "Web api template.")]
    webapi,

    [Display(Name = "Web app using razor pages template.")]
    webapp,

    [Display(Name = "Web app mvc template (Model-View-Controller).")]
    mvc
}