using Dhl.Helpers;
using Dhl.Model;
using Sharprompt;

namespace Dhl.Commands;

public class AddCommand
{
    public static void Handle()
    {
        var model = Prompt.Bind<AddModel>();
        TemplateHelper.CreateFileBasedOnTemplate(model);
    }
}