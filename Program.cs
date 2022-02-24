using System.CommandLine;
using Dhl.Commands;

RootCommand rootCommand = new();
Command create = new("create");
create.SetHandler(() =>
{
    CreateCommand.Handle();
});

rootCommand.Add(create);

return await rootCommand.InvokeAsync(args);