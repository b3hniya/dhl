using System.ComponentModel.DataAnnotations;

namespace Dhl.Options;
enum TemplateTypes
{
    [Display(Name = "empty web template.")]
    web,

    [Display(Name = "grpc template.")]
    grpc,

    [Display(Name = "web api template.")]
    webapi,

    [Display(Name = "web application using razor pages template.")]
    webapp,

    [Display(Name = "mvc template.")]
    mvc
}