using System.ComponentModel.DataAnnotations;

namespace Dhl.Options;
enum TemplateTypes
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
    mvc
}